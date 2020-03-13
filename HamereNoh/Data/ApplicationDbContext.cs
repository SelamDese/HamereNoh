using System;
using System.Collections.Generic;
using System.Text;
using HamereNoh.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HamereNoh.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Batch> Batchs { get; set; }
        public DbSet<Cource> Cources { get; set; }
        public DbSet<Library> Librarys { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<Batch>().HasData(
                new Batch()
                {
                    BatchId = 1,
                    BatchName = "BeteKirkos"
                },
                new Batch()
                {
                    BatchId = 2,
                    BatchName = "BeteYohanis"
                },
                new Batch()
                {
                    BatchId = 2,
                    BatchName = "Kebero1"
                },
                new Batch()
                {
                    BatchId = 2,
                    BatchName = "Begena1"
                }
                );

            modelBuilder.Entity<Cource>().HasData(
                new Cource()
                {
                    CourceId = 1,
                    CourceName = "Fidel"
                },
                new Cource()
                {
                    CourceId = 2,
                    CourceName = "Begena"
                },
                new Cource()
                {
                    CourceId = 3,
                    CourceName = "WidaseMariyam"
                },
                new Cource()
                {
                    CourceId = 4,
                    CourceName = "Zema"
                },
                new Cource()
                {
                    CourceId = 4,
                    CourceName = "Kebero"
                }
                );
            modelBuilder.Entity<Library>().HasData(
                new Library()
                {
                    LibraryId = 1,
                    ItemName = "Hahu memariya",
                    ItemType = "Handout"
                },
               new Library()
               {
                   LibraryId = 2,
                   ItemName = "Ye begena Mastemariya",
                   ItemType = "Book"
               }
               );
            modelBuilder.Entity<Student>().HasData(
               new Student()
               {
                   StudentId = 
                   ItemName = "Hahu memariya",
                   ItemType = "Handout"
               },
              new Student()
              {
                  LibraryId = 2,
                  ItemName = "Ye begena Mastemariya",
                  ItemType = "Book"
              }
              );
            modelBuilder.Entity<Program>().HasData(
                new Program()
                {
                    ProgramId = 1,
                    ProgramName = "Fidel"
                },
               new Program()
               {
                   ProgramId = 1,
                   ProgramName = "Fidel"
               }
               );






            modelBuilder.Entity<Program>().HasData(
                new Program()
                {
                    ProgramId = 1,
                    ProgramName = "BeteKirkos"
                },



        }
    }
}
