namespace AspNetProject.Models {
    public class Prodotto {
        public int codice {get; set;}
        public string Descrizione {get; set;}
        public int Giacenza {get; set;}

        public Prodotto(){}
        public Prodotto(int codice,string descrizione) {
            this.codice = codice;
            Descrizione = descrizione;
        }
    }
}