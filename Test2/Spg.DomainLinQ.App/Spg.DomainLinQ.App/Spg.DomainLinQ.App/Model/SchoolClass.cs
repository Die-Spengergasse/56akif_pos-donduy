using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Name
    /// * Department [Die ersten 3 Zeichen von Name]
    /// * Guid
    /// (4P)
    /// </summary>
    public class SchoolClass : EntityBase
    {
        // TODO: Implementation
        public string Name { get; set; } = string.Empty;
        public string? Department {
            get {
                return _department;
            }
            set {
                _department = Name.Substring(0, 3);
            }
        }
        private string? _department;
        public Guid Gui { get; set; }
        public Teacher Kv { get; set; } 
        public List<Student> Students { get; set; } = new();

        protected SchoolClass() {

        }
        public SchoolClass(string name, Teacher kv, Guid gui) { 
            Name = name;
            Kv = kv;
            Gui = gui;
        }

    }
}
