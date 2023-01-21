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
    public class ComentariosController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public ComentariosController
            (
            ApplicationDbContext db, 
            IMapper mapper, UserManager<User> 
            userManager
            )
        {
            _db = db;
            _mapper = mapper;
            _userManager = userManager;
        }

        [Authorize]
        [Route("{id}")]
        [HttpGet]
        public IActionResult GetComment(int id)
        {
            if( null == _db.Comentarios) return BadRequest();

            var result = _db.Comentarios
                .Include(c => c.Question)
                .Include(c => c.User)
                .Where(c => null == c.Question ? false : c.Question.Id == id);

            return Ok(_mapper.Map<List<CommentDTO>>(result));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PostComment(CommentDTO dto)
        {
            if(null == _db.Questions || null == _db.Comentarios) 
                return BadRequest();

            var comentario = _mapper.Map<Comentario>(dto);

            var user = await _userManager.Users
                .FirstOrDefaultAsync(u => u.Id.Equals(dto.IdPerson));

            var question = await  _db.Questions.
                FirstOrDefaultAsync(q => q.Id == dto.IdQuestion);

            comentario.User = user;
            comentario.Question = question;

            return Ok(await _db.Comentarios.AddAsync(comentario));
        }

    }
}