CREATE DATABASE [HOUSE_MANAGEMENT]

USE [HOUSE_MANAGEMENT]

CREATE TABLE [TypeOfPayment]
(
	[IdTypeOfPayment]		INT PRIMARY KEY IDENTITY (1,1)  																															NOT NULL,
	[Title]					NVARCHAR(20)																																				NOT NULL
)
GO

CREATE TABLE [House]
(
	[IdHouse]				INT PRIMARY KEY IDENTITY (1,1)																																NOT NULL,
	[Number]				INT																																							NOT NULL
)
GO

CREATE TABLE [Apartment]
(
	[IdApartment]			INT PRIMARY KEY IDENTITY (1,1)																																NOT NULL,
	[HouseId]				INT	CONSTRAINT FK_House_IdHouse_Apartment_IdApartment FOREIGN KEY REFERENCES [House] ([IdHouse])															NOT NULL,
	[QuantityLodgers]		INT																																							NOT NULL,
	[Square]				INT																																							NOT NULL,
	[PaymentId]				INT CONSTRAINT FK_Payment_IdPaiment_Apartment_IdApartment FOREIGN KEY REFERENCES [Payment] ([IdPayment])													NOT NULL
)
GO

CREATE TABLE [Payment] 
(
	[IdPayment]				INT PRIMARY KEY IDENTITY (1,1)																																NOT NULL,
	[TypeOfPaymentId]		INT	CONSTRAINT FK_Payment_TypeOfPaymentId_TypeOfPayment_IdTypeOfPayment	FOREIGN KEY REFERENCES [TypeOfPayment] ([IdTypeOfPayment])							NOT NULL,
	[SquarePrice]			INT																																							NOT NULL,
	[LodgersPrice]			INT																																						    NOT NULL,
	[PaymentAmount]			INT																																							NOT NULL,
	[SupposedDatePayment]   DATE																																						NOT NULL,
	[DateOfPayment]			DATE																																								
)
GO

CREATE TABLE [Account]
(
	[IdAccount]				INT PRIMARY KEY IDENTITY (1,1)																																NOT NULL,
	[Email]					NVARCHAR(30)																																				NOT NULL,
	[Password]				NVARCHAR(30)																																				NOT NULL
)
GO