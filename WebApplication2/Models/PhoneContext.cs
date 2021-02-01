using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    // База данных представленная в виде сущности для доступа к ней
    public class PhoneContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

    }
}
