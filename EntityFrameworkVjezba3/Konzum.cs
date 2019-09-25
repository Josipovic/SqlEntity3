using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkVjezba3
{
   public class Konzum
    {
        public int Id { get; set; }
        public  string Naziv { get; set; }
        public string Mjesto { get; set; }

        public  virtual Adresa Adresa { get; set; }
    }
}
