using System.ComponentModel.DataAnnotations;

namespace DemoAPI.DTO;

public class ActorCreationDTO
{
    [StringLength(120)]
    [Required]
    public string? Name { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public double Salary { get; set; }
}

public class ActorReadDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
}
