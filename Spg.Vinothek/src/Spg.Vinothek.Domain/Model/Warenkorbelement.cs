using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Vinothek.Domain.Model {
    public class Warenkorbelement {
        public int WarenkorbelementId { get; set; }

        public string? Kundennummer; //zu erkennen, wer was bestellt hat      
        public Wein Wein { get; set; } = new Wein();    
        
        public int Anzahl { get; set; }

        
    }
}
