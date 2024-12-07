using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Project.Pages
{
    public class Index1Model : PageModel
    {
        public List<Fine> Fines { get; set; }

        public void OnGet()
        {
            // Sample data for display
            Fines = new List<Fine>
            {
                new Fine { Id = 1, UserName = "John Doe", BookName = "C# Programming", Description = "Overdue", Amount = 10.00, Status = "Pending", Date = System.DateTime.Now.AddDays(-5) },
                new Fine { Id = 2, UserName = "Jane Smith", BookName = "ASP.NET Core Guide", Description = "Damaged Book", Amount = 20.00, Status = "Paid", Date = System.DateTime.Now.AddDays(-10) },
                new Fine { Id = 3, UserName = "Alice Johnson", BookName = "Learn Razor Pages", Description = "Overdue", Amount = 15.00, Status = "Pending", Date = System.DateTime.Now.AddDays(-3) }
            };
        }


        public IActionResult OnPost(int FineId)
        {
            // Here, you would typically update the database to mark the fine as paid
            var fine = Fines.FirstOrDefault(f => f.Id == FineId);
            if (fine != null)
            {
                fine.Status = "Paid"; // Update the status
                // Update the database logic goes here
            }

            return RedirectToPage(); // Refresh the page
        }
    }
    public class Fine
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
        public System.DateTime Date { get; set; }
    }


}

    