using DataAccessLayer.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace DataAccessLayer.Data
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // NOTE: adding connection string as a constant!
            optionsBuilder.UseSqlServer(@"Server=.\;Database=HomeLoan;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            optionsBuilder.LogTo(Console.WriteLine);
        }
        public  new DbSet<User> Users { get; set; }
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<LoanRequirements> LoanRequirements { get; set; }
        public DbSet<PersonalIncome> PersonalIncomes { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                Email = "Advisor@homeloan.com",
                UserName="Advisor",
                NormalizedUserName="ADVISOR",
                PasswordHash = hasher.HashPassword(null,"Advisor@123")

            }); ;;

            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "a06d9c1c-154a-441e-a4f4-e49f03e4d2a8",
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            });
        }

    }
}

