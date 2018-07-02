// using System;
// using System.Collections.Generic;
// using System.Linq;
using AngularWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using AngularWebApp.Controllers.ApiLogic;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

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
        public List<Person> Person()
        {
            var person = _logic.GetAll();
            return person;
        }

        [HttpPost("[action]")]
        public ActionResult Person([FromBody] Person personModel)
        {
            try
            {
                if (personModel == null)
                {
                    return BadRequest();
                }
                _logic.Post(personModel);

                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }

        }
    }
}