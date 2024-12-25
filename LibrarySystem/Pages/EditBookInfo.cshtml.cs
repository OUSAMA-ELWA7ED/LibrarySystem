using LibrarySystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Pages
{
    
    public class EditBookInfoModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        [MinLength(2, ErrorMessage = "Please Enter A Valid Name with minimum 2 letters")]
        public string BookName { get; set; }

        [BindProperty]
        public Book EditBook { get; set; }

        public Library_System LB;
        public EditBookInfoModel(Library_System LB)
        {
            this.LB = LB;
        }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            EditBook.Name = BookName;
            LB.EditBook(EditBook);
            return RedirectToPage("/INDEX");

        }
    }

}
