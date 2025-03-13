namespace ZuvoPet.Models
{
    public class PerfilAdoptanteViewModel
    {
        public VistaPerfilAdoptante Perfil { get; set; }
        public List<MascotaCard> MascotasFavoritas { get; set; }
        public int PaginaActual { get; set; }
        public int TotalPaginas { get; set; }
    }
}
