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
            // var person = new Person
            // {
            //     PersonId = 1,
            //     DisplayName = "Dylan A Brigham",
            //     FirstName = "Dylan",
            //     LastName = "Brigham"
            // };
            // return person;
            var person = _context.Persons.Where(e=>true).ToList();
            return person;
        }
        public void Post(Person personModel)
        {
            _context.Add(personModel);
            _context.SaveChanges();
        }
    }
}