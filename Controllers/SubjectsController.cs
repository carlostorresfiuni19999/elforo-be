using elforo_be.Models;
using elforo_be.Models.ent;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using elforo_be.Models.dto;
using Microsoft.EntityFrameworkCore;

namespace elforo_be.Controllers
{
    [Route("api/[controller]")]
    public class SubjectsController : ControllerBase 
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        public SubjectsController
        (
            ApplicationDbContext db,
            UserManager<User> userManager,
            IMapper mapper
        )
        {
            _db = db;
            _userManager = userManager;
            _mapper =  mapper;
        }

        [Authorize]
        [HttpGet("email/{email}")]
        public IActionResult GetSubjectAsync(String email)
        {

            if(_db.Subjects == null) return BadRequest();
            
            var subjects = _db.Subjects.Include(s => s.User);

            
            foreach(var item in subjects){
                Console.WriteLine($"Name {item.Name} student = {item.UserId} ");
            }
            return Ok(_mapper.Map<List<SubjectDTO>>(subjects
            .Where(s => null == s.User ? false : s.User.Email.Equals(email))));
        }

        [HttpGet("{Id}")]
        public IActionResult PostRevision(int Id)
        {
            return Ok();
        }

    
     


    }
}