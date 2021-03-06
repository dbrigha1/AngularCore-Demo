using System.Collections.Generic;
using System.Linq;
using AngularWebApp.Models;
// using Microsoft.EntityFrameworkCore;

namespace AngularWebApp.Controllers.ApiRepository
{
    public class PersonRepo : IPersonRepo
    {
    private readonly WebAppContext _context;

    public PersonRepo(WebAppContext context)
    {
        _context = context;
    }
        public List<Person> GetAll()
        {
            var person = _context.Persons.Where(e=>true).ToList();
            return person;
        }
        public void Post(Person personModel)
        {
            _context.Add(personModel);
            _context.SaveChanges();
        }
        public void DeleteAll()
        {
            var persons = _context.Persons.Where(p=>true).ToList();

            foreach(var person in persons)
            {
                var entity = _context.Persons.Find(person.PersonId);
                _context.Remove(entity);
            }
            
            _context.SaveChanges();
        }
    }
}