using Microsoft.AspNetCore.Mvc;
using tp_web_api.API;
using SerieInfo.API.Models;

namespace SerieInfo.API.Controllers
{
    [ApiController]
    [Route("api/series/{idSerie}/personajes")]
    public class PersonajesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PersonajeDTO>> GetPersonajes(int idSerie)
        {
            var serie = SeriesData.InstanciaActual.Series.FirstOrDefault(x => x.Id == idSerie);
            if (serie == null)
                return NotFound();

            return Ok(serie.Personajes);
        }

        [HttpGet("{idPersonaje}", Name = "GetPersonajes")]
        public ActionResult<PersonajeDTO> GetPersonajes(int idSerie, int idPersonaje)
        {
            var seriex = SeriesData.InstanciaActual.Series.FirstOrDefault(x => x.Id == idSerie);

            if (seriex == null)
                return NotFound();

            var character = seriex.Personajes.FirstOrDefault(x => x.Id == idPersonaje);

            if (character == null)
                return NotFound();

            return Ok(character);
        }

        [HttpPost]
        public ActionResult<PersonajeDTO> CrearPersonaje(int idSerie, PersonajeParaCreacionDTO personaje)
        {
            var serie = SeriesData.InstanciaActual.Series.FirstOrDefault(c => c.Id == idSerie);
            if (serie is null)
            {
                return NotFound();
            }

            var idMaximoPersonajes = SeriesData.InstanciaActual.Series.SelectMany(c => c.Personajes).Max(p => p.Id);

            var nuevoPersonaje = new PersonajeDTO
            {
                Id = ++idMaximoPersonajes,
                Nombre = personaje.Nombre,
               
            };

            serie.Personajes.Add(nuevoPersonaje);

            return CreatedAtRoute(
                "GetPersonaje", 
                new 
                {
                    idSerie,
                    idPersonaje = nuevoPersonaje.Id
                },
                nuevoPersonaje);
        }

        [HttpPut("{idPersonaje}")]
        public ActionResult ActualizarPersonaje(int idSerie, int idPersonaje, PersonajeParaUpdateDTO character)
        {
            var serie = SeriesData.InstanciaActual.Series.FirstOrDefault(c => c.Id == idSerie);

            if (serie == null)
                return NotFound();

            var personajeEnLaBase = serie.Personajes.FirstOrDefault(p => p.Id == idPersonaje);
            if (personajeEnLaBase == null)
                return NotFound();

            personajeEnLaBase.Nombre = character.Nombre;
           

            return NoContent();
        }


        [HttpDelete("{idPersonaje}")]
        public ActionResult DeleteCharacter(int idSerie, int idPersonaje)
        {
            var serie = SeriesData.InstanciaActual.Series.FirstOrDefault(c => c.Id == idSerie);
            if (serie is null)
                return NotFound();

            var personajeAEliminar = serie.Personajes.FirstOrDefault(p => p.Id == idPersonaje);
            if (personajeAEliminar is null)
                return NotFound();

            serie.Personajes.Remove(personajeAEliminar);

            return NoContent();
        }
    }
}