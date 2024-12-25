using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using LibrarySystem.Models;
namespace LibrarySystem.Pages
{
    public class IndexModel : PageModel
    {
        public List<Book> FeaturedBooks { get; set; }

        public void OnGet()
        {
           
            FeaturedBooks = new List<Book>
            {
                new Book { Id = 1, Name = "The Great Gatsby", Publisher = "F. Scott Fitzgerald", CategoryId = 2 },
                new Book { Id = 2, Name = "1984", Publisher = "George Orwell", CategoryId = 2 },
                new Book { Id = 3, Name = "To Kill a Mockingbird", Publisher = "Harper Lee", CategoryId = 2 }
            };
        }
    }


}
