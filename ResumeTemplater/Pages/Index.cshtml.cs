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

        public List<string> ProfessionalProfile  { get; set; }
        public string LinkedInUsername { get; set; }
        public int YearsOfExperience { get; set; }
        public Dictionary<string, List<string>> Technologies { get; set; }
        public List<string> CoreCompetencies { get; set; }
		public List<string> Languages { get; set; }

        public List<Education> Educations { get; set; }
		public void OnGet()
        {
            FullName = "Maryna Haiduk";
            LinkedInUsername = "linkedin.com/in/maryna-haiduk-3a7644227/";
            YearsOfExperience = 1;

            ProfessionalProfile = new List<string>()
            {
                "Highly motivated, detail-oriented, and talented professional with strong analytical skills and a methodical mindset, dedicated to continuous learning and thriving in development, programming, and technological innovation.",
                "Expertise in the full Software Development Life Cycle (SDLC) and a solid grasp of globally supported front-end and back-end frameworks.",
                "Passionately engaged in the creation and transformation of web applications using a wide range of technologies like .Net, C#, SQL, JavaScript, and HTML. Committed to building scalable, performance-optimized, and maintainable software, and cherishing the opportunity to contribute to a collaborative, high-achieving team.",
                "Offering a fresh perspective and strong problem-solving skills, with a blend of professional experience and an academic background, to effectively manage development and project documentation.",
                "Self-organized, technically skilled, and systematic, capable of working independently or collaboratively within team settings, ensuring on-time project delivery. Enthusiastic, adaptable, and dedicated to delivering top-quality solutions, a valuable asset in any development environment."
            };

			Technologies = new Dictionary<string, List<string>>();
			Technologies.Add("Backend", 
                new List<string> { "C#", "ASP.NET", "MVC", "Razor Pages", "WEB API", " Entity Framework", "LINQ", "SQL" });
            Technologies.Add("Databases",
                new List<string> { "MS SQL Server" });
            Technologies.Add("Frontend",
                new List<string> { "Blazor", "JavaScript", "HTML", "CSS" }
                );

            CoreCompetencies = new List<string>()
            {
				"Software Development Lifecycle",
                "Object Oriented Design and Programming",
                "Solutions Architecture", 
                "Requirement Gathering & Analysis",
                "Quality Assurance",
                "Data Engineering",
                "Team Collaboration",
                "Continuous Improvement & Learning",
                "Software Version Control Systems"
			};

			Languages = new List<string>()
			{
				"English",
				"Russian",
				"Ukrainian"
			};

            Educations = new List<Education>()
            {
                new Education ("HappyArray", "Software development course - ASP.Net MVC, C#, MS SQL, SQL, HTML, CSS, JavaScript"),
                new Education ("Codecademy", "Programming courses - SQL, C#, ASP.Net"),
                new Education ("SheCodes", "Coding workshop - HTML, CSS, JavaScript"),
                new Education ("Ukrainian National Tchaikovsky Academy of Music, Kyiv, Ukraine ", " Ph.D. in Musicology, Master’s in Musicology, Bachelor's in Musicology")
            };
		}
    }
}
