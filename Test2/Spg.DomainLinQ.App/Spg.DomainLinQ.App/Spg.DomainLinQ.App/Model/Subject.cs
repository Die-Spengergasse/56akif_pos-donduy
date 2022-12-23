using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Description
    /// (4P)
    /// </summary>
    public class Subject : EntityBase
    {
        // TODO: Implementation
        public string Description { get; set; } = string.Empty;
       // public Student Student { get; set; }
        //public Teacher Teacher { get; set; }
        public int TeacherNavigationId { get; set; }
        public virtual Teacher TeacherNavigation { get; set; } = default!;
        public int StudentNavigationId { get; set; }
        public virtual Student StudentNavigation { get; set; } = default!;
        public int ExamNavigationId { get; set; }
        public virtual Exam ExamNavigation { get; set; } = default!;
        public Exam Exam { get; set; }

        protected Subject() {
        }
        public Subject(string description) {
            Description = description;
        }
    }
}
