using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Used_Books.Data;
using Used_Books.Models;

namespace Used_Books.Pages.Eventi
{
    public class IndexModel : PageModel
    {
        private readonly Used_Books.Data.ApplicationDbContext _context;

        public IndexModel(Used_Books.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public SelectList Courses { get; set; }   //elementi per il filtro per Corso di Studi
        [BindProperty(SupportsGet = true)]
        public string StudyCourse { get; set; }

        public SelectList Classes { get; set; }   //elementi per il filtro per Classe
        [BindProperty(SupportsGet = true)]
        public string BookClass { get; set; }

        public SelectList Subjects { get; set; }   //elementi per il filtro per Materia
        [BindProperty(SupportsGet = true)]
        public string BookSubject { get; set; }

        public SelectList Students { get; set; }   //elementi per il filtro per Studente
        [BindProperty(SupportsGet = true)]
        public string BookStudent { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> courseQuery = from m in _context.Book  //Query per il Corso di Studi
                                            orderby m.Corso_studio
                                            select m.Corso_studio;

            IQueryable<string> classQuery = from m in _context.Book  //Query per la classe
                                             orderby m.Classe
                                             select m.Classe;

            IQueryable<string> subjectQuery = from m in _context.Book  //Query per la materia
                                            orderby m.Materia
                                            select m.Materia;

            IQueryable<string> studentQuery = from m in _context.Book  //Query per lo studente
                                              orderby m.Studente
                                              select m.Studente;

            var books = from m in _context.Book
                         select m;

            if (!string.IsNullOrEmpty(StudyCourse))
            {
                books = books.Where(s => s.Corso_studio==StudyCourse);
            }

            if (!string.IsNullOrEmpty(BookClass))
            {
                books = books.Where(s => s.Classe == BookClass);
            }

            if (!string.IsNullOrEmpty(BookSubject))
            {
                books = books.Where(s => s.Materia == BookSubject);
            }

            if (!string.IsNullOrEmpty(BookStudent))
            {
                books = books.Where(s => s.Studente == BookStudent);
            }

            Courses = new SelectList(await courseQuery.Distinct().ToListAsync());
            Classes = new SelectList(await classQuery.Distinct().ToListAsync());
            Subjects= new SelectList(await subjectQuery.Distinct().ToListAsync());
            Students = new SelectList(await studentQuery.Distinct().ToListAsync());

            Book = await books.ToListAsync();
        }
    }
}
