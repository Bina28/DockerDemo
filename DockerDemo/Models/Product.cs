namespace DockerDemo.Models;

public class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Name { get; set; }
}
