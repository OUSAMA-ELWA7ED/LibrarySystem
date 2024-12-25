using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using LibrarySystem.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LibrarySystem.Pages
{
    public class ManageBooksModel : PageModel
    {
        [BindProperty]
        public Book bookData { get; set; } 
        

    private readonly ILogger<ManageBooksModel> _logger;
    public Library_System _librarySystem { get; set; }

        // DataTable to hold books data
        public DataTable BookData { get; set; }

    // Constructor injection for logger and Library_System
    public ManageBooksModel(ILogger<ManageBooksModel> logger, Library_System librarySystem)
    {
        _logger = logger;
        _librarySystem = librarySystem;
    }

    public void OnGet()
    {
        // Fetch data from the database
        BookData = _librarySystem.ReadBookData("BOOK");
    }


        public IActionResult OnPostAddBook()
        {

            if (ModelState.IsValid)
            {
                _librarySystem.AddBookRecord(bookData);
                return RedirectToPage("Index");
            }
            return Page();
        }

        public IActionResult OnPostUpdateBook(int BookId, string UpdatedTitle, string UpdatedAuthor, string UpdatedGenre, bool IsAvailable)
        {
            
            
            return RedirectToPage("/ManageBooks");
        }

        public IActionResult OnPostDeleteBook(int BookId)
        {
            
            return RedirectToPage("/ ManageBooks");
        }
    }
  
}
