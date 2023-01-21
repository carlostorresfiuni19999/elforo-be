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

        public ComentariosController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
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

    }
}