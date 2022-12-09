using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace ekzApi.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-DHHU93LT;Initial Catalog=cpz_ekz;Integrated Security=True; Trusted_Connection=True");
        }
        public DbSet<Expense> Expenses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>()
                .HasData(
                    new Expense
                    {
                        Id = 1,
                        Name = "Cinema ticket purchase",
                        Cost = 200,
                        Time = DateTime.Parse("5/10/2022"),
                        Category = Enums.Category.Entertainment
                    },
                    new Expense
                    {
                        Id = 2,
                        Name = "Taxi ride",
                        Cost = 150,
                        Time = DateTime.Parse("7/8/2022"),
                        Category = Enums.Category.Services
                    },
                    new Expense
                    {
                        Id = 3,
                        Name = "Rental",
                        Cost = 3000,
                        Time = DateTime.Parse("1/11/2022"),
                        Category = Enums.Category.Accomodations
                    },
                    new Expense
                    {
                        Id = 4,
                        Name = "Charity",
                        Cost = 50,
                        Time = DateTime.Parse("3/4/2022"),
                        Category = Enums.Category.Other
                    },
                    new Expense
                    {
                        Id = 5,
                        Name = "Tracksuit purchase",
                        Cost = 500,
                        Time = DateTime.Parse("5/26/2022"),
                        Category = Enums.Category.Goods
                    },
                    new Expense
                    {
                        Id = 6,
                        Name = "Table purchase",
                        Cost = 1500,
                        Time = DateTime.Parse("9/17/2022"),
                        Category = Enums.Category.Goods
                    },
                    new Expense
                    {
                        Id = 7,
                        Name = "Food",
                        Cost = 350,
                        Time = DateTime.Parse("12/8/2022"),
                        Category = Enums.Category.Accomodations
                    },
                    new Expense
                    {
                        Id = 8,
                        Name = "Gambling",
                        Cost = 2000,
                        Time = DateTime.Parse("12/3/2022"),
                        Category = Enums.Category.Other
                    },
                    new Expense
                    {
                        Id = 9,
                        Name = "Haircut",
                        Cost = 400,
                        Time = DateTime.Parse("8/14/2022"),
                        Category = Enums.Category.Services
                    },
                    new Expense
                    {
                        Id = 10,
                        Name = "Netflix subscription",
                        Cost = 100,
                        Time = DateTime.Parse("4/12/2022"),
                        Category = Enums.Category.Entertainment
                    }
                );
        }

    }
}
