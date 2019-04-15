--CREATE DATABASE TransformerBank;


USE TransformerBank;


CREATE TABLE Clients(
ClientID int IDENTITY (1,1) PRIMARY KEY NOT NULL,
Name nvarchar (20) NOT NULL,
Surname nvarchar (20) NOT NULL,
Title nvarchar (15) NULL,
BirthNumber varchar(10) NOT NULL,
IdCardNumber nvarchar (8) NOT NULL,
Street nvarchar (30) NOT NULL,
City nvarchar (30) NOT NULL,
PhoneNumber nvarchar (15) NOT NULL
);



CREATE TABLE BankAccounts(
AccountID int IDENTITY (1,1) PRIMARY KEY NOT NULL,
ClientID int FOREIGN KEY REFERENCES Clients (ClientId),
AccountName nvarchar (40) NOT NULL, 
IBAN char (24) NOT NULL,
OpeningDate DATETIME NOT NULL,
ClosingDate DATETIME NULL,
AccountBalance decimal (10, 2) NOT NULL DEFAULT 0,
AuthOverdraftLimit decimal (6 , 2) NOT NULL DEFAULT 0,
);


CREATE TABLE Cards (
CardID int IDENTITY (1,1) PRIMARY KEY NOT NULL,
CardNumber char(16) NOT NULL,
CardName int NOT NULL,
ExpDate DateTime NOT NULL,
IsBlocked Bit NOT NULL DEFAULT 0,
PIN char(4) NOT NULL,
AccountID int FOREIGN KEY REFERENCES BankAccounts (AccountID)
);


CREATE TABLE Transactions (
TransactionID int IDENTITY (1,1) PRIMARY KEY NOT NULL,
SenderIBAN char (24) NOT NULL,
RecipientIBAN char (24) NOT NULL,
Time Datetime NOT NULL,
VS char(10) NULL,
SS char(10) NULL,
KS char(4) NULL,
TransMessage nvarchar (20) NULL
);
