namespace DemoAPI.Interfaces;

public interface IActorData
{
    Task<int> CreateActor(ActorCreationDTO actorCreationDTO);
    Task<ActorReadDTO?> GetActor(int id);
}
