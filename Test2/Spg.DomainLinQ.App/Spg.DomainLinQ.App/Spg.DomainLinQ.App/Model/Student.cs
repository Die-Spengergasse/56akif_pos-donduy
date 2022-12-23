using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * RegistrationNumber
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * PhoneNumber
    /// * AccountName = [Die ersten 5 Stellen des LastName + RegistrationNumber]
    /// * Gender
    /// * Guid
    /// (4P)s
    /// </summary>
    public class Student : EntityBase
    {
        // TODO: Implementation
        public long RegistrationNumber { get; private set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public Address? Address { get; set; } = default!;
        public PhoneNumber? PhoneNumber { get; set; }
        public string? AccountName {
            get {
                return _accountName;
            }
            set {
                _accountName = LastName.Substring(0,5) + RegistrationNumber;
            }
        }
        private string? _accountName;

        public Gender Gender { get; set; }

        public Guid Guid { get; set; }
        public SchoolClass SchoolClass { get; set; }

        private List<Subject> _subjects = new();
        public virtual IReadOnlyList<Subject> Subjects => _subjects;

        public void AddSubjects(List<Subject> subjects)
        {
            _subjects.AddRange(subjects);
        }

        protected Student() {

        }
        public Student(
            long registrationNumber,
            Guid gui,
            string firstName, 
            string lastName,            
            string eMail,
            Gender gender,
            SchoolClass schoolClass,
            Address address,
            PhoneNumber phoneNumber) {
            RegistrationNumber = registrationNumber;
            Guid = gui;
            FirstName = firstName;
            LastName = lastName;            
            EMail = eMail;
            Gender = gender;
            SchoolClass = schoolClass;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
