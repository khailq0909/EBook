using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace EBook.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int BookId { get; set; }//FK: liên kết sang bảng Book
        //Order - Book: M-1
        public Book Book { get; set; }// Tạo Object Book

        public string UserEmail { get; set; }//
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

    }

}
