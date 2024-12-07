using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Project.Pages
{
    public class edit_userModel : PageModel
    {
        public User User { get; set; }

        public void OnGet(int userId)
        {
          
            // for now examples is used
            User = new User
            {
                Id = userId,
                UserName = " user",
                Email = "me.user@example.com",
                ID = "12345999",
                Role = "user"
            };
        }

        public IActionResult OnPost(int userId, string userName, string email, string id, string role)
        {
            // in this on post it will update the user data in the database
    
            return RedirectToPage("Search");
        }

        
    }
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }
        public string Role { get; set; }
    }
}
