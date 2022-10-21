using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Vinothek.Domain.Model {
    public enum Zahlungsarten {
        Kauf_auf_Rechnung = 0,
        Kreditkarte = 1,
        Paypal = 2,
        Giropay = 3
    }

    public enum Versandarten {
        Selbstabholung = 0,
        Dpd = 1,
        Dhl = 2,
        Tnt = 3,
        Ups = 4,
        FedEx = 5,
        Hermes = 6,
        Gls = 7
    }

    public class Warenkorb {

        public int WarenkorbId { get; set; }

        public string? Kundennummer; //zu erkennen, wer was bestellt hat 
        public List<Warenkorbelement> Warenkorbelemente { get; set; } = new List<Warenkorbelement>();

        public DateTime Bestellsdatum { get; set; } = DateTime.MinValue;

        public Zahlungsarten Zahlung { get; set; }

        public Versandarten Versand { get; set; }

    }
}
