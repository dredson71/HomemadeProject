using Microsoft.AspNetCore.Mvc;
using Uweek.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Uweek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
    private readonly ApplicationDbContext _context;

    public SongController(ApplicationDbContext context)
    {

        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Song>>> GetAction ()
    {
        return await _context.Songs.Include(x =>x.Gender).ToListAsync();
    }

    [HttpPost]
    public ActionResult<Song> PostSongAction(Song song)
    {
        _context.Songs.Add(song);
        _context.SaveChanges();
        return CreatedAtAction("GetSongItem",new Song{Id = song.Id},song);
    }

    [HttpPut("{id}")]
    public ActionResult GetSongItem(int id,Song song)
    {
       if(id != song.Id){
                return BadRequest();
            }
            _context.Entry(song).State =  EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
    }

    
    }
}