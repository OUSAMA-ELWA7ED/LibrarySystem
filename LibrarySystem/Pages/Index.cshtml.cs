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
                new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", ImageUrl = "/images/gatsby.jpg" },
                new Book { Id = 2, Title = "1984", Author = "George Orwell", Genre = "Dystopian", ImageUrl = "/images/1984.jpg" },
                new Book { Id = 3, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic", ImageUrl = "/images/mockingbird.jpg" }
            };
        }
    }


}
