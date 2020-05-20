using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShovelSurgeryBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShovelSurgeryBlog.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "67657946-18f9-430d-9db4-391828dcba95",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "0c11bc74-2761-4eb9-908c-b1bd6bb7650d",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@email.com",
                NormalizedEmail = "ADMIN@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "3fbacc96-3a3e-4e7a-8b40-5de5aefaf705",
                UserId = "0c11bc74-2761-4eb9-908c-b1bd6bb7650d"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("70838025-6aaa-448e-8f45-e050540fd5be"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("45ea19e4-22ec-4f15-a240-2c5153fac925"),
                CodeWord = "PagePublications",
                Title = "Публикации"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("f4885d4d-3777-4bb3-bcda-624d765f36aa"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }
    }
}
