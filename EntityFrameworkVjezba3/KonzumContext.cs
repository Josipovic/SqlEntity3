using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkVjezba3
{
    class KonzumContext:DbContext
    {
        public  DbSet<Konzum>Konzumi { get; set; }
        public  DbSet<Adresa> Adrese{ get; set; }
    }
}
