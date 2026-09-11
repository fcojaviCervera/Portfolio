namespace Portfolio.Models
{
    public record ProjectItem(
       string Titulo,
       string Descripcion,
       IReadOnlyList<string> Tecnologias,
       string UrlRepositorio,
       string? UrlDemo = null
   );
}
