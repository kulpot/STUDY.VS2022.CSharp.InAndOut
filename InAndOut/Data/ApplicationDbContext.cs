using InAndOut.Models;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //<PackageReference Include="Microsoft.EntityFrameworkCore" Version="7.0.5" />
            //< PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "7.0.5" />
            //< PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "7.0.5" > view/other windows/Package Manager Console
            //PM> add-migration addItemsToDatabase
            //PM> update-database
        }

        public DbSet<Item> Items{ get; set; }
        //public DbSet<Expense> Expenses { get; set; }
        //public DbSet<ExpenseType> ExpenseTypes { get; set; }
    }
}
