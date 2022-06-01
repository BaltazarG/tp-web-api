using Microsoft.AspNetCore.Mvc;
using tp_web_api.Models;

namespace tp_web_api.API.Controllers
{
    [ApiController]
    [Route("api/series/{idSerie}/personajes")]
    public class PersonajesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PersonajesDTO>> GetPersonajes(int idSeries)
        {
            var serie = SeriesData.InstanciaActual.Series.FirstOrDefault(x => x.Id == idSeries);
            if (serie == null)
                return NotFound();

            return Ok(serie.Personajes);
        }

        [HttpGet("{idPersonajes}", Name = "GetPersonajes")]
        public ActionResult<PersonajesDTO> GetPuntosDeInteres(int idSerie, int idPersonaje)
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
        public ActionResult<PersonajesDTO> CrearPuntoDeInteres(int idSerie, PersonajeParaCreacionDTO personaje)
        {
            var serie = SeriesData.InstanciaActual.Series.FirstOrDefault(c => c.Id == idSerie);
            if (serie is null)
            {
                return NotFound();
            }

            var idMaximoPuntosDeInteres = SeriesData.InstanciaActual.Series.SelectMany(c => c.Personajes).Max(p => p.Id);

            var nuevoPersonaje = new PersonajesDTO
            {
                Id = ++idMaximoPuntosDeInteres,
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
        public ActionResult DeletePointOfInterest(int idSerie, int idPersonaje)
        {
            var serie = SeriesData.InstanciaActual.Series.FirstOrDefault(c => c.Id == idSerie);
            if (serie is null)
                return NotFound();

            var personajeAEliminar = serie.Personajes
                .FirstOrDefault(p => p.Id == idPersonaje);
            if (personajeAEliminar is null)
                return NotFound();

            serie.Personajes.Remove(personajeAEliminar);

            return NoContent();
        }
    }
}