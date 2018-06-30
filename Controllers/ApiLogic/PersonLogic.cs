using AngularWebApp.Controllers.ApiRepository;
using System.Threading.Tasks;
using AngularWebApp.Models;


namespace AngularWebApp.Controllers.ApiLogic
{
    public class PersonLogic : IPersonLogic
    {
        private readonly IPersonRepo _repo;
        public PersonLogic(IPersonRepo repo)
        {
            _repo = repo;
        }
        public Person GetAll()
        {
            var person = _repo.GetAll();
            return person;
        }
    }
}