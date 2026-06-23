using Portfolio.Models;

namespace Portfolio.Data
{
    public class CvData
    {
        public static readonly List<ExperienceItem> Experience = new()
        {
            new ("Microsoft", "Vice president", "2026- Actualidad"),
            new("ESP Solutions", ".NET Developer", "feb 2025 – Actualidad (1 año)", "Ceutí"),
            new("Orenes Grupo", "Software Engineer", "may 2024 – nov 2024", "Murcia"),
            new("MetaEnlace Sistemas de Información", "Software Engineer", "oct 2021 – may 2024", "Murcia"),
            new("VÓCALI", "Software Engineer", "dic 2020 – jun 2021", "Murcia"),
            new("everis", "Mid Developer", "feb 2020 – dic 2020", "Murcia"),
            new("everis", "Developer", "dic 2017 – feb 2020", "Murcia"),
            new("Freelance", "Videogame Programmer", "oct 2016 – oct 2017", "Barcelona","Programación de IA y gameplay con Unity 3D y C#."),
            new("NEORIS", "Analyst / Junior Programmer", "feb 2015 – oct 2016"),
        };
    }
}
