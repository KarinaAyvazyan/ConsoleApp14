using FamilyCreated.Data.Entities;
using FamilyCreated.Enums;
using FamilyCreated.Services;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FamilyService family= new FamilyService();
            //family.Add(new Family
            //{
            //    Members = new List<Person>
            //    {
            //        new Person { FirstName = "Poxos", LastName = "Poxosyan", Age = 41, Gender = "Male", Role = PersonType.Parent },
            //        new Person { FirstName = "Anna", LastName = "Matevosyan", Age = 35, Gender = "Female", Role = PersonType.Parent },
            //        new Person { FirstName = "Petros", LastName = "Petrosyan", Age = 18, Gender = "Male", Role = PersonType.Child },
            //        new Person { FirstName = "Haykanush", LastName = "Matevosyan", Age = 80, Gender = "Female", Role = PersonType.Grandmother }
            //    },

            //    Animals = new List<Animal> {
            //        new Animal { Name = "boboDog" }
            //    },

            //    Address = "Bakery Street"
            //});

            //family.Delete(6);

        }
    }
}