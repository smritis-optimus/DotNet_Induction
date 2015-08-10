using System.Collections.Generic;
using BL = Person.BusinessLayer;
namespace Person.DataLayer
{
    /// <summary>
    /// a database with all person records
    /// </summary>
    public class PersonDatabase
    {
        public static List<BL.Person> GetAllPeople()
        {
            var people = new List<BL.Person>
                {
                    new BL.Person {Id = 1, Age = 28, Name = "Pankaj"},
                    new BL.Person {Id = 2, Age = 32, Name = "Meher"},
                    new BL.Person {Id = 3, Age = 26, Name = "Abhay"},
                    new BL.Person {Id = 4, Age = 54, Name = "John"},
                    new BL.Person {Id = 5, Age = 52, Name = "Smith"},
                };

            return people;
        }
    }
}
