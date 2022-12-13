CREATE SCHEMA SGN

GO

CREATE TABLE SGN.HARDWARE
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

CREATE TABLE SGN.SOFTWARE
(
		AssetNum				INT	IDENTITY (1,1)			NOT NULL,
		SystemName				VARCHAR(20)					NOT NULL,
		SystemVersion			VARCHAR(20)					NOT NULL,
		Manufacturer			VARCHAR(30)					NOT NULL,

		PRIMARY KEY (AssetNum)
);

CREATE TABLE SGN.STAFF
(
		StaffNum				INT IDENTITY (1,1)			NOT NULL,
		Username				VARCHAR(20)	UNIQUE			NOT NULL,
		PasswordHash			VARBINARY(256)				NOT NULL,

		PRIMARY KEY (StaffNum)
);