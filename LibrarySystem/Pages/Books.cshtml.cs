using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using LibrarySystem.Models;
namespace LibrarySystem.Pages
{
    public class AllBooksModel : PageModel
    {
        public List<BookSection> BookSections { get; set; }

        public void OnGet()
        {
            BookSections = new List<BookSection> { };
        }
    }

    public class BookSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }

    
}
