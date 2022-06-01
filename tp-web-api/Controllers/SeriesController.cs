using Microsoft.AspNetCore.Mvc;
using tp_web_api.Models;

namespace tp_web_api.API.Controllers
{
    [ApiController]
    [Route("api/series")]
    public class SeriesController : ControllerBase 
    {

        [HttpGet] 
        public ActionResult<IEnumerable<SerieDTO>> GetSeries()
        {
            return Ok(SeriesData.InstanciaActual.Series);
        }

        [HttpGet("{id}")]
        public ActionResult<SerieDTO> GetSerie(int id)
        {
            var serieARetornar = SeriesData.InstanciaActual.Series.FirstOrDefault(x => x.Id == id);
            if (serieARetornar == null)
                return NotFound();
            return Ok(serieARetornar);
        }

    }
}
