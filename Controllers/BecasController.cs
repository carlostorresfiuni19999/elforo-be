using elforo_be.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace elforo_be.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class BecasController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public BecasController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            if(null == _db.Becas) 
                return BadRequest();

            return Ok(_db.Becas.ToList());
        }


    }
}