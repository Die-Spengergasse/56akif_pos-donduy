using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Vinothek.Domain.Model {
    public enum Geschlechter {
        Maennlich = 0,
        Weiblich = 1,
        Sonstiges = 2
    }
    public class Kunden {
        
        public Geschlechter Geschlecht { get; set; }
        public string Kundennummer { get; set; } = string.Empty;
        public string Vorname { get; set; } = string.Empty;
        public string Nachname { get; set; } = string.Empty;
        public DateTime Geburtsdatum { get; set; } = DateTime.MinValue;
        public string Adresse { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime RegistrationDatum { get; set; }
        public string Passwort { get; set; } = string.Empty;
        public List<Warenkorb> Warenkorbs { get; set; } = new List<Warenkorb>();

    }
}
