﻿// <auto-generated />
using System;
using EBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EBook.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220813115753_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EBook.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrtiption")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birth = new DateTime(1996, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descrtiption = "edasdádasdas",
                            FullName = "lai Quang Khai",
                            Image = "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2021/11/19/975665/Kieu-Toc-Son-Tung-Mt.jpeg",
                            Name = "Khai"
                        },
                        new
                        {
                            Id = 2,
                            Birth = new DateTime(1996, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descrtiption = "edasdádasdas",
                            FullName = "lai Quang Hopa",
                            Image = "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2021/11/19/975665/Kieu-Toc-Son-Tung-Mt.jpeg",
                            Name = "Hoa"
                        },
                        new
                        {
                            Id = 3,
                            Birth = new DateTime(1996, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descrtiption = "edasdádasdas",
                            FullName = "lai Quang Vinh",
                            Image = "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2021/11/19/975665/Kieu-Toc-Son-Tung-Mt.jpeg",
                            Name = "Vinh"
                        });
                });

            modelBuilder.Entity("EBook.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryID = 1,
                            Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg",
                            Name = "Iron Man",
                            Price = 22,
                            Quantity = 22
                        },
                        new
                        {
                            Id = 2,
                            CategoryID = 1,
                            Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg",
                            Name = "Iron Man",
                            Price = 22,
                            Quantity = 22
                        },
                        new
                        {
                            Id = 3,
                            CategoryID = 2,
                            Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg",
                            Name = "Iron Man",
                            Price = 22,
                            Quantity = 22
                        },
                        new
                        {
                            Id = 4,
                            CategoryID = 2,
                            Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg",
                            Name = "Iron Man",
                            Price = 22,
                            Quantity = 22
                        },
                        new
                        {
                            Id = 5,
                            CategoryID = 3,
                            Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg",
                            Name = "Iron Man",
                            Price = 22,
                            Quantity = 22
                        },
                        new
                        {
                            Id = 6,
                            CategoryID = 3,
                            Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg",
                            Name = "Iron Man",
                            Price = 22,
                            Quantity = 22
                        },
                        new
                        {
                            Id = 7,
                            CategoryID = 2,
                            Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg",
                            Name = "Iron Man",
                            Price = 22,
                            Quantity = 22
                        },
                        new
                        {
                            Id = 8,
                            CategoryID = 1,
                            Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg",
                            Name = "Iron Man",
                            Price = 22,
                            Quantity = 22
                        },
                        new
                        {
                            Id = 9,
                            CategoryID = 3,
                            Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg",
                            Name = "Iron Man",
                            Price = 22,
                            Quantity = 22
                        },
                        new
                        {
                            Id = 10,
                            CategoryID = 1,
                            Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg",
                            Name = "Iron Man",
                            Price = 22,
                            Quantity = 22
                        },
                        new
                        {
                            Id = 11,
                            CategoryID = 1,
                            Image = "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg",
                            Name = "Iron Man",
                            Price = 22,
                            Quantity = 22
                        });
                });

            modelBuilder.Entity("EBook.Models.BookAuthor", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookAuthor");

                    b.HasData(
                        new
                        {
                            BookId = 4,
                            AuthorId = 1
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 2
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 3
                        });
                });

            modelBuilder.Entity("EBook.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Marvel"
                        },
                        new
                        {
                            Id = 2,
                            Name = "DC"
                        },
                        new
                        {
                            Id = 3,
                            Name = "VietNam"
                        });
                });

            modelBuilder.Entity("EBook.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "A",
                            ConcurrencyStamp = "588d09c5-05f0-447b-b5e2-2ad33d4ba811",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "B",
                            ConcurrencyStamp = "f8a3d52a-2e06-4d5f-977d-97ecd61e7a9f",
                            Name = "StoreOwner",
                            NormalizedName = "StoreOwner"
                        },
                        new
                        {
                            Id = "C",
                            ConcurrencyStamp = "6eec4720-5c06-48a7-a151-9b89e341dff1",
                            Name = "Customer",
                            NormalizedName = "Customer"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "83144213-d574-4244-8961-cf3aa39c9aee",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "admin@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEEJjbAkaH3/JxEmkLTzfU5evwQC2coPxZZWw+PPhQnBFayWcpX3c4/NePJoxjyaZWw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9844e9c7-9e90-400a-beed-b2d49ebc5815",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "239dc8b2-861d-4911-a18e-0eafeef6639e",
                            Email = "storeowner@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "storeowner@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEC2pJ8KssK6OnQ8GcNfhF0mQu9sq+F76ueC0VIcStkyFio90q/Ir6n66EIxxyrF2Jw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "88b78663-4877-4cf0-8a36-b4b2841771d2",
                            TwoFactorEnabled = false,
                            UserName = "storeowner@gmail.com"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0000bfde-0724-403e-a289-efb67dc5a25d",
                            Email = "customer@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "customer@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEDYS5uY19s+Z/qmkLIrhBo+lmlN2iFR86e+nPnGBbbh6UaRojublJOEWfpSH++Du3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e01b03e9-e189-4ef7-ba33-9b5b0e8cc62a",
                            TwoFactorEnabled = false,
                            UserName = "customer@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "A"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "B"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "C"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EBook.Models.Book", b =>
                {
                    b.HasOne("EBook.Models.Category", "Category")
                        .WithMany("Book")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EBook.Models.BookAuthor", b =>
                {
                    b.HasOne("EBook.Models.Author", "Author")
                        .WithMany("BookAuthor")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EBook.Models.Book", "Book")
                        .WithMany("BookAuthor")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EBook.Models.Order", b =>
                {
                    b.HasOne("EBook.Models.Book", "Book")
                        .WithMany("Order")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
