using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ExProperties {
    public class Lehrer {
        private decimal? _bruttogehalt;

        public string Zuname { get; set; } = string.Empty;

        public string Vorname { get; set; } = string.Empty;

        public decimal? Bruttogehalt {
            get {
                return _bruttogehalt;
                }                 
            
            set {
                if(_bruttogehalt == null) {
                    _bruttogehalt = value;
                }
                
            }
        }

        public string Kuerzel {            
            get {
                if (Zuname.Length >= 3) {                    
                    Zuname = Zuname.Substring(0,3);
                    if (Zuname.Length > 0) {
                        return Zuname.ToUpper();
                    }                    
                } 
                return "";
            }                
        }
        
        public decimal Nettogehalt {
            get {
                return 0.8M*(_bruttogehalt ?? 0);
            }
        }


    }
}
