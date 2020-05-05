using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Used_Books.Models
{
    public class Book
    {
        public int id { get; set; }
        [RegularExpression(@"^[0-9]{3}-[0-9]{2}-[0-9]{3}-[0-9]{4}-[0-9]{1}$|^[0-9]{3}-[0-9]{3}-[0-9]{3}-[0-9]{4}$")] //espressione regolare per verificare la correttezza del codice ISBN
        public string ISBN { get; set; }
        public string Nome { get; set; }
        public string Editore { get; set; }
        public string Corso_studio { get; set; }
        public string Classe { get; set; }
        public string Materia { get; set; }
        public string Studente { get; set; }
        public float Prezzo { get; set; }
    }
}
