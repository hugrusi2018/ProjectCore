using System;
using System.Collections.Generic;
using System.Linq;
using DAL = ProjectCore.DAL;

namespace ProjectCore.Logica.BL
{
    public class Projects
    {
        /// <summary>
        /// CREATE PROJECTS
        /// </summary>
        /// <param name="title"></param>
        /// <param name="details"></param>
        /// <param name="expectedCompletationDate"></param>
        /// <param name="tenantId"></param> 
        public void CreateProjects(string title,
                                   string details,
                                   DateTime? expectedCompletationDate,
                                   int? tenantId)
        {
            ProjectCore.DAL.Models.ProjectCoreContext _context = new ProjectCore.DAL.Models.ProjectCoreContext();
            _context.Projects.Add(new ProjectCore.DAL.Models.Projects
            {
                Title = title,
                Details = details,
                ExpectedCompletionDate = expectedCompletationDate,
                TenantId = tenantId,
                CreatedAt = DateTime.Now
            });

            _context.SaveChanges();

        }

        /// <summary>
        /// GET PROJECTS BY ID OR TENANT OR USER PROJECT
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Models.DB.Projects> GetPojects(int? id, int? tenantId, string userId = null)
        {
            DAL.Models.ProjectCoreContext _context = new DAL.Models.ProjectCoreContext();

            //var listProjectsEF = _context.Projects;

            var listProjectsEF = (from _projects in _context.Projects
                                  select _projects).ToList();

            if (id != null)
                listProjectsEF = listProjectsEF.Where(x => x.Id == id).ToList();
            if (tenantId != null)
                listProjectsEF = listProjectsEF.Where(x => x.TenantId == tenantId).ToList();
            if (!string.IsNullOrEmpty(userId))
                listProjectsEF = (from _projects in listProjectsEF
                                  join _userProjects in _context.UserProjects on _projects.Id equals _userProjects.ProjectId
                                  where _userProjects.UserId.Equals(userId)
                                  select _projects).ToList();

            var listProjects = (from _projects in listProjectsEF
                                select new Models.DB.Projects
                                {
                                    Id = _projects.Id,
                                    Title = _projects.Title,
                                    Details = _projects.Details,
                                    ExpectedCompletationDate = _projects.ExpectedCompletionDate,
                                    TenantId = _projects.TenantId,
                                    CreateAt = _projects.CreatedAt,
                                    UpdateAt = _projects.UpdatedAt
                                }).ToList();

            return listProjects;
        }


        /// <summary>
        /// update project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="details"></param>
        /// <param name="expectedCompletationDate"></param>
        public void UpdateProjects(int id,
                                   string title,
                                   string details,
                                   DateTime? expectedCompletationDate)
        {
            ProjectCore.DAL.Models.ProjectCoreContext _context = new ProjectCore.DAL.Models.ProjectCoreContext();

            var projectEF = _context.Projects.Where(x => x.Id == id).FirstOrDefault();

            //(from _projects in _context.Projects
            // where _projects.Id == id
            // select _projects).FirstOrDefault();

            projectEF.Title = title;
            projectEF.Details = details;
            projectEF.ExpectedCompletionDate = expectedCompletationDate;
            projectEF.UpdatedAt = DateTime.Now;

            _context.SaveChanges();

        }
        
        /// <summary>
        /// update project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="details"></param>
        /// <param name="expectedCompletationDate"></param>
        public void DeleteProjects(int? id)
        {
            ProjectCore.DAL.Models.ProjectCoreContext _context = new ProjectCore.DAL.Models.ProjectCoreContext();


            //validamos dependencias de la tabla proyectos
            if(_context.Artifacts.Any(x => x.ProjectId  == id) || _context.UserProjects.Any(x => x.ProjectId == id))
            {
                return;
            }

            var projectEF = _context.Projects.Where(x => x.Id == id).FirstOrDefault();

            _context.Projects.Remove(projectEF);


            //(from _projects in _context.Projects
            // where _projects.Id == id
            // select _projects).FirstOrDefault();
            

            _context.SaveChanges();

        }
    }
}
