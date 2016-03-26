using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFMVC05.Models
{
    public class EFMVCContext : DbContext
    {
        //public EFMVCContext() : base("MyFinance") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}