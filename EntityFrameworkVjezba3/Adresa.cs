using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkVjezba3
{
   public class Adresa
    {
       [ForeignKey("Konzum")]

        public string Ulica { get; set; }
        public int KucniBroj { get; set; }
        public int PostanskiBroj { get; set; }
        public string Mjesto { get; set; }


        public virtual Konzum Konzum  { get; set; }
    }
}
