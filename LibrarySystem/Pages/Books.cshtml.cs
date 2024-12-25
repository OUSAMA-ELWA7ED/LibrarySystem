using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using LibrarySystem.Models;
using System.Data;
using Microsoft.AspNetCore.Mvc;
namespace LibrarySystem.Pages
{
    public class AllBooksModel : PageModel
    {
        private readonly ILogger<AllBooksModel> logger;
        public readonly Library_System LB = new Library_System();

        public DataTable bookData { get; set; }

        public AllBooksModel(ILogger<AllBooksModel> _logger, Library_System LB)
        {
            _logger = logger;
            this.LB = LB;

        }
        public void OnGet()
        {
            bookData = LB.ReadBookData("BOOK");
        }
        public List<BookCategory> BookCategories { get; set; }

        public class BookCategory
        {
            public string Name { get; set; }
            public List<string> Books { get; set; }
        }
        public IActionResult OnPostEdit(string name)
        {
            return RedirectToPage("/EditBookInfo", new {BookName = name});
        }
    }
}

      
    



