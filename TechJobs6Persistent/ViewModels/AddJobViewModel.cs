using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Please add a job name.")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Job name must be between 2 and 40 characters.")]
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; } = [];
        public AddJobViewModel() { }

        public AddJobViewModel(List<Employer> employerList) 
        { 
            foreach (Employer employer in employerList)
            {
                string employerDisplayName = employer.Name;
                string employerInputValue = employer.Id.ToString();
                Employers.Add(new SelectListItem(employerDisplayName, employerInputValue));
            }
        }
    }
}