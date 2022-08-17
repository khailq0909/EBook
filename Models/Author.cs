using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EBook.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Max character is 15", MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Max character is 30", MinimumLength = 10)]
        public string FullName { get; set; }

        [Required]
        [Url]
        public string Image { get; set; }

        [Required]
        [MaxLength(200)]
        public string Descrtiption { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}
