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
    
    public partial class logisticaEntities : DbContext
    {
        public logisticaEntities()
            : base("name=logisticaEntities")
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
    }
}
