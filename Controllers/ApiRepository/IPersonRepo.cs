using System.Collections.Generic;
using System.Threading.Tasks;
using AngularWebApp.Models;

namespace AngularWebApp.Controllers.ApiRepository
{
    public interface IPersonRepo
    {
         List<Person> GetAll();
         void Post(Person personModel);
         void DeleteAll();
    }
}