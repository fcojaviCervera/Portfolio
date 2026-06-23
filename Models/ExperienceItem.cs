namespace Portfolio.Models
{
    public record ExperienceItem
    (
        string Company,
        string Role,
        string Period,
        string? Location = null,
        string? Description = null
    );
}
