
namespace SerieInfo.API.Models
{
    public class SerieDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Rating { get; set; }

        public ICollection<PersonajeDTO> Personajes { get; set; } = new List<PersonajeDTO>();

        public int CantidadPersonajes
        {
            get { return Personajes.Count; }
        }


    }
}
