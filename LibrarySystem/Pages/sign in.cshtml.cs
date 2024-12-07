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
                
                if (!ModelState.IsValid)
                {
                    return Page();
                }

               
                //here we are going to check data from the data base with an if condition if its andmin it'll redirect to an admin page etc
                //for now its just true
                bool checkValidUser=true;
                if (checkValidUser)
                {
                    return RedirectToPage("Index"); 
                }

                ModelState.AddModelError(string.Empty, "Invalid email or password");
                return Page();
            }
        
    }
}

