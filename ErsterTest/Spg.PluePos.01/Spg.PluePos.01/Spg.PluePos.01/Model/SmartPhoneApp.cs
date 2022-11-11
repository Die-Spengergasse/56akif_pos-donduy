using System.Collections.Generic;
using System.Linq;

namespace Spg.PluePos._01.Model {
    public class SmartPhoneApp : List<Post> {
        public string SmartPhoneId { get; set; } = string.Empty;
                
        public new void Add(Post post) {            
            if(post is not null) {
                base.Add(post);
            }
        } 
        public SmartPhoneApp(string smartPhoneId) {
            SmartPhoneId = smartPhoneId;
        }
        public string ProcessPosts() {
            string str = "";
            foreach(Post post in this) {
                str = (string) str.Concat(post.Html);
            }
            return str;
        }

        public int CalcRating() {
            int sum = 0;
            foreach(Post post in this) {
                sum += post.Rating; 
            }
            return sum;
        }
        private string[] arr = new string[100];
        public string this[int i] {
            get {
                return arr[i];
            }
            set {
                arr[i] = value;
            }
        }
    }
}