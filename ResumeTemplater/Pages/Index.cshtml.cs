using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
namespace ResumeTemplater.Pages
{
    public class Index1Model : PageModel
    {
        public string FullName { get; set; }
        public string LinkedInUsername { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> Languages { get; set; }
        public void OnGet()
        {
            FullName = "Maryna Haiduk";
            LinkedInUsername = "linkedin.com/in/maryna-haiduk-3a7644227/";
            YearsOfExperience = 1;
            Languages = new List<string>() 
            {
                "English",
				"Russian",
				"Ukrainian"
			};
        }
    }
}
