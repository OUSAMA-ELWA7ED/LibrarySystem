using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Project.Pages
{
    public class sign_inModel : PageModel
    {
      

    
       
        
            [BindProperty]
            public string Email { get; set; }

            [BindProperty]
            public string Password { get; set; }

            public IActionResult OnPost()
            {
                // Handle sign-in logic here
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                // For example: validate credentials against a database
                bool isValidUser = (Email == "test@example.com" && Password == "password"); // Replace with real validation

                if (isValidUser)
                {
                    return RedirectToPage("Dashboard"); // Redirect to a dashboard or home page
                }

                ModelState.AddModelError(string.Empty, "Invalid email or password");
                return Page();
            }
        
    }
}

