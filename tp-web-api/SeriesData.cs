
using SerieInfo.API.Models;

namespace tp_web_api.API
{
    public class SeriesData
    {
        public List<SerieDTO> Series { get; set; }

        public static SeriesData InstanciaActual { get; } = new SeriesData();

        public SeriesData()
        {
            Series = new List<SerieDTO>()
            {
                new SerieDTO()
                {
                     Id = 1,
                     Nombre = "Breaking Bad",
                     Rating = "9.5",
                     Personajes = new List<PersonajeDTO>()
                     {
                         new PersonajeDTO() {
                             Id = 1,
                             Nombre = "Heisenberg" },
                          new PersonajeDTO() {
                             Id = 2,
                             Nombre = "Saul Goodman" },
                             
                     }
                },
                new SerieDTO()
                {
                    Id = 2,
                    Nombre = "The Walking Dead",
                    Rating = "8.2",
                    Personajes= new List<PersonajeDTO>()
                     {
                         new PersonajeDTO() {
                             Id = 3,
                             Nombre = "Daryl Dixon"},

                          new PersonajeDTO() {
                             Id = 4,
                             Nombre = "Negan"},

                     }
                },
                new SerieDTO()
                {
                    Id= 3,
                    Nombre = "Prison Break",
                    Rating = "8.3",
                    Personajes = new List<PersonajeDTO>()
                     {
                         new PersonajeDTO() {
                             Id = 5,
                             Nombre = "Michael Scofield"},

                          new PersonajeDTO() {
                             Id = 6,
                             Nombre = "Lincoln Burrows"},

                     }
                },
                new SerieDTO()
                {
                    Id= 3,
                    Nombre = "Game of Thrones",
                    Rating = "9.2",
                    Personajes = new List<PersonajeDTO>()
                     {
                         new PersonajeDTO() {
                             Id = 7,
                             Nombre = "Tyrion Lannister"},

                          new PersonajeDTO() {
                             Id = 8,
                             Nombre = "Jon Snow"},

                     }
                },
                new SerieDTO()
                {
                    Id= 3,
                    Nombre = "Better Call Saul",
                    Rating = "8.8",
                    Personajes = new List<PersonajeDTO>()
                     {
                         new PersonajeDTO() {
                             Id = 9,
                             Nombre = "Mike Ehrmantraut"},

                          new PersonajeDTO() {
                             Id = 10,
                             Nombre = "Gus Fring"},

                     }
                }
            };
        }
    }
}