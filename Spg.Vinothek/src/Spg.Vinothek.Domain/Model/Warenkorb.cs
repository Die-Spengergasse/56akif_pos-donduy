using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Vinothek.Domain.Model {
    public class Warenkorb {
        public List<Warenkorbelement> Warenkorbelemente { get; set; } = new List<Warenkorbelement>();
    }
}
