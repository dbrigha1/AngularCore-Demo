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
        public Person GetAll()
        {
            var person = new Person
            {
                PersonId = 1,
                DisplayName = "Dylan A Brigham",
                FirstName = "Dylan",
                LastName = "Brigham"
            };
            return person;
        }
    }
}