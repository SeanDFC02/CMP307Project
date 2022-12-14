CREATE SCHEMA SCOT

GO

CREATE TABLE SCOT.HARDWARE
(
		AssetNum				INT IDENTITY (1, 1)			NOT NULL,
		SystemName				VARCHAR(20)					NOT NULL,
		Model					VARCHAR(30)					NOT NULL,
		Manufacturer			VARCHAR(30)					NOT NULL,
		AssetType				VARCHAR(15)					NOT NULL,
		IPAdress				VARCHAR(15)					NOT NULL,
		PurchaseDate			VARCHAR(10),
		Notes					Text,

		PRIMARY KEY (AssetNum)
);

CREATE TABLE SCOT.SOFTWARE
(
		AssetNum				INT	IDENTITY (1,1)			NOT NULL,
		SystemName				VARCHAR(20)					NOT NULL,
		SystemVersion			VARCHAR(20)					NOT NULL,
		Manufacturer			VARCHAR(30)					NOT NULL,

		PRIMARY KEY (AssetNum)
);

CREATE TABLE SCOT.STAFF
(
    StaffID						INT IDENTITY(1,1)			NOT NULL,
    UserName					VARCHAR(20)					NOT NULL,
	UserPass					VARCHAR(20)					NOT NULL,

    PRIMARY KEY (StaffID)
);