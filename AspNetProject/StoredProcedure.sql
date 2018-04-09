create procedure AddProdCarr
	@CodiceProdott int,
	@QuantitaRichiesta int,
	@IdUtente int
as
	INSERT INTO carrello(codice_prodotto,qta,codice_utente) VALUES(@CodiceProdott,@QuantitaRichiesta,@idUtente);
go