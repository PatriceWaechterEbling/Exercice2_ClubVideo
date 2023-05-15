using Exercice2_ClubVideo.Models;
using System.Collections.Generic;

namespace Exercice2_ClubVideo.Services
{
    public class Facturation
    {
        List<Facture> ListeFactures = new List<Facture>();
        public void CreerFacture(Clients clients,Films films)
        {
            Facture f = new();
            f.Id++;
            f.client = clients;
            f.film = films;
            f.Maintenant = DateTime.Today;
            ListeFactures.Add(f);

        }

    }
}
