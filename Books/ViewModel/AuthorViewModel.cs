using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Books.Models;

namespace Books.ViewModel
{
    public class AuthorViewModel
    {
        public List<Book> Books { get; set; }
        public SelectList Author { get; set; }
        public string BookAuthor { get; set; }
    }
}
