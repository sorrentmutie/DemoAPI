using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Services;

public class SQLServerActorService : IActorData
{
    private readonly ApplicationDbContext applicationDbContext;
    private readonly IMapper mapper;

    public SQLServerActorService(ApplicationDbContext applicationDbContext, IMapper mapper)
    {
        this.applicationDbContext = applicationDbContext;
        this.mapper = mapper;
    }
    public async Task<int> CreateActor(ActorCreationDTO actorCreationDTO)
    {
        var actor = mapper.Map<Actor>(actorCreationDTO);
        applicationDbContext.Actors.Add(actor);
        await applicationDbContext.SaveChangesAsync();
        return actor.Id;
    }

    public async Task<ActorReadDTO?> GetActor(int id)
    {
        var actor = await applicationDbContext.Actors.FindAsync(id);
        return mapper.Map<ActorReadDTO>(actor);
    }
}
