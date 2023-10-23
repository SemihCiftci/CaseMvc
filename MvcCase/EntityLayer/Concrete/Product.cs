using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int PropertyId { get; set; }
        public decimal Price { get; set; }
        [StringLength(1000)]
        public string ImagePath { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatorUserId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ProductProperty ProductProperty { get; set; }
    }
}
