using AutoMapper;
using elforo_be.Models;
using elforo_be.Models.dto;
using elforo_be.Models.ent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace elforo_be.Controllers
{
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

        public IActionResult GetAll(int page)
        {
            if(_db.Questions == null) return BadRequest("Error en la consulta");
            var questionList =  _db.Questions.Skip((page - 1)*nrp).Take(nrp);
            return Ok( _mapper.Map<List<QuestionDTO>>(questionList));
        }

        public IActionResult GetQuestion(int id)
        {
            if(_db.Questions == null) return BadRequest("Error en la consulta");
            var result = _db.Questions.FirstOrDefault( q => q.Id == id);

            return result != null  ?
                Ok(_mapper.Map<QuestionDTO>(result)) : NotFound();
        }




        [Authorize]
        public async Task<IActionResult> PostQuestion(QuestionDTO dto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Consulta no valida");
            }

            if(_db.Questions == null) return BadRequest("Error en la consulta");

            var ent = _mapper.Map<Question>(dto);
            
            var person = await _userManager.FindByEmailAsync(dto.Email);

            if(person == null) return NotFound();

            ent.Person = person;

            _db.Questions.Add(ent);

            _db.SaveChanges();

            return Ok();

        }

    }
}