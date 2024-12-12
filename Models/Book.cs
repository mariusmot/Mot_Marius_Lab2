﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Mot_Marius_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Titlul cartii este obligatoriu")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Titlul trebuie să aiba intre 3 si 150 de caractere")]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public ICollection<Borrowing>? Borrowings { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
