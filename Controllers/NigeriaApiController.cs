using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nigeria.Models;
using nigeria.Data;


namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NigeriaApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NigeriaApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/States
        [HttpGet]
        [ProducesResponseType(200)]
         public ActionResult<IEnumerable<State>> GetStates()
        {
           
            return Ok(_context.States); 
        }

        // GET: api/States/5
        [HttpGet("{id:int}",Name ="GetState")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
         public ActionResult<State> GetState(int id)
        {
            var state = _context.States.FirstOrDefault(u => u.Id==id);
            if(id == 0){
                return BadRequest();
            }
            if(state == null){
                return NotFound();
            }
            return Ok(state);
        }


        // POST: api/States
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public ActionResult<State> PostState(State state)
        {
            _context.States.Add(state);
            _context.SaveChanges();

            return CreatedAtAction("GetState", new { id = state.Id }, state);
        }

        // PUT: api/States/5
        [HttpPut("{id:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult UpdateState(int id, State state)
        {
             var existingState = _context.States.FirstOrDefault(u => u.Id == id); // Use a different name for the fetched state

            if (existingState == null || state.Id != id)
            {
                return BadRequest();
            }

            // Update the existing state's properties
            existingState.Name = state.Name;
            existingState.Capital = state.Capital;
            existingState.Population = state.Population;
            existingState.Area = state.Area;
            existingState.Region = state.Region;
            existingState.Governor = state.Governor;

            // Save changes
            _context.States.Update(existingState);
            _context.SaveChanges(); // Synchronous save

            return NoContent();
        }

         // DELETE: api/States/5
        [HttpDelete("{id:int}", Name ="DeleteState")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult DeleteState(int id)
        {
             var state = _context.States.FirstOrDefault(u => u.Id==id);
            if(id == 0){
                return BadRequest();
            }
            
             if(state == null){
                return NotFound();
             }

            _context.States.Remove(state);
            _context.SaveChanges();
            return NoContent();
        }

        private bool StateExists(int id)
        {
            return _context.States.Any(e => e.Id == id);
        }
    }
}
