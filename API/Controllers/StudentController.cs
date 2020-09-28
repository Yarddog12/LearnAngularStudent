using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

// Since we are using angular, we will be using the C in MVC
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers {
[ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase {
        private readonly DataContext _ctx;
        public StudentController (DataContext ctx) {
            _ctx = ctx;

        }

        // Add 2 endpoints. IEnumerable is simple, use instead of list.
        [HttpGet]
        public async Task<ActionResult <IEnumerable<Student>>> GetStudents () {
            return await _ctx.Student.ToListAsync ();
        }

        // api/users/3
        [HttpGet("{id}")]
        public async Task<ActionResult <Student>> GetStudent (int id) {
            return await _ctx.Student.FindAsync (id);
        }
    }
}