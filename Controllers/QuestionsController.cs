using AutoMapper;
using elforo_be.Models;
using elforo_be.Models.dto;
using elforo_be.Models.ent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace elforo_be.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private static readonly int nrp = 20;
        private readonly UserManager<User> _userManager;

        public QuestionsController( ApplicationDbContext db, IMapper mapper, UserManager<User> userManager)
        {
            _db = db;
            _mapper = mapper;
            _userManager = userManager;
        }


      
        [HttpGet]
        public IActionResult GetAll()
        {
            if(_db.Questions == null) return BadRequest("Error en la consulta");
            var questionList =  _db.Questions.ToList();
            return Ok( _mapper.Map<List<QuestionDTO>>(questionList));
        }

        [Route("id/{id}")]
        [HttpGet]
        public IActionResult GetQuestion(int id)
        {
            if(_db.Questions == null) return BadRequest("Error en la consulta");
            var result = _db.Questions.Include(q => q.Tags).FirstOrDefault( q => q.Id == id);

            return result != null  ?
                Ok(_mapper.Map<QuestionDTO>(result)) : NotFound();
        }



        [HttpPost]
        public async Task<IActionResult> PostQuestion(QuestionDTO dto)
        {
            Console.WriteLine($"Question : {dto.Ask}");
            
            if(_db.Questions == null) return BadRequest("Error en la consulta");

            var ent = _mapper.Map<Question>(dto);
            
            var person = await _userManager.Users.FirstOrDefaultAsync(u => u.Email.Equals(dto.Email));

            
         
            if(person == null)
            { 
                Console.WriteLine("No existe");
                return NotFound();
            }

            ent.Person = person;
            if(dto.Tags == null) return BadRequest();
           
           


            
           _db.Questions.Add(ent);

           List<Tag> tags = new List<Tag>();

            if( dto.Tags.Count > 0)
            {
                foreach(var item in dto.Tags)
                {
                    Console.WriteLine($"{item}");
                    var tagDb = _db.Tags.FirstOrDefault(d => d.TagName.Equals(item));
                    tagDb.Question = ent;
                    tags.Add(tagDb);
                }
            }

            _db.SaveChanges();

            return Ok();

        }

    }
}