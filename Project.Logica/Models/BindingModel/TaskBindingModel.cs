using System;   
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectCore.Logica.Models.BindingModel
{
    public class TaskCreateBindingModel
    {
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Details")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "ExpirationDate")]
        public DateTime? ExpirationDate { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "IsCompleted")]
        public bool IsCompleted { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Effort")]
        public int? Effort { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "RemainingWork")]
        public int? RemainingWork { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "StateId")]
        public int? StateId { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "ActivityId")]
        public int? ActivityId { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "PriorityId")]
        public int? PriorityId { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "ProjectId")]
        public int? ProjectId { get; set; }
    }
}
