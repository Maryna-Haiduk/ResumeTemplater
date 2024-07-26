using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ResumeTemplater.Pages
{
    public class ExperienceModel : PageModel
    {
        public List<Job> ExperienceList { get; set; }
        public List<string> Technologies { get; set; }
        public void OnGet()
        {
            ExperienceList = new List<Job>();
            ExperienceList.Add(
                new Job
                (
                    "Intern Software Developer | DFI, LLC – Remote",
                    "Summer 2023",
                    new List<string>
                    {
                        "Contributed to the development of a comprehensive MVC web application that bridges temporary professionals with dental offices.",
                        "Adhered to Agile methodologies and utilized Git for efficient version control, code collaboration, and project management.",
                        "Implemented enhancements on the request page via AJAX requests, enhancing the user experience and eliminating page reloads.",
                        "Worked on an application that Utilized Entity Framework's code-first approach and migrations for efficient database management.",
                        "Optimized the UI using JavaScript, introducing new functional elements and functions to provide enhanced search functionality"
                    }
                 )
                );
            ExperienceList.Add(
                new Job
                (
                    "Projects experience: Employees Management System",
                    "2023",
                    new List<string>
                    {
                        "Technologies Used: C#, ASP.NET MVC, Entity Framework (Code-First), Database Migration.",
                        "Description: I Implemented CRUD Operations Using a Repository Pattern and created UI pages for creating/updating employees, and showing the list of employees (with buttons “Edit” and “Delete”).Collaborated within a team to gather requirements and brainstorm functional ideas, emphasizing scalability and ease of maintenance in both the database and application design. Implemented CRUD operations, Entity Framework, and repository pattern to align with potential new goals and requirements.",
                    }
                ));
            ExperienceList.Add(
                new Job
                (
                    "Projects experience: Weather App. ",
                    "2023",
                    new List<string>
                    {
                        "Technologies Used: JavaScript, HTML, CSS, Bootstrap.",
                        "Description: Implemented Search Engine, Used Geolocation API and OpenWeather API."
                    }
                ));
            ExperienceList.Add(
                new Job
                (
                    "Projects experience: To-Do List.",
                    "2023",
                    new List<string>
                    {
                        "Technologies Used: Blazor, C#, .NET, MS SQL Server."
                    }
                ));
            ExperienceList.Add(
                new Job
                (
                    "Music History Teacher, PhD Researcher | Ukrainian National Tchaikovsky Academy of Music - Kyiv, Ukraine",
                    "2018 - 2023",
                    new List<string>
                    {
                        "Taught lessons and achieved milestones in curriculum development, collaborated with colleagues to enhance course materials.",
                        "Conducted extensive research as a PhD researcher and presented findings at academic conferences.",
                        "Developed the ability to systematically approach complex problems, collaborate effectively with diverse teams, and continuously enhance analytical and communication skills. "
                    }
                ));
        }
    }
}
