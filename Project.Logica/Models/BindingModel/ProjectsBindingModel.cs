using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectCore.Logica.Models.BindingModel
{
    public class ProjectsCreateBindingModel
    {
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Details")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "PercentageAdvance")]
        public double PercentageAdvance { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "ExpectedCompletionDate")]
        public DateTime ExpectedCompletionDate { get; set; }
    }

    public class ProjectsEditBindingModel
    {

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Details")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "PercentageAdvance")]
        public double PercentageAdvance { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "ExpectedCompletionDate")]
        public DateTime? ExpectedCompletionDate { get; set; }
    }
}
