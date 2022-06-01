using Microsoft.AspNetCore.Mvc;

namespace tp_web_api.Models
{
    public class PersonajesDTO : Controller
    {

        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        
    }
}
