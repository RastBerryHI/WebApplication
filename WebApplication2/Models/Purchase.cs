using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public int PhoneId { get; set; }

        public DateTime DateTime { get; set; }

        public string Email { get; set; }
            
        public string FIO { get; set; }

        public string Adress { get; set; }
    }
}
