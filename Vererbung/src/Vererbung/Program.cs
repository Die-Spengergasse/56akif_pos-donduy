using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung {
    class Program {
        // Ausgabe:
        // Ist s1AlsPerson volljährig?          False.
        // Accountname von s1 ist               eif0001.
        // Accountname von l1 ist               fleißig.
        // Accountname von l1AlsPerson ist      fleißig.
        // ToString() von l1 ist                base.ToString() von Person 1 ist VererbungDemo.Lehrer.
        // HiddenMethod von s1AlsPerson ist     HiddenMethod in Person.

        static void Main(string[] args) {
            Klasse k1 = new Klasse("3AHIF") { Kv = new Lehrer(1, "GC") { Zuname = "Gründl" } };
            Schueler s1 = new Schueler(1) { Zuname = "ZN1" };
            Schueler s2 = new Schueler(2) { Zuname = "ZN2" };
            Schueler s3 = new Schueler(1) { Zuname = "ZN3" };

            try {
                k1.Add(s1);
                k1.Add(s2);
                k1.Add(s3);
            }
            catch (InvalidOperationException e) {
                Console.Error.WriteLine(e.Message);
            }
            Console.WriteLine(k1);
            k1.Remove(s1);
            Console.WriteLine(k1);

        }
    }
}
