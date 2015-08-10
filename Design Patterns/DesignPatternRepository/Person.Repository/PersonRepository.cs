using System;
using System.Collections.Generic;
using System.Linq;
using BL = Person.BusinessLayer;
using DL = Person.DataLayer;
namespace Person.Repository
{
    /// <summary>
    /// interface IPersonRepository
    /// </summary>
    internal interface IPersonRepository
    {
        void Add(BL.Person person);
        void Remove(BL.Person person);
        IEnumerable<BL.Person> Find(Func<BL.Person, bool> predicate);
    }
    /// <summary>
    /// repository class of person implements IPersonRepository 
    /// provides abstraction between business and data layer
    /// </summary>
    public class PersonRepository : IPersonRepository
    {
        private readonly List<BL.Person> _people;

        public PersonRepository()
        {
            _people = DL.PersonDatabase.GetAllPeople();
        }

        public void Add(BL.Person person)
        {
            _people.Add(person);
        }

        public void Remove(BL.Person person)
        {
            _people.Remove(person);
        }
        public IEnumerable<BL.Person> Find(Func<BL.Person, bool> predicate)
        {
            return _people.Where(predicate);
        }
    }
}
