namespace Portfolio.Models
{
    public record TechItem(string Name, string Icon);
    public record TechCategory(string Title, TechItem[] Items);
}
