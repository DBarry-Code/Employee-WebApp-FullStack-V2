using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        /*
        private readonly DbContext _context;

        public EmployeesController(DbContext context)
        {
            _context = context;
        }
*/
        [HttpGet]
        public string SayHI()
        {
            return "HI";
        }
    }
}
