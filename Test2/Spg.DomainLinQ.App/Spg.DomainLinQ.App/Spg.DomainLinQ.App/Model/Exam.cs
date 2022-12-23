using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Date (?)
    /// * Lesson (int?)
    /// * Created
    /// * Guid
    /// * Grade (Note 1-5)
    /// (4P)
    /// </summary>
    public class Exam : EntityBase
    {
        // TODO: Implementation
        public DateTime? Date { get; set; }
        public int? Lesson { get; set; }
        public DateTime Created { get; set; }
        public Guid Guid { get; set; }
        public int Grade { get; set; }

        public Subject Subject { get; set; }

        public int SubjectNavigationId { get; set; }

        public virtual Subject SubjectNavigation { get; set; } = default!;
        protected Exam() {

        }
        public Exam(
            Guid guid,
            DateTime? date,
            int? lesson,
            int grade,            
            Subject subject,
            DateTime created


            ) {
            Guid = guid;
            Date = date;
            Lesson = lesson;
            Grade = grade;            
            Subject = subject;
            Created = created;


        }
    }
}
