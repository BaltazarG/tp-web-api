using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace tp_web_api.Models
{
    public class PersonajeParaUpdateDTO
    {
        [Required(ErrorMessage = "Agregá un nombre")]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;
        
    }
}
