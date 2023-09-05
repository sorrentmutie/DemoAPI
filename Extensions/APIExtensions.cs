namespace DemoAPI.Extensions;

public static class APIExtensions
{
    public static Actor ToActor(this ActorCreationDTO actorCreationDTO)
    {
        return new Actor { 
            Name = actorCreationDTO.Name, 
            DateOfBirth = actorCreationDTO.DateOfBirth, 
            Salary = actorCreationDTO.Salary };
    }
}
