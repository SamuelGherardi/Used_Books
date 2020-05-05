using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;//libreria che occorre per il decoratore [Authorize]
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Used_Books.Models; //mi collego alla cartella Models che contiene la classe Book
using Microsoft.EntityFrameworkCore;

namespace Used_Books.Pages.MyBooks
{
    [Authorize] //solo un utente registrato può aggedere alla pagina
    public class CreateModel : PageModel
    {
        private readonly Used_Books.Data.ApplicationDbContext _context;

        public CreateModel(Used_Books.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}