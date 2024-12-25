using LibrarySystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibrarySystem.Pages
{
    public class TrackBorrowingsModel : PageModel
    {
        [BindProperty]
        public User_Borrow_Book BorrowData { get; set; }

        private readonly ILogger<TrackBorrowingsModel> _logger;
        public Library_System _librarySystem { get; set; }

        public TrackBorrowingsModel(ILogger<TrackBorrowingsModel> logger, Library_System librarySystem)
        {
            _logger = logger;
            _librarySystem = librarySystem;
        }


        public IActionResult OnPostAddBorrow()
        {

            if (ModelState.IsValid)
            {
                _librarySystem.AddBorrowRecord(BorrowData);
                return RedirectToPage("Index");
            }
            return Page();
        }



    }
}
