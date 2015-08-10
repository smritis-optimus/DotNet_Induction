using System;
using System.Linq;
using BL = Person.BusinessLayer;
using PR = Person.Repository;
namespace Person.PresentationLayer
{
     /// <summary>
    /// Implementation of repository pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var priyanka = new BL.Person { Age = 26, Id = 9, Name = "Priyanka" };
            var tim = new BL.Person { Age = 40, Id = 10, Name = "Vipul" };

            var personRepository = new PR.PersonRepository();

            //Add
            personRepository.Add(priyanka);
            personRepository.Add(tim);

            //Update
            BL.Person Smith = personRepository.Find(p => p.Id == 5).Single();
            Smith.Age = 66;

            //Remove
            personRepository.Remove(tim);

            foreach (BL.Person person in personRepository.Find(p => p.Id > 0))
            {
                Console.WriteLine("Name:{0} ,Age:{1}", person.Name, person.Age);
            }
            Console.Read();
        }
    }
 
}
