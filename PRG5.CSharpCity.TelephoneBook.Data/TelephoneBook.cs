using System.Collections.Generic;
using System.Linq;

namespace PRG5.CSharpCity.TelephoneBook.Data
{
    public class TelephoneBook
    {
        private List<Person> persons = new List<Person>();
        public TelephoneBook()
        {
            persons.Add(new Person("Joop", "van Lunteren") { TelephonNumber = "06 34567234" });
            persons.Add(new Person("Roel", "Robben") { TelephonNumber = "06 33443366" });
            persons.Add(new Person("Chris", "Spaans") { TelephonNumber = "06 22222222" });
            persons.Add(new Person("Jan", "van der Spoel") { TelephonNumber = "06 33333333" });
            persons.Add(new Person("Joop", "van Zanten") { TelephonNumber = "+31 6 345435" });
        }

        public List<Person> GetContactInfo(int lastnamelongerthan)
        {
            return persons
                    .Where(p => p.LastName.Length > lastnamelongerthan)
                            .OrderBy(p => p.LastName).ToList();
        }

        public List<Person> GetContactInfo(bool sortonlastnamelength = false)
        {
            if (sortonlastnamelength)
            {
                return persons.OrderBy(p => p.LastName.Length).ToList();
            }
            return persons.OrderBy(p => p.LastName).ToList();
        }

        public List<Person> GetContactInfo(string firstnamebeginletter)
        {
            return persons.Where(p => p.FirstName.StartsWith(firstnamebeginletter))
                            .OrderBy(p => p.LastName).ToList();
        }
    }
}
