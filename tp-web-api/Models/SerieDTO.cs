using Microsoft.AspNetCore.Mvc;

namespace tp_web_api.Models
{
    public class SerieDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Rating { get; set; }

        public ICollection<PersonajesDTO> Personajes { get; set; } = new List<PersonajesDTO>();

        public int CantidadPersonajes
        {
            get { return Personajes.Count; }
        }


    }
}
