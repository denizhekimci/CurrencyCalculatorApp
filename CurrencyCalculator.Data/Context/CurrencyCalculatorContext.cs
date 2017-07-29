using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CurrencyCalculator.Domain.DomainModel;

namespace CurrencyCalculator.Data.Context
{
    public class CurrencyCalculatorContext : DbContext
    {
        public CurrencyCalculatorContext()
            : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<CurrencyConverter> Role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
