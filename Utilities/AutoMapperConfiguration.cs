namespace DemoAPI.Utilities;

public class AutoMapperConfiguration: Profile
{
    public AutoMapperConfiguration()
    {
         CreateMap<ActorCreationDTO, Actor>().ReverseMap();
         CreateMap<ActorReadDTO, Actor>().ReverseMap();
    }


}
