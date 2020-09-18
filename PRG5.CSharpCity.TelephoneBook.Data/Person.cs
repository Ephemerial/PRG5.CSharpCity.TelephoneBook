using System;

namespace PRG5.CSharpCity.TelephoneBook.Data
{
    public class Person
    {
        // private variables and fields
        private int id;
        private bool handig;

        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephonNumber { get; set; }
        public string Fullname { get => $"{FirstName} {LastName}"; }

        // Constructors and Destructors
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person()
        {
            
        }

        public void SetHandig(bool value)
        {
            handig = value;
        }

        public bool GetHandig()
        {
            return handig;
        }

        // All code and methods
        public int Id {
            get
            {
                return id;
            }
            set 
            {
                // Id moet groter dan -1 zijn;
                id = value > -1 
                    ? value 
                    : throw new ArgumentOutOfRangeException("Id", "Id moet groter of gelijk aan 0 zijn.");
                // var bla = conditie ? (wat doe ik als uitkomst true is ) : (wat doe ik als uitkomst false is)
            } 
        }
    }
}
