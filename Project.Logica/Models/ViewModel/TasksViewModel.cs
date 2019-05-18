using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectCore.Logica.Models.ViewModel
{
    public class TasksIndexViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Details")]
        public string Details { get; set; }

        [Display(Name = "ExpirationDate")]
        public DateTime? ExpirationDate { get; set; }

        [Display(Name = "IsCompleted")]
        public bool? IsCompleted { get; set; }

        [Display(Name = "Effort")]
        public int? Effort { get; set; }

        [Display(Name = "RemainingWork")]
        public int? RemainingWork { get; set; }

        [Display(Name = "StateId")]
        public int? StateId { get; set; }

        [Display(Name = "ActivityId")]
        public int? ActivityId { get; set; }

        [Display(Name = "PriorityId")]
        public int? PriorityId { get; set; }

        [Display(Name = "ProjectId")]
        public int? ProjectId { get; set; }
    }

    public class TasksGetTasksCalendarViewModel
    {
        public int Id { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public bool AllDay { get; set; }
        public string TextColor { get; set; }
    }
}
