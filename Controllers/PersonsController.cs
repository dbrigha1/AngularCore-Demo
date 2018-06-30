// using System;
// using System.Collections.Generic;
// using System.Linq;
using System.Threading.Tasks;
using AngularWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using AngularWebApp.Controllers.ApiLogic;

namespace AngularWebApp.Controllers
{
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
    private readonly IPersonLogic _logic;

        public PersonsController(IPersonLogic logic)
        {
            _logic = logic;
        }

        [HttpGet("[action]")]
        public Person PersonGet()
        {
            var person = _logic.GetAll();
            return person;
        }
    }
}