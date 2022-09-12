USE Testbooks
GO 

CREATE table Client(
	Client_ID int IDENTITY(1,1) Primary key,
	Client_FName varchar(30),
	sName varchar(55),
	Student_No varchar(8)
);

CREATE table Author(
	Author_ID int IDENTITY(1,1) Primary key,
	Auth_fName varchar(30),
	sName varchar(55)
);	

CREATE table Module(
	Module_CodeID int IDENTITY(1,1) Primary key,
	Mod_Description varchar(50),
	ModuleCode varchar(7)
);

CREATE table Condition(
	Con_ID int IDENTITY(1,1) Primary key,
	Quality varchar(10),
);

CREATE table Textbook(
	Txt_ID int IDENTITY(1,1) Primary key,
	Title varchar(50),
	Edition varchar(10),
	Condition varchar(10),
	Module_CodeID int Foreign key References Module(Module_CodeID),
	Con_ID int Foreign key References Condition(Con_ID),
	Price smallmoney
	);


CREATE table Trans_Detail(
	Trans_ID int IDENTITY(1,1) Primary key,
	Txt_ID int Foreign key References Textbook(Txt_ID),
	Trans_Type BIT,
	Client_ID int Foreign key References Client(Client_ID),
	PricePaid smallmoney,
	Trans_Date Date
);

CREATE table AuthTextbook(
	Author_ID int Foreign key References Author(Author_ID),
	Txt_ID int Foreign key References Textbook(Txt_ID)
);

