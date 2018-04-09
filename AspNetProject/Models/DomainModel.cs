using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetProject.Models {
    public class DomainModel {
        public interface IGestioneProdotti {
            Prodotto CercabyCode(int CodiceProdotto); //EDO
            List<Prodotto> CercabyDescrizione(string DescrizioneProdotto); //LUCA
            void AggiungiProdottoCarrello(int CodiceProdotto, int QuantitaRichiesta, int IdUtente); //ALESSIO
            void SvuotaCarello(int IdUtente); //MATTEO
            void ConfermaOrdine(int IdUtente);
        }
        public class DomainLogistica : IGestioneProdotti {
            public void AggiungiProdottoCarrello(int CodiceProdotto, int QuantitaRichiesta, int IdUtente) {
                using(var db = new logisticaEntities1()){
                     db.AddProdCarr(CodiceProdotto,QuantitaRichiesta, IdUtente);
                }
            }

            public Prodotto CercabyCode(int CodiceProdotto) {
                Prodotto result = null;
                using(var db = new logisticaEntities1()){
                     var query = 
                        from product in db.prodotti
                        where product.codice == CodiceProdotto
                        select product;
                     List<prodotti> listaProdotti = query.ToList<prodotti>();
                     if(listaProdotti.Count>0){
                        result = new Prodotto();
                        result.codice= listaProdotti[0].codice;
                        result.Descrizione= listaProdotti[0].descrizione;
                     }
                }
                return result;
            }

            public List<Prodotto> CercabyDescrizione(string DescrizioneProdotto) {
                List<Prodotto> result = null;
                using (var db = new logisticaEntities1()){
                    var query = from product in db.prodotti where product.descrizione == DescrizioneProdotto select product;
                    List<prodotti> listaprodotti = query.ToList<prodotti>();
                    if(listaprodotti.Count>0){
                        foreach(prodotti product in listaprodotti) {
                            result.Add(new Prodotto(product.codice, product.descrizione)); //nel caso si aggiunge anche Giacenza
                        }
                    }
                    return result;
                }
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