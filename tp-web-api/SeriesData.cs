
using tp_web_api.Models;

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
                     Personajes = new List<PersonajesDTO>()
                     {
                         new PersonajesDTO() {
                             Id = 1,
                             Nombre = "Heisenberg" },
                          new PersonajesDTO() {
                             Id = 2,
                             Nombre = "Saul Goodman" },
                             
                     }
                },
                new SerieDTO()
                {
                    Id = 2,
                    Nombre = "The Walking Dead",
                    Rating = "8.2",
                    Personajes= new List<PersonajesDTO>()
                     {
                         new PersonajesDTO() {
                             Id = 3,
                             Nombre = "Rick"},

                          new PersonajesDTO() {
                             Id = 4,
                             Nombre = "Carl"},

                     }
                },
                new SerieDTO()
                {
                    Id= 3,
                    Nombre = "Prison Break",
                    Rating = "8.3",
                    Personajes = new List<PersonajesDTO>()
                     {
                         new PersonajesDTO() {
                             Id = 5,
                             Nombre = "Michael Scofield"},

                          new PersonajesDTO() {
                             Id = 6,
                             Nombre = "Lincoln Burrows"},

                     }
                }
            };
        }
    }
}