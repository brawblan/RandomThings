namespace RandomThings.Models;

public record Color
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class CreateColorRequest
{
    public required string Name { get; set; }
}