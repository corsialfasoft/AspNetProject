using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetProject.Models {
    public class DomainModel {
        public interface IGestioneProdotti {
            Prodotto CercabyCode(int CodiceProdotto); //EDO
            List<Prodotto> CercabyDescrizione(string DescrizioneProdotto); //LUCA
            Prodotto AggiungiProdottoCarrello(int CodiceProdotto, int QuantitaRichiesta, int IdUtente); //ALESSIO
            void SvuotaCarello(int IdUtente); //MATTEO
            void ConfermaOrdine(int IdUtente);
        }
        public class DomainLogistica : IGestioneProdotti {
            public Prodotto AggiungiProdottoCarrello(int CodiceProdotto, int QuantitaRichiesta, int IdUtente) {
                throw new NotImplementedException();
            }

            public Prodotto CercabyCode(int CodiceProdotto) {
                throw new NotImplementedException();
            }

            public List<Prodotto> CercabyDescrizione(string DescrizioneProdotto) {
                throw new NotImplementedException();
            }

            public void ConfermaOrdine(int IdUtente) {
                throw new NotImplementedException();
            }

            public void SvuotaCarello(int IdUtente) {
                throw new NotImplementedException();
            }
        }
    }
}