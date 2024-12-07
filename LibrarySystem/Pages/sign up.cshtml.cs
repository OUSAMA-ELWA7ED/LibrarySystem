using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Project.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string ID { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            // Handle form submission logic here
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Save the form data to a database or perform other operations
            return RedirectToPage("Success"); // Redirect to a success page
        }
    }
}

