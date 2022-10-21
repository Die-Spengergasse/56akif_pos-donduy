using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Vinothek.Domain.Model {
    public enum Kategorien {
        Weisswein = 0,
        Rotwein = 1,
        Suesswein = 2,
        Sonstiges = 3
    }
    public enum Laender {
        Austria = 0,
        Deutschland = 1,
        Italien = 2,
        Spanien = 3,
        Portugar = 4,
        Frankreich = 5,
        Chile = 6,
        Argentinien = 7,
        Suedafrika = 8,
        Sonstiges = 9
    }

    public enum Bewertungen {
        Ausgezeichnet = 0,
        Sehr_gut = 1,
        Gut = 2,
        Nicht_schlecht = 3,
        Schlecht = 4
    }
    public class Wein {
        public int WeinId { get; set; }
        public string Weinname { get; set; } = string.Empty;
        public Kategorien Kategorie { get; set; }
        public string Jahrgang { get; set; } = string.Empty;
        public Laender Land { get; set; }
        public string Beschreibung { get; set; } = string.Empty;        
        public double Preis { get; set; } = double.MinValue;
        public Bewertungen Bewertung { get; set; }
    }
}
