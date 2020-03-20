using Microsoft.AspNetCore.Mvc;
using Uweek.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Uweek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GenderController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Gender>> GetAction()
        {
            return _context.Genders;
        }

        [HttpPost]
        public ActionResult<Gender> PostGender(Gender gender)
        {
            _context.Genders.Add(gender);
            _context.SaveChanges();
            return CreatedAtAction("GetGenderItem",new Gender{Id = gender.Id},gender);
        }

        [HttpPut("{id}")]
        public ActionResult GetGenderItem(int id,Gender gender)
        {
            if(id != gender.Id){
                return BadRequest();
            }
            _context.Entry(gender).State =  EntityState.Modified;
            _context.SaveChanges();
            return NoContent(); 
        }

    }
}