using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DAL = ProjectCore.DAL;

namespace ProjectCore.Controllers
{
    [Authorize]
    public class ProjectsController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        //private List<Logica.Models.ViewModel.ProjectsIndexViewModel> listProjects;

        public ProjectsController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;

            //listProjects = new List<Logica.Models.ViewModel.ProjectsIndexViewModel>();
            //listProjects.Add(new Logica.Models.ViewModel.ProjectsIndexViewModel
            //{
            //    Id=1,
            //    Details = "Project managment details",
            //    Title = "Project managment",
            //    ExpectedCompletionDate = DateTime.Now.AddDays(20),
            //    CreatedAt = DateTime.Now.AddDays(5)
            //});

            
            //listProjects.Add(new Logica.Models.ViewModel.ProjectsIndexViewModel
            //{
            //    Id = 2,
            //    Details = "Sales managment details",
            //    Title = "Sales managment",
            //    ExpectedCompletionDate = DateTime.Now.AddDays(30),
            //    CreatedAt = DateTime.Now.AddDays(10)
            //});
     
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Logica.Models.BindingModel.ProjectsCreateBindingModel model)
        {

            if (ModelState.IsValid)
            {
                IdentityUser user = await _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);

                Logica.BL.Tenants tenants = new Logica.BL.Tenants();
                var tenant = tenants.GetTenants(user.Id).FirstOrDefault();

                Logica.BL.Projects projects = new Logica.BL.Projects();
                projects.CreateProjects(model.Title,
                    model.Details,
                    model.ExpectedCompletionDate,
                    tenant.Id);

                return RedirectToAction("Index");
            }

            //return View();
            return View(model);
        }

        public async Task<IActionResult> Index()
        {


            IdentityUser user = await _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            Logica.BL.Tenants tenants = new Logica.BL.Tenants();
            var tenant = tenants.GetTenants(user.Id).FirstOrDefault();


            Logica.BL.Projects projects = new Logica.BL.Projects();


            var result = await _userManager.IsInRoleAsync(user, "Admin") ? projects.GetPojects(null, tenant.Id) : projects.GetPojects(null, tenant.Id, user.Id);

            var listProjects = result.Select(x => new Logica.Models.ViewModel.ProjectsIndexViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Details = x.Details,
                CreatedAt = x.CreateAt,
                ExpectedCompletionDate = x.ExpectedCompletationDate,
                UpdateAt = x.UpdateAt

            });

            listProjects = tenant.Plan.Equals("premium") ?
                            listProjects :
                            listProjects.Take(1).ToList();

            return View(listProjects);


        }
 
        public IActionResult Edit(int? id)
        {

            Logica.BL.Projects projects = new Logica.BL.Projects();
            var project = projects.GetPojects(id, null).FirstOrDefault();

            var projectBindingModel = new Logica.Models.BindingModel.ProjectsEditBindingModel()
            {
                Id = project.Id,
                Details = project.Details,
                Title = project.Title,
                ExpectedCompletionDate = project.ExpectedCompletationDate

            };

            return View(projectBindingModel);
        }

        [HttpPost]
        public IActionResult Edit(Logica.Models.BindingModel.ProjectsEditBindingModel model)
        {
            if(ModelState.IsValid)
            {
                Logica.BL.Projects projects = new Logica.BL.Projects();
                projects.UpdateProjects(model.Id,
                                        model.Title,
                                        model.Details,
                                        model.ExpectedCompletionDate);

                return RedirectToAction("Index");
            }
            return View(model);

        }

        public IActionResult Details(int? id)
        {

            Logica.BL.Projects projects = new Logica.BL.Projects();
            var project = projects.GetPojects(id, null).FirstOrDefault();

            var projectViewModel = new Logica.Models.ViewModel.ProjectsDetailsViewModel()
            {
                Id = project.Id,
                Details = project.Details,
                Title = project.Title,
                ExpectedCompletionDate = project.ExpectedCompletationDate,
                CreatedAt = project.CreateAt,
                UpdateAt = project.UpdateAt

            };

            return View(projectViewModel);
        }


        public IActionResult Delete(int? id)
        {
            Logica.BL.Projects projects = new Logica.BL.Projects();

            projects.DeleteProjects(id);

            return RedirectToAction("Index");
        }
        
    }
}