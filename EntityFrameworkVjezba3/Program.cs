using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkVjezba3
{
    class Program
    {
        static void Main(string[] args)
        {
            KonzumContext db = new KonzumContext();
            Konzum k = new Konzum();
            k.Naziv = "konzum";
            Adresa a = new Adresa();
            a.PostanskiBroj = 2;
            a.KucniBroj = 3;
            a.Mjesto = "mjesto";
            a.Ulica = "ulica";

            k.Adresa = a;
            db.Konzumi.Add(k);
            db.SaveChanges();
            foreach (var t in db.Konzumi) {
                Console.WriteLine(t.Naziv + " " +t.Adresa.KucniBroj);
            }

            Console.Read();
        }
    }
}
