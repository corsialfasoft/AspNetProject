namespace AspNetProject.Models {
    public class Prodotto {
        public string Descrizione {get; set;}
        public int Giacenza {get; set;}
        
        public Prodotto (string descrizione, int giacenza) {
            this.Descrizione=descrizione;
            this.Giacenza=giacenza;
        }
    }
}