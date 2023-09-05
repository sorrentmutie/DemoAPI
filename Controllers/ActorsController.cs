using DemoAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class ActorsController : ControllerBase
{
    private readonly IActorData actorData;

    public ActorsController(IActorData actorData){
        this.actorData = actorData;
    }

    // GET: api/Genres/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ActorReadDTO>> GetActor(int id)
    {
        var actorDTO = await actorData.GetActor(id);
        if (actorDTO == null)
        {
            return NotFound();
        } else
        {
            return actorDTO;
        }
    }


    [HttpPost]
    public async Task<IActionResult> PostNewActor([FromBody] ActorCreationDTO actorCreationDTO)
    {
        var id = await actorData.CreateActor(actorCreationDTO);
        return CreatedAtAction("GetActor", new { id = id }, actorCreationDTO);
       // return NoContent();
    }

}
