namespace ZuvoPet.Models
{
    public class HistoriaExitoConDetalles
    {
        public HistoriaExito HistoriaExito { get; set; }
        public List<ComentarioHistoria> ComentariosHistoria { get; set; }
        public List<LikeHistoria> LikeHistorias { get; set; }
    }
}
