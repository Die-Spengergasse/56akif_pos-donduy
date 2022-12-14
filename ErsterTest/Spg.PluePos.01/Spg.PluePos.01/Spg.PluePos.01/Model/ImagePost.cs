using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model {
    public class ImagePost : Post {
        public string? Url { get; set; }
        public override string Html {
            get {
                if (Url is null) {
                    throw new ArgumentNullException("Url war null");
                }
                return $"<h1>{Title}</h1><img src={Url}/>";
            }
        }
        public ImagePost(string titel, DateTime created) : base(titel, created) {

        }
        public ImagePost(string titel) : base(titel) {

        }
    }
}
