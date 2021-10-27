using System;
using EFTutorial.Models;

namespace EFTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new OwnerContext()) {
                var person = new Person() {
                    Name = "Bill",
                    Age = 20
                };

                db.Persons.Add(person);
                db.SaveChanges();
            }
        }
    }
}
