using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EBook.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    Birth = table.Column<DateTime>(nullable: false),
                    FullName = table.Column<string>(maxLength: 30, nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Descrtiption = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestCT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsApproved = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestCT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    UserEmail = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "A", "f5f95176-26b0-473c-900c-8e17cf6aef72", "Admin", "Admin" },
                    { "B", "b598bd21-fb17-4b4e-9574-efe1ef2292ef", "StoreOwner", "StoreOwner" },
                    { "C", "d7d20a9e-7d4e-443c-bd56-255c12c059c3", "Customer", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "838cea16-5a0c-42f7-8f7b-7af858ead9e7", "admin@gmail.com", false, false, null, null, "admin@gmail.com", "AQAAAAEAACcQAAAAENzU+KSpzc1Hu8fbIdJkxou0ucySda5xawfW8TsQevV2iFQyu6AkOVwXhyx34hezmA==", null, false, "3231947f-61ab-47cf-8b11-5357393e5f90", false, "admin@gmail.com" },
                    { "2", 0, "c4d3391e-16dd-42fc-8c11-eb2f052926dd", "storeowner@gmail.com", false, false, null, null, "storeowner@gmail.com", "AQAAAAEAACcQAAAAEFaZrH2Gz12gbMUETEpMMeBomq+ytcmRGQVfCSRq2s10nI3bwtPYlJWrQpPw2atQTw==", null, false, "b4707edd-684e-46de-ae73-e5a6cb62e46b", false, "storeowner@gmail.com" },
                    { "3", 0, "e1a154c7-174c-4c28-b05e-7f76a8c34d61", "customer@gmail.com", false, false, null, null, "customer@gmail.com", "AQAAAAEAACcQAAAAEJthhy8eVG/ZU0aL5HxgQGxlEQreDZvFtYiQMc/I+MEfSyoy3vSeykZH6dYnT8P54g==", null, false, "7769137a-3023-472f-880c-f214fb042b59", false, "customer@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Birth", "Descrtiption", "FullName", "Image", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1996, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "edasdádasdas", "lai Quang Khai", "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2021/11/19/975665/Kieu-Toc-Son-Tung-Mt.jpeg", "Khai" },
                    { 2, new DateTime(1996, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "edasdádasdas", "lai Quang Hopa", "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2021/11/19/975665/Kieu-Toc-Son-Tung-Mt.jpeg", "Hoa" },
                    { 3, new DateTime(1996, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "edasdádasdas", "lai Quang Vinh", "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2021/11/19/975665/Kieu-Toc-Son-Tung-Mt.jpeg", "Vinh" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Marvel" },
                    { 2, "DC" },
                    { 3, "VietNam" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "1", "A" },
                    { "2", "B" },
                    { "3", "C" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CategoryID", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", "Iron Man", 22, 22 },
                    { 2, 1, 1, "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", "Iron Man", 22, 22 },
                    { 8, 3, 1, "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", "Iron Man", 22, 22 },
                    { 10, 1, 1, "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", "Iron Man", 22, 22 },
                    { 11, 1, 1, "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", "Iron Man", 22, 22 },
                    { 3, 2, 2, "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", "Iron Man", 22, 22 },
                    { 4, 1, 2, "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", "Iron Man", 22, 22 },
                    { 7, 1, 2, "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", "Iron Man", 22, 22 },
                    { 5, 3, 3, "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", "Iron Man", 22, 22 },
                    { 6, 2, 3, "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", "Iron Man", 22, 22 },
                    { 9, 2, 3, "https://booksupnorth.com/wp-content/uploads/2020/10/The-Iron-Man-PB-Cover-High-res-scaled.jpg", "Iron Man", 22, 22 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryID",
                table: "Book",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_BookId",
                table: "Order",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "RequestCT");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
