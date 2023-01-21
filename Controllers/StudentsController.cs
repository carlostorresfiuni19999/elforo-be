using elforo_be.Models;
using Microsoft.AspNetCore.Mvc;

namespace elforo_be.Controllers
{
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public StudentsController
        (
            ApplicationDbContext db
        )
        {
            _db = db;
        }

        
    }
}