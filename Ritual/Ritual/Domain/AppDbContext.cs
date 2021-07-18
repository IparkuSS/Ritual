using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ritual.Domain.Entities;

namespace Ritual.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<TextFileds> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<Wreath> Wreath{ get; set; }
    
        public DbSet<Cross> Croses{ get; set; }
        public DbSet<Different> Differents{ get; set; }
        public DbSet<Monument> Monuments{ get; set; }
        public DbSet<InitMon> InitMons { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Messege> Messege { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

          
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

            modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });
            modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                CodeWord = "PageServices",
                Title = "Наши услуги"
            });

            modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("0040a82c-4a6a-4d5d-b27a-8ae188dc218c"),
                CodeWord = "PageWhreat",
                Title = "Венки"
            });

            modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
            modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("cf1cf1cb-2073-4cbd-ad1c-f15f395c864f"),
                CodeWord = "PageGrave",
                Title = "Копка Могилы"
            });
            modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("7723de5d-fbae-4356-824e-2587e4d19f86"),
                CodeWord = "PageIntilMonum",
                Title = "Установка Памятника"
            });
            modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("19f514da-f1c0-4956-928e-0ad725453e73"),
                CodeWord = "PageCar",
                Title = "Катафалк"
            });

            modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("4e41659e-3398-4bf8-a81b-0e9368ea13d3"),
                CodeWord = "PageExample",
                Title = "Примеры"
            });

            modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("9c39fb0c-428a-440e-98f4-fd619d68e105"),
                CodeWord = "PageCross",
                Title = "Кресты"
            });
         modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("5f5a7abe-129a-4036-ab1b-f5c38b494b31"),
                CodeWord = "PageDifferent",
                Title = "Разное"
            });
            modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("bf1fc5dc-537f-4bff-99f5-3d83b83fc962"),
                CodeWord = "PageMonument",
                Title = "Памятники"
            });

            modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("67ed3169-2ab2-4c8c-8c99-16aa993faee7"),
                CodeWord = "PageAboutUs",
                Title = "О нас"
            });
            modelBuilder.Entity<TextFileds>().HasData(new TextFileds
            {
                Id = new Guid("1ec7f029-65c4-4fa7-978d-af4a9ed5bb40"),
                CodeWord = "PageRitualTable",
                Title = "Ритуальный стол"
            });

        }
    }
}
