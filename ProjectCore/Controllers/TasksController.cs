using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectCore.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index(int? projectId)
        {
            Logica.BL.Tasks tasks = new Logica.BL.Tasks();
            var task = tasks.GetTasks(projectId, null);

            var taskViewModel = task.Select(x => new Logica.Models.ViewModel.TasksIndexViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Details = x.Details,
                ExpirationDate = x.ExpirationDate,
                IsCompleted = x.IsCompleted,
                Effort = x.Effort,
                RemainingWork = x.RemainingWork,
                StateId = x.StateId,
                ActivityId = x.ActivityId,
                PriorityId = x.PriorityId,
                ProjectId = x.ProjectId
            }).ToList();

            Logica.BL.Projects projects = new Logica.BL.Projects();
            var project = projects.GetPojects(projectId, null).FirstOrDefault();
            ViewBag.Project = project;

            return View(taskViewModel);
        }

        public IActionResult Create(int? projectId)
        {
            var taskBindingModel = new Logica.Models.BindingModel.TaskCreateBindingModel
            {
                ProjectId = projectId
            };

            Logica.BL.States states = new Logica.BL.States();
            ViewBag.States = states.GetStates();

            Logica.BL.Activities activities = new Logica.BL.Activities();
            ViewBag.Activities = activities.GetActivities();

            Logica.BL.Priorities priorities = new Logica.BL.Priorities();
            ViewBag.Priorities = priorities.GetPriorities();

            return View();
        }

        public IActionResult Calendar(int? projectId)
        {
            Logica.BL.Projects projects = new Logica.BL.Projects();
            var project = projects.GetPojects(projectId, null).FirstOrDefault();

            ViewBag.Project = project;
            return View();
        }

        public IActionResult GetTasksControllers(int? projectId)
        {
            Logica.BL.Tasks tasks = new Logica.BL.Tasks();
            var listTasks = tasks.GetTasks(projectId, null);

            var listTasksCalendarViewModel = listTasks.Select(x => new Logica.Models.ViewModel.TasksGetTasksCalendarViewModel
            {
                Id = x.Id,
                Title = x.Title,
                AllDay = true,
                Color = "#FFFFFF",
                Start = x.ExpirationDate.Value.AddDays(Convert.ToDouble(-x.RemainingWork)).ToString("yyyy-MM-dd HH:mm:ss"),
                End = x.ExpirationDate.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                TextColor = "#000000"
            }).ToList();

            return View();
        }

    }
}