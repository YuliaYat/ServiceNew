using Service.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Entity
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        public string adress { get; set; }
        public string numbers { get; set; }
        public List<Product> products { get; set; }
    }
}
