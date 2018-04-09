create procedure Svuotacarrello
@IdUtente int
as
	delete from carrello where @IdUtente = codice_utente; 
go