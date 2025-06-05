using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deckidrehi.Drehi
{
    public class ProductCon : DbContext
    {
        public ProductCon():base("Drehicontext")
        {

        }
        public DbSet<Products> Product { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
