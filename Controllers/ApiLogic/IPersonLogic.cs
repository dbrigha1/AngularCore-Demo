using System.Collections.Generic;
using System.Threading.Tasks;
using AngularWebApp.Models;

namespace AngularWebApp.Controllers.ApiLogic
{
    public interface IPersonLogic
    {
         List<Person> GetAll();
         void Post(Person personModel);
    }
}