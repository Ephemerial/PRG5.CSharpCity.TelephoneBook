using PRG5.CSharpCity.TelephoneBook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRG5.CSharpCity.TelephoneBook.MVC2.Models
{
    public class TelephoneBookViewModel
    {
        public List<Person> Everyone { get; set; }
        public Person Admin { get; }

        public TelephoneBookViewModel()
        {
            Admin = new Person("Eric", "Kuijpers")
            {
                TelephonNumber = "06-51312408"
            };
        }
    }
}
