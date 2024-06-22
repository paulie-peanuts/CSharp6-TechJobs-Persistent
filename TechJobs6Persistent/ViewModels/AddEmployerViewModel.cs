using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Please add an employer name.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Employer name must be between 2 and 30 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please add an employer location.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Employer location must be between 2 and 30 characters.")]
        public string? Location { get; set; }
    }
}