using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Vinothek.Domain.Model {
    public class Vinothek {
        public List<Wein> Weine { get; set; } = new List<Wein>();
        public List<Kunden> Kunden { get; set; } = new List<Kunden>();
        public List<Warenkorb> Vino_Warenkorbs { get; set; } = new List<Warenkorb>();
        
    }
}
