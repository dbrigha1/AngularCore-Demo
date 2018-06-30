using System.Threading.Tasks;
using AngularWebApp.Models;

namespace AngularWebApp.Controllers.ApiLogic
{
    public interface IPersonLogic
    {
         Person GetAll();
    }
}