namespace ZuvoPet.Models
{
    public class PerfilRefugioViewModel
    {
        public VistaPerfilRefugio Perfil { get; set; }
        public List<MascotaCard> MascotasFavoritas { get; set; }
        public int PaginaActual { get; set; }
        public int TotalPaginas { get; set; }
    }
}
