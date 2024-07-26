using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ResumeTemplater.Pages
{
    public class ContactsModel : PageModel
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string LinkedInUsername { get; set; }
        public string GithubUsername { get; set; }  
		public void OnGet()
        {
            Email = "maryna.i.haiduk@gmail.com";
            PhoneNumber = "(856) - 777 - 6161";
            LinkedInUsername = "linkedin.com/in/maryna-haiduk-3a7644227/";
            GithubUsername = "Maryna-Haiduk";


        }
    }
}
