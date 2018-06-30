using System.Threading.Tasks;
using AngularWebApp.Models;

namespace AngularWebApp.Controllers.ApiRepository
{
    public interface IPersonRepo
    {
         Person GetAll();
    }
}