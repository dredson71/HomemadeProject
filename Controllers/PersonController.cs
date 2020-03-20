using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Uweek.Models;
using Microsoft.EntityFrameworkCore;


namespace Uweek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }       
       
        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetAction()
        {
                return _context.Persons;
        }

         [HttpPost]
        public ActionResult<Person> PostPersonItem(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
            return CreatedAtAction("GetPersonItem",new Person{Id = person.Id},person);
        }

        [HttpPut("{id}")]
        public ActionResult  GetPersonItem(int id,Person person)
        {
            if(id != person.Id){
                return BadRequest();
            }
            _context.Entry(person).State =  EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

    }
}