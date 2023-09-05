namespace DemoAPI.Entities;

public class Actor: BaseEntity
{
    public string? Name { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Picture { get; set; }
    public double Salary { get; set; }
    public HashSet<MovieActor> MoviesActors { get; set; } = new HashSet<MovieActor>();

}
