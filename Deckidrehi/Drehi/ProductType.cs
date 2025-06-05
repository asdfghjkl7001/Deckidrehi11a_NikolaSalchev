using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deckidrehi.Drehi
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //M:1
        public int ProductId { get; set; }//FK
        public Products Product { get; set; }
    }
}
