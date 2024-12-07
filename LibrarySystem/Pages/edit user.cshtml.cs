using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Project.Pages
{
    public class edit_userModel : PageModel
    {
        public User User { get; set; }

        public void OnGet(int userId)
        {
            // Fetch the user data from the database based on userId
            // For now, sample data is used
            User = new User
            {
                Id = userId,
                UserName = "Sample User",
                Email = "sample.user@example.com",
                ID = "12345",
                Role = "User"
            };
        }

        public IActionResult OnPost(int userId, string userName, string email, string id, string role)
        {
            // Update the user data in the database
            // For demonstration, assume the user data is updated successfully
            return RedirectToPage("AllUsers");
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
