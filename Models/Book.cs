using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EBook.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [Url]
        public string Image { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Max length for name of book is less than 30 characters", MinimumLength = 4)]
        public string Name { get; set; }

        [Required]
        [Range(1, 9999)]
        public int Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int CategoryID { get; set; }// Foregin key (Link to Primary key in table Categories)
        public Category Category { get; set; }

        public int AuthorId { get; set; }// Foregin key (Link to Primary key in table Categories)
        public Author Author { get; set; }



        public ICollection<Order> Order { get; set; }

    }
}
