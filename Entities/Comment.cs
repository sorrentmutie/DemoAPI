namespace DemoAPI.Entities;

public class Comment: BaseEntity
{
    public string? Text { get; set; }
    public bool? Reccomend { get; set; }
    public int MovieId { get; set; }
    public Movie? Movie { get; set; }
}
