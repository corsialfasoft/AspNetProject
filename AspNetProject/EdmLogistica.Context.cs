﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class logisticaEntities1 : DbContext
    {
        public logisticaEntities1()
            : base("name=logisticaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<carrello> carrello { get; set; }
        public virtual DbSet<movimenti> movimenti { get; set; }
        public virtual DbSet<ordini> ordini { get; set; }
        public virtual DbSet<prodotti> prodotti { get; set; }
        public virtual DbSet<prodottiOrdinati> prodottiOrdinati { get; set; }
        public virtual DbSet<statiOrdine> statiOrdine { get; set; }
    
        public virtual int Svuotacarrello(Nullable<int> idUtente)
        {
            var idUtenteParameter = idUtente.HasValue ?
                new ObjectParameter("IdUtente", idUtente) :
                new ObjectParameter("IdUtente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Svuotacarrello", idUtenteParameter);
        }
    }
}