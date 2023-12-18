using Service.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Requests
{
    public class OrderFoodRequest
    {
        public string adress { get; set; }
        public string numbers { get; set; }
        public List<Product> products { get; set; }
    }
}
