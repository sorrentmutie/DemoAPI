namespace DemoAPI.Entities
{
    public class Genre: BaseEntity
    {
        public string? Name { get; set; }
        public HashSet<Movie> Movies { get; set; } = new HashSet<Movie>();
    }
}
