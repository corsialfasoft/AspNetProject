using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetProject.Models {
    public class DomainModel {
        public interface IGestioneProdotti {
            Prodotto CercabyCode(int CodiceProdotto);
            List<Prodotto> CercabyDescrizione(string DescrizioneProdotto);
            Prodotto AggiungiProdottoCarrello(int CodiceProdotto, int QuantitaRichiesta, int IdUtente);
            void SvuotaCarello(int IdUtente);
            void ConfermaOrdine(int IdUtente);
        }
    }
}