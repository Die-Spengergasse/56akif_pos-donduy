using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung {
    public class Klasse {
        public List<Schueler> ListSchuelers { get; set; } = new();
        public string Id { get; } = string.Empty;
        public Lehrer? Kv { get; set; }

        public Klasse(String id) {
            Id = id;
        }

        public void Add(Schueler s) {
            if(s is Schueler) {
                if ((s is null)) {
                    throw new ArgumentNullException("Schüler war NULL!");
                }

                if (ListSchuelers.Contains(s)) {
                    throw new InvalidOperationException($"Schüler mit der Nr {s.Nr} ist bereits vorhanden!");
                }

                if(!isIdVorhanden(s)) {
                    ListSchuelers.Add(s);
                }                

            } else {
                throw new InvalidOperationException("Da ist kein Schüler");
            }
            
        }

        public void Remove(Schueler s) {
            if (s is Schueler) {
                if ((s is null)) {
                    throw new ArgumentNullException("Schüler war NULL!");
                }

                if (ListSchuelers.Contains(s)) {                    
                    ListSchuelers.Remove(s);
                } else {
                    throw new InvalidOperationException("Schüler ist nicht vorhanden.");
                }                
            }
            else {
                throw new InvalidOperationException("Da ist kein Schüler");
            }
        }

        public override string ToString() {
            //return "Hello World!";
            return $"Klasse {Id}, KV: {Kv?.Zuname}, Schüleranzahl: {ListSchuelers.Count}";           

        }

        public bool isIdVorhanden(Schueler s) {
            foreach(Schueler s_iterm in ListSchuelers) {
                if(s_iterm.Nr == s.Nr) {
                    s_iterm.Zuname = s.Zuname;
                    return true;
                    //break;
                }
            }
            return false;
        }
    }
}
