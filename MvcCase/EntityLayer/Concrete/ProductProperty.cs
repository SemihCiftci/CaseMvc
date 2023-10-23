using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductProperty
    {
        [Key]
        public int ProductPropertyId { get; set; }
        public int ProductId { get; set; }
        public int PropertyId { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Property> Properties { get; set; }

    }
}
