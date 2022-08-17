using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EBook.Models
{
    public class Category
    {
        public int Id { get; set; }//Primary key (auto increment)
        [Required]
        public string Name { get; set; }

        public ICollection<Book> Book { get; set; }// dùng để truy xuất đến bảng book
    }
}
