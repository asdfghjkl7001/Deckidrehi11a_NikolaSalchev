using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deckidrehi.Drehi
{
        public class Products
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double Cena { get; set; }
            public int Razmer { get; set; }
            public string Vid {  get; set; }
            public string tip { get; set; }
            //1:M
            public ICollection<ProductType> ProductTypes { get; set; }
    
        }
}
