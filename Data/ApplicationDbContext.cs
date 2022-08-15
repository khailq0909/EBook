using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EBook.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;

namespace EBook.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<BookAuthor> BookAuthor { get; set; }
        public DbSet<Order> Order { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedCategory(builder);
            SeedBook(builder);
            SeedAuthor(builder);
            SeedUser(builder);
            SeedRole(builder);
            SeedUserRole(builder);
            //set key cho bảng BookAuthor  
            builder.Entity<BookAuthor>().HasKey(b => new { b.BookId, b.AuthorId });

            //add dữ liệu cho bảng BookAuthor
            SeedBookAuthor(builder);
        }



        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
               new IdentityUserRole<string>
               {
                   UserId = "1",
                   RoleId = "A"
               },
               new IdentityUserRole<string>
               {
                   UserId = "2",
                   RoleId = "B"
               },
                 new IdentityUserRole<string>
                 {
                     UserId = "3",
                     RoleId = "C"
                 }
           );
        }

        private void SeedRole(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
               new IdentityRole
               {
                   Id = "A",
                   Name = "Admin",
                   NormalizedName = "Admin"
               },
                new IdentityRole
                {
                    Id = "B",
                    Name = "StoreOwner",
                    NormalizedName = "StoreOwner"
                },
               new IdentityRole
               {
                   Id = "C",
                   Name = "Customer",
                   NormalizedName = "Customer"
               }
           );
        }

        private void SeedUser(ModelBuilder builder)
        {
            var admin = new IdentityUser
            {
                Id = "1",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                Email = "admin@gmail.com"
            };
            var storeowner = new IdentityUser
            {
                Id = "2",
                UserName = "storeowner@gmail.com",
                NormalizedUserName = "storeowner@gmail.com",
                Email = "storeowner@gmail.com"
            };
            var customer = new IdentityUser
            {
                Id = "3",
                UserName = "customer@gmail.com",
                NormalizedUserName = "customer@gmail.com",
                Email = "customer@gmail.com"
            };

            //khai báo thư viện để mã hóa mật khẩu cho user
            var hasher = new PasswordHasher<IdentityUser>();

            //set mật khẩu đã mã hóa cho từng user
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            storeowner.PasswordHash = hasher.HashPassword(storeowner, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");

            //add 2 tài khoản test vào bảng User
            builder.Entity<IdentityUser>().HasData(admin,storeowner, customer);
        }

        private void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Marvel" },
                new Category { Id = 2, Name = "DC" },
                new Category { Id = 3, Name = "VietNam" }
                );

        }
        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "Iron Man", Price = 22,Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", Quantity = 22, CategoryID = 1 },
                new Book { Id = 2, Name = "Iron Man", Price = 22,Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", Quantity = 22, CategoryID = 1 },
                new Book { Id = 3, Name = "Iron Man", Price = 22,Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", Quantity = 22, CategoryID = 2 },
                new Book { Id = 4, Name = "Iron Man", Price = 22,Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", Quantity = 22, CategoryID = 2 },
                new Book { Id = 5, Name = "Iron Man", Price = 22,Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", Quantity = 22, CategoryID = 3 },
                new Book { Id = 6, Name = "Iron Man", Price = 22,Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", Quantity = 22, CategoryID = 3 },
                new Book { Id = 7, Name = "Iron Man", Price = 22,Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", Quantity = 22, CategoryID = 2 },
                new Book { Id = 8, Name = "Iron Man", Price = 22,Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", Quantity = 22, CategoryID = 1 },
                new Book { Id = 9, Name = "Iron Man", Price = 22,Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", Quantity = 22, CategoryID = 3 },
                new Book { Id = 10, Name = "Iron Man", Price = 22,Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", Quantity = 22, CategoryID = 1 },
                new Book { Id = 11, Name = "Iron Man", Price = 22,Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", Quantity = 22, CategoryID = 1 }
                );

        }
        private void SeedAuthor(ModelBuilder builder)
        {
            builder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Khai", FullName = "lai Quang Khai", Birth = DateTime.Parse("12/09/1996"), Descrtiption = "edasdádasdas", Image = "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2021/11/19/975665/Kieu-Toc-Son-Tung-Mt.jpeg" },
                new Author { Id = 2, Name = "Hoa", FullName = "lai Quang Hopa", Birth = DateTime.Parse("12/09/1996"), Descrtiption = "edasdádasdas", Image = "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2021/11/19/975665/Kieu-Toc-Son-Tung-Mt.jpeg" },
                new Author { Id = 3, Name = "Vinh", FullName = "lai Quang Vinh", Birth = DateTime.Parse("12/09/1996"), Descrtiption = "edasdádasdas", Image = "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2021/11/19/975665/Kieu-Toc-Son-Tung-Mt.jpeg" }
                );
        }
        private void SeedBookAuthor(ModelBuilder builder)
        {

            builder.Entity<BookAuthor>().HasData(
                new BookAuthor { BookId = 1, AuthorId = 1 },
                new BookAuthor { BookId = 2, AuthorId = 2 },
                new BookAuthor { BookId = 3, AuthorId = 3 }

               );
        }

    }
}
