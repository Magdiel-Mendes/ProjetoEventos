namespace ProEventos.API.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtePessoas { get; set; }
        public string Lole { get; set; }
        public string ImagemURL { get; set; }
    }
}