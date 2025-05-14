using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_App.Model
{
    public class Product
    {
        public string DefaultImage { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<string>? Images { get; set; }
    }
}
