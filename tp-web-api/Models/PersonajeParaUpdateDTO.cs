
using System.ComponentModel.DataAnnotations;

namespace SerieInfo.API.Controllers
{
    public class PersonajeParaUpdateDTO
    {
        [Required(ErrorMessage = "Agregá un nombre")]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;
    }
}
