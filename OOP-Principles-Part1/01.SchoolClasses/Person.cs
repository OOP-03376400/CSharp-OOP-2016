namespace _01.SchoolClasses
{
    using System;

    public class Person : ICommentable
    {
        private string fisrtName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


        public string FirstName
        {
            get { return this.fisrtName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty");
                }
                this.fisrtName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty");
                }
                this.lastName = value;
            }
        }

        public string Comment { get; set; }
    }
}
