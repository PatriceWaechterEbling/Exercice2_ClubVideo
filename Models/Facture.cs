namespace Exercice2_ClubVideo.Models
{
    public class Facture
    {
        public int Id { get; set; }
        public DateTime Maintenant { get; set; }
        public Clients client { get; set; }
        public Films film { get; set; }
    }
}
