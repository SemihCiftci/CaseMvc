using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }

        [StringLength(25)]
        public string Key { get; set; }

        [StringLength(50)]
        public string Value { get; set; }

        public virtual ProductProperty ProductProperty { get; set; }
    }
}
