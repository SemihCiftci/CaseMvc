using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int RecId { get; set; }

        [StringLength(25)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }
        public string HashPassword { get; set; }
        public string SaltPassword { get; set; }

    }
}
