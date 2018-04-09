DROP DATABASE IF EXISTS logistica;
go

CREATE DATABASE logistica;
go

USE [logistica]
GO

if OBJECT_ID('carrello', 'U') is not null
	drop table carrello;
go

create table carrello(
	id int identity(1,1) not null primary key,
	codice_prodotto int not null,
	qta int not null
);

IF OBJECT_ID('prodotti', 'U') IS NOT NULL
	drop table prodotti;
go

create table prodotti(
	codice int identity(1,1) not null primary key,
	descrizione nvarchar(100) not null
)
go

IF OBJECT_ID('movimenti', 'U') IS NOT NULL
	drop table movimenti;
go

create table movimenti(
	id int identity(1,1) not null primary key,
	codice_prodotto int foreign key references prodotti,
	segno int not null, -- segno che puo essere 1 o -1 a seconda del tipo di movimento (ordine 1, processo -1)
	qta int not null, 
	id_ordine int, --rappresenta l'ordine che ha generato il movimento (un'ordine può generare più movimenti di prodotto)
	id_processo int --rappresenta il processo che ha generato il movimento
)
	

IF OBJECT_ID('statiOrdine', 'U') IS NOT NULL
	drop table statiOrdine;
go
create table statiOrdine(
	id int identity(1,1) not null primary key,
	stato varchar(50) -- richiesta, ricevuto, comleto, incompleto, pagato
)
go

IF OBJECT_ID('ordini', 'U') IS NOT NULL
	drop table ordini;
go
create table ordini(
	id int identity(1,1) not null primary key,
	data_ordine date not null,
	stato_ordine int foreign key references statiOrdine --inizialmente l'ordine è in stato richiesta.
)
go


IF OBJECT_ID('prodottiOrdinati', 'U') IS NOT NULL
	drop table prodottiOrdinati;
go
create table prodottiOrdinati( --prodotti ordinati per ogni richiesta
	id int identity(1,1) not null primary key,
	id_ordine int foreign key references ordini,
	codice_prodotto int foreign key references prodotti,
	qta int not null
)

