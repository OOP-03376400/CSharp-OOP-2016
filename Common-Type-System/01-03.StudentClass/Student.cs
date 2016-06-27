namespace _01_03.StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private int course;

        public Student(string firstName, string middleName, string lastName, string ssn,
            string permanentAddress, string mobilePhone, string email, int course,
            Specialty specialty, Faculty faculty, University university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        //properties
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name shouldn't be empty");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Middle name shouldn't be empty");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name shouldn't be empty");
                }
                this.lastName = value;
            }
        }

        public string SSN
        {
            get { return this.ssn; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("SSN should exist");
                }
                this.ssn = value;
            }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Address should exist");
                }
                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Phone is neccessary");
                }
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("E-mail is neccessary");
                }
                this.email = value;
            }
        }

        public int Course
        {
            get { return this.course; }
            set
            {
                if (value < 0 || value > 7)
                {
                    throw new ArgumentOutOfRangeException("Course should be between 1 and 6!");
                }
                this.course = value;
            }
        }

        public Specialty Specialty { get; set; }

        public Faculty Faculty { get; set; }

        public University University { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} - {3} - student in {4}. He is {5} course {6} im {7} faculty\nPersonal data: \naddress: {8}\nphone number: {9}\ne-mial: {10} ", this.firstName, this.middleName, this.lastName, this.ssn, this.University, this.course, this.Specialty, this.Faculty, this.permanentAddress, this.mobilePhone, this.email);
        }

        public override bool Equals(object student)
        {
            var secondStudent = student as Student;

            if (secondStudent.FirstName == this.FirstName && secondStudent.SSN == this.SSN && secondStudent.LastName == this.LastName)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.course;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !student1.Equals(student2);
        }

    }
}
