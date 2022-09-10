USE TestBooks
GO

INSERT INTO Client(Client_FName, sName, Student_No)
VALUES
('Markus', 'Swanepoel','34698512'),
('Jacques','Botha','35678425'),
('Carla','Marais','26539856'),
('Lorinda','Joubert','23565232'),
('Karen','Du Toit', '34685465'),
('Sonja', 'Landsberg','45232653'),
('Johan', 'Smith','36542565'),
('Lourens', 'Grey', '34857542'),
('Thinus','Du Randt','46485256'),
('Vanessa','Lottering', '43652563');

INSERT INTO Author(Auth_fName,sName)
VALUES
('Iwann', 'Du Toit'),
('Obelya', 'Fourie'),
('Sanri' ,'Lottering'),
('Maroelinda','Strydom'),
('John William', 'Wege'),
('Traz', 'Mocke'),
('Shimi','Mashishi');

INSERT INTO Module(Mod_Description,ModuleCode) 
VALUES
('System Analysis and Design II', 'CMPG223'),
('Public Economics','Econ315'),
('System Analysis and Design','CMPG213'),
('Financial Markets','EKRP321'),
('Information Security','CMPG215'),
('Business Ethics','312'),
('Financial Accounting','ACCS111'),
('General Management', 'BMAN121'),
('Practical statistics','STTN124'),
('Econometrics','Econ325');


INSERT INTO Condition(Quality) 
VALUES
('Very Bad'),
('Bad'),
('Moderate'),
('Good'),
('Very Good'),
('Brand New');

INSERT INTO Textbook(Title,Edition,Price, Con_ID, Module_CodeID)
VALUES 
('Systems Design and Computers', '3rd',250, (Select Con_ID from Condition where Con_ID = 1), (Select Module_CodeID from Module where Module_CodeID = 1)),
('Public Economics in South Africa', '7th',150, (Select Con_ID from Condition where Con_ID = 2), (Select Module_CodeID from Module where Module_CodeID = 2)),
('Systems Design and Computers', '3rd',200, (Select Con_ID from Condition where Con_ID = 3), (Select Module_CodeID from Module where Module_CodeID = 3)),
('Investment Management', '4th',150, (Select Con_ID from Condition where Con_ID = 4), (Select Module_CodeID from Module where Module_CodeID = 4)),
('Cyber Security','1st',200, (Select Con_ID from Condition where Con_ID = 5), (Select Module_CodeID from Module where Module_CodeID = 5)),
('Ethics in the workplace','2nd',200, (Select Con_ID from Condition where Con_ID = 6), (Select Module_CodeID from Module where Module_CodeID = 6)),
('Accounting-all-in-one','5th',150, (Select Con_ID from Condition where Con_ID = 2), (Select Module_CodeID from Module where Module_CodeID = 7)),
('Introduction to Business Management','6th',150, (Select Con_ID from Condition where Con_ID = 3), (Select Module_CodeID from Module where Module_CodeID = 8)),
('Introductory Descriptive Statistics', '3rd',250, (Select Con_ID from Condition where Con_ID = 2), (Select Module_CodeID from Module where Module_CodeID = 9)),
('Econometrics 101','2nd',200, (Select Con_ID from Condition where Con_ID = 5), (Select Module_CodeID from Module where Module_CodeID = 10));

INSERT INTO AuthTextbook(Author_ID, Txt_Id)
Values
((Select Author_ID from Author where Author_ID = 1), (Select Txt_Id from TextBook where Txt_ID = 1)),
((Select Author_ID from Author where Author_ID = 1), (Select Txt_Id from TextBook where Txt_ID = 2)),
((Select Author_ID from Author where Author_ID = 2), (Select Txt_Id from TextBook where Txt_ID = 3)),
((Select Author_ID from Author where Author_ID = 3), (Select Txt_Id from TextBook where Txt_ID = 4)),
((Select Author_ID from Author where Author_ID = 4), (Select Txt_Id from TextBook where Txt_ID = 5)),
((Select Author_ID from Author where Author_ID = 4), (Select Txt_Id from TextBook where Txt_ID = 6)),
((Select Author_ID from Author where Author_ID = 5), (Select Txt_Id from TextBook where Txt_ID = 7)),
((Select Author_ID from Author where Author_ID = 6), (Select Txt_Id from TextBook where Txt_ID = 8)),
((Select Author_ID from Author where Author_ID = 7), (Select Txt_Id from TextBook where Txt_ID = 9)),
((Select Author_ID from Author where Author_ID = 7), (Select Txt_Id from TextBook where Txt_ID = 10));

INSERT INTO Trans_Detail(Txt_ID, Trans_Type, Client_ID, PricePaid)
Values
((Select Txt_Id from TextBook where Txt_ID = 1), 0, (Select Client_ID from Client where Client_ID = 1), 200),
((Select Txt_Id from TextBook where Txt_ID = 1), 1, (Select Client_ID from Client where Client_ID = 2), 250),
((Select Txt_Id from TextBook where Txt_ID = 3), 0, (Select Client_ID from Client where Client_ID = 3), 150),
((Select Txt_Id from TextBook where Txt_ID = 4), 1, (Select Client_ID from Client where Client_ID = 5), 150),
((Select Txt_Id from TextBook where Txt_ID = 9), 0, (Select Client_ID from Client where Client_ID = 8), 200),
((Select Txt_Id from TextBook where Txt_ID = 6), 1, (Select Client_ID from Client where Client_ID = 7), 200);

