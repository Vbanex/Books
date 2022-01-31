using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Books.Models
{
    public class Book
    {
        public int Id { get; set;  }
        public string Title { get; set; }
        public string Author { get; set; }

        [Display(Name = "Relasese Date")]
        [DataType(DataType.Date)]
        public DateTime ReleasedDate { get; set; }
        public string Genre { get; set; }

        [Column (TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
