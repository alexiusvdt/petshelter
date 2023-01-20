using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;
using Newtonsoft.Json;
using PetShelterApi.Models;

namespace PetShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly PetShelterApiContext _db;
    
    public AnimalsController(PetShelterApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Location>>> Get([FromQuery] Parameters parameters)
    {
      IQueryable<Location> query = _db.Locations.AsQueryable();
      var locations = PagedList<Location>.ToPagedList(query.OrderBy(e=>e.Name), parameters.PageNumber, parameters.PageSize);
      var metadata = new
    {
        locations.TotalCount,
        locations.PageSize,
        locations.CurrentPage,
        locations.TotalPages,
        locations.HasNext,
        locations.HasPrevious
    };
    Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
      return new ActionResult<IEnumerable<Location>>(locations);
    }


    // GET api/Animals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return animal;
    }

    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetAnimal), new {id = animal.AnimalId }, animal);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Animals.Update(animal) ;
      
      //async saving
      try 
      {
      await _db.SaveChangesAsync();
      }
      
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

    return NoContent();

    }

    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}