using System;
using System.Linq;

namespace PRG5.CSharpCity.TelephoneBook.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Data.TelephoneBook();
            ShowAllNames(phonebook);

            System.Console.WriteLine("Welke letter?");
            var bla = System.Console.ReadLine();
            AlleVoornamenBeginMet(bla);
            //TestVanIdValidatie();
        }

        private static void TestVanIdValidatie()
        {
            var people = new Data.TelephoneBook().GetContactInfo(true);
            try
            {
                people.First().Id = -2;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                System.Console.WriteLine($"Er ging iets fout met {ex.ParamName} : {ex.Message} ");
            }
           
        }

        private static void AlleVoornamenBeginMet(string filter)
        {
            var people = new Data.TelephoneBook().GetContactInfo(true);
            people
                .Where(p => p.FirstName.StartsWith(filter))
                .OrderBy(p => p.LastName).Select(p => p.Fullname)
                .ToList()
                .ForEach(System.Console.WriteLine);
        }

        private static void ShowAllNames(Data.TelephoneBook phonebook)
        {
            var people = phonebook.GetContactInfo(true);
            people.ForEach(p => System.Console.WriteLine(p.FirstName + ' ' + p.LastName + ' ' + p.TelephonNumber));
            people.OrderBy(p => p.LastName).Select(p => p.Fullname).ToList().ForEach(System.Console.WriteLine);

        }
    }
}
