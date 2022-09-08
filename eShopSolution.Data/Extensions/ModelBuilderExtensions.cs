using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extentions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false }
                );

            #region Seed Category

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "iPhone"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Samsung"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Oppo"
                },

                new Category()
                {
                    Id = 4,
                    Name = "Vivo"
                },

                new Category()
                {
                    Id = 5,
                    Name = "Xiaomi"
                },

                new Category()
                {
                    Id = 6,
                    Name = "Nokia"
                }
              );

            #endregion Seed Category

            #region Seed Product

            modelBuilder.Entity<Product>().HasData(
                 new Product()
                 {
                     Id = 1,
                     Name = "iPhone 12 Pro",
                     CategoryId = 1,
                     Price = 28890000,
                     Stock = 5,
                     DateCreated = DateTime.Now,
                     Description = "",
                     Details = ""
                 },

                new Product()
                {
                    Id = 2,
                    Name = "Samsung Galaxy S21+",
                    CategoryId = 2,
                    Price = 20990000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                },

                new Product()
                {
                    Id = 3,
                    Name = "Oppo Reno 5",
                    CategoryId = 3,
                    Price = 8290000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                },

                new Product()
                {
                    Id = 4,
                    Name = "Vivo V21 5G",
                    CategoryId = 4,
                    Price = 9990000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                },

                new Product()
                {
                    Id = 5,
                    Name = "Xiaomi Redmi Note 10",
                    CategoryId = 5,
                    Price = 5090000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                },

                new Product()
                {
                    Id = 6,
                    Name = "Nokia 5.4",
                    CategoryId = 6,
                    Price = 3290000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                }
             );

            #endregion Seed Product

            // tạo data cho user mặc định
            // any guid
            var roleAdminId = new Guid("7566587D-0E8F-4A36-BC05-69F33FF55C23");
            var roleUserId = new Guid("BF9B2CAB-D403-4B08-8D6A-868C59D8A3E5");
            var adminId = new Guid("FB819BC6-2B1C-40C9-AC25-896DF1ECEFDF");

            modelBuilder.Entity<AppRole>().HasData(
            new AppRole
            {
                Id = roleAdminId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            },
            new AppRole
            {
                Id = roleUserId,
                Name = "user",
                NormalizedName = "user",
                Description = "User role"
            }
            );
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "tvthang2912@gmail.com",
                PhoneNumber = "0913264597",
                Address = "20 TNP, Phước Long B, TP. Thủ Đức, TP. Hồ Chí Minh",
                NormalizedEmail = "TVTHANG2912@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Thang12345"),
                SecurityStamp = string.Empty,
                Name = "Tran Thang",
            });
            // gán role admin và admin user
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleAdminId,
                UserId = adminId
            });
        }
    }
}