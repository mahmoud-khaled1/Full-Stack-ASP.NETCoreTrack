using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookCategory { get; set; }
        public string BookAuthor { get; set; }
        public decimal BookPrice { get; set; }
        public int BookQuantity { get; set; }
    }
}
