using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Iskitim2023
{
    class AppContext : DbContext
    {
        public DbSet<polution> polutions { get; set; }

        public AppContext() : base("DefaultConnection") { }
    }
}
