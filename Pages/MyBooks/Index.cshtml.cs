using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization; //libreria che occorre per il decoratore [Authorize]
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Used_Books.Models; //mi collego alla cartella Models che contiene la classe Book


namespace Used_Books.Pages.MyBooks
{
    [Authorize] //solo un utente registrato può aggedere alla pagina
    public class IndexModel : PageModel
    {
        private readonly Used_Books.Data.ApplicationDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager; 
        private readonly UserManager<IdentityUser> _userManager; //questa variabile serve per poter sapere quale è l'utente che in questo momento è loggato

        public IndexModel(Used_Books.Data.ApplicationDbContext context, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IList<Book> Book { get; set; }
        

        public async Task OnGetAsync()
        {
            
            var user = await _userManager.GetUserAsync(User); //ottengo lo UserName dell'utente loggato
            Book = await _context.Book.Where(s=>s.Studente==user.ToString()).ToListAsync(); //in Book, solo i libri dell'utente che in questo momento è loggato
        }
    }
}