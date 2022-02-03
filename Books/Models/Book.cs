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

        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string Title { get; set; }

        [StringLength(30)]
        [RegularExpression(@"^[A-Z] + [a-zA-Z\s]*$")]
        public string Author { get; set; }

        [Display(Name = "Relasese Date")]
        [DataType(DataType.Date)]
        public DateTime ReleasedDate { get; set; }
        public string Genre { get; set; }

        [Range (1, 100)]
        [DataType(DataType.Currency)]
        [Column (TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
