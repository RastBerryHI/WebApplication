using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone() { Name = "Xiaomi Mi 9T", Price = 10000, Producer = "Xiaomi" });

            context.Phones.Add(new Phone() { Name = "Google Pixel a4", Price = 150000, Producer = "Google" });

            context.Phones.Add(new Phone() { Name = "Samsung Galaxy S20", Price = 27000, Producer = "Samsung" });
            base.Seed(context);
        }
    }
}
