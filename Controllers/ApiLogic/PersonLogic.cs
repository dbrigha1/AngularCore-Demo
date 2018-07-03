using AngularWebApp.Controllers.ApiRepository;
using System.Threading.Tasks;
using AngularWebApp.Models;
using System.Collections.Generic;

namespace AngularWebApp.Controllers.ApiLogic
{
    public class PersonLogic : IPersonLogic
    {
        private readonly IPersonRepo _repo;
        public PersonLogic(IPersonRepo repo)
        {
            _repo = repo;
        }
        public List<Person> GetAll()
        {
            var person = _repo.GetAll();
            return person;
        }
        public void Post(Person personModel)
        {
            _repo.Post(personModel);
        }
        public void DeleteAll()
        {
            _repo.DeleteAll();
        }
    }
}