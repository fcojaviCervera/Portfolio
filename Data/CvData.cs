using Portfolio.Models;

namespace Portfolio.Data
{
    public class CvData
    {
        public static readonly List<ExperienceItem> Experience = new()
        {
            new("ESP Solutions", ".NET Developer", "feb 2025 – Actualidad (1 año)", "Ceutí", Technologies: ["C#", ".NET", "SQL Server", "NodeJS","GIT", "AWS", "MongoDB", "Docker","RabbitMQ"] ),
            new("Orenes Grupo", "Software Engineer", "may 2024 – nov 2024", "Murcia", Technologies: ["C#", ".NET","SQL Server", "WPF","TypeScript", "HTML", "Redis","RabbitMQ", "MongoDB","Docker", "Jenkins","GIT"]),
            new("MetaEnlace Sistemas de Información", "Software Engineer", "oct 2021 – may 2024", "Murcia",Technologies: ["C#", ".NET","SQL Server","WPF", "TypeScript","HTML", "Redis","RabbitMQ", "MongoDB","Docker", "Jenkins","GIT"]),
            new("VÓCALI", "Software Engineer", "dic 2020 – jun 2021", "Murcia",Technologies:["C#",".NET","SQL Server","WPF","GIT"]),
            new("everis", "Mid Developer", "dic 2017 – dic 2020", "Murcia",Technologies:["ASP.NET", "Visual Basic", ".NET", "TFS","Azure","MySQL","Oracle"]),
            new("Freelance", "Videogame Programmer", "oct 2016 – oct 2017", "Barcelona","Programación de IA y gameplay con Unity 3D y C#.", Technologies: ["C#", "Unity", "GIT"]),
            new("NEORIS", "Junior Analyst / Programmer", "feb 2015 – oct 2016", "Murcia",Technologies:["C#","Javascript","PHP","HTML","CSS","Windows Mobile"]),
        };

        public static readonly List<TechCategory> Technologies = new()
        {
            new("Backend", [
                new("C#", "devicon-csharp-plain colored"),
                new(".NET", "devicon-dotnetcore-plain colored"),
                new("RabbitMQ", "devicon-rabbitmq-original colored"),

            ]),
            new("Frontend", [
                new("TypeScript", "devicon-typescript-plain colored"),
                new("JavaScript", "devicon-javascript-plain colored"),
                new("HTML5", "devicon-html5-plain colored"),
            ]),
            new("Bases de datos", [
                new("SQL Server", "devicon-microsoftsqlserver-plain colored"),
                new("MySQL", "devicon-mysql-plain colored"),
                new("Oracle SQL", "devicon-oracle-original colored"),
                new("MongoDB", "devicon-mongodb-plain colored"),
                new("Redis", "devicon-redis-plain colored"),

            ]),
            new("Cloud y DevOps", [
                new("AWS", "devicon-amazonwebservices-plain colored"),
                new("Azure", "devicon-azure-plain colored"),
                new("Docker", "devicon-docker-plain colored"),
                new("Jenkins", "devicon-jenkins-plain colored"),
                new("Git", "devicon-git-plain colored"),
            ]),
            new("Videojuegos", [
                new("Unity", "devicon-unity-plain"),
                new("C#", "devicon-csharp-plain colored"),
            ]),
        };

        public static readonly IReadOnlyList<ProjectItem> Proyectos = new List<ProjectItem>
        {
            new ProjectItem(
                Titulo: "TinyLibrary",
                Descripcion: "Backend de gestión de una biblioteca construido con Clean Architecture " +
                             "(WebApi → Infrastructure → Application → Domain). Implementa reglas de " +
                             "negocio como préstamos simultáneos máximos, penalizaciones por retraso en " +
                             "devoluciones y los patrones Repository + UnitOfWork para operaciones atómicas.",
                Tecnologias: new[] { ".NET 10", "ASP.NET Core", "EF Core", "SQLite", "NUnit", "FluentValidation" },
                UrlRepositorio: "https://github.com/fcojaviCervera/TinyLibrary"
            ),
        };
    }
}

