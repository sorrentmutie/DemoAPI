namespace DemoAPI.Controllers;

public class MyControllerBase : ControllerBase
{
    protected readonly ApplicationDbContext applicationDbContext;
    protected readonly IMapper mapper;

    public MyControllerBase(ApplicationDbContext applicationDbContext, IMapper mapper)
    {
        this.applicationDbContext = applicationDbContext;
        this.mapper = mapper;
    }
}
