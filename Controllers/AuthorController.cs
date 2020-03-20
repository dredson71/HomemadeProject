using Microsoft.AspNetCore.Mvc;
using Uweek.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Uweek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AuthorController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAction()
        {
            return await _context.Authors.Include(a => a.Songs).ThenInclude(g => g.Gender).ToListAsync();
        }

      /*  [HttpPost]
        public ActionResult<Gender> PostGender(Author gender)
        {
            _context.Genders.Add(gender);
            _context.SaveChanges();
            return CreatedAtAction("GetGenderItem",new Author{Id = gender.Id},gender);
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
        }*/

    }
}