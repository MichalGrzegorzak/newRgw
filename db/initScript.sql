USE [test]
GO
--POLECIL--------------------------------------------------------------   
INSERT INTO [dbo].[Polecil]([Nazwa]) VALUES ('brak')
INSERT INTO [dbo].[Polecil]([Nazwa]) VALUES ('polecajacy1')
INSERT INTO [dbo].[Polecil]([Nazwa]) VALUES ('polecajacy2')        
--ADRES--------------------------------------------------------------
INSERT INTO [dbo].[Adres]([Kod],[Miasto],[Ulica],[Miejsce],[Kraj]) VALUES ('40-133','Katowice','gronika1', '',2)
INSERT INTO [dbo].[Adres]([Kod],[Miasto],[Ulica],[Miejsce],[Kraj]) VALUES ('58-260','Bialawa','młodych 25', '',2)
INSERT INTO [dbo].[Adres]([Kod],[Miasto],[Ulica],[Miejsce],[Kraj]) VALUES ('66-666','Berlin','strase 33', '',3)
INSERT INTO [dbo].[Adres]([Kod],[Miasto],[Ulica],[Miejsce],[Kraj]) VALUES ('11-133','Ścinawa Mała','ulica 55', 'Nysa',2)
--BANKI--------------------------------------------------------------
INSERT INTO [dbo].[Bank]([Kraj],[Blz],[Nazwa],[Swift],[Adres]) VALUES (1, 1, 'brak', 'brak', 'brak')
INSERT INTO [dbo].[Bank]([Kraj],[Blz],[Nazwa],[Swift],[Adres]) VALUES (2, 12345, 'nazwa banku', '', 'adres banku')
--KLIENT--------------------------------------------------------------
INSERT INTO [dbo].[Klient]([Urodz],[Plec],[PolecajId]) VALUES ('2009-01-01', '1', '1')
INSERT INTO [dbo].[Klient]([Urodz],[Plec],[PolecajId]) VALUES ('2008-02-02', '2', '2')
--------------------------------------------------------------
INSERT INTO [dbo].[Rozliczenie]
           ([Rok],[Kraj],[KlientId],[MandId],[Steuernummer]
           ,[Imie],[ImieDe],[Nazwisko],[NazwiskoDe],[AdresZameldId],[AdresKorespId]
           ,[Wyznanie],[Telefon],[Komorka],[Notka],[Email]
           ,[KontoLk],[KontoBlz],[KontoNr]
           ,[BankId],[KontoAdresBanku],[KontoWlasciciel]
           ,[PartnerMandId],[PartnerImie],[PartnerUrodz],[PartnerSlub],[PartnerWyznanie]
           ,[DzieciLiczba],[DzieciDaty],[Status],[Pozycja]
           ,[Zaplacono],[CreatedOn],[MovedOn],[RachunekId]
           ,[CreatedBy],[ModifiedBy],[ModifiedOn])
     VALUES
           (2008,1 ,1 , '111', 12345
           ,'Michał','Michal', 'Grzegorzak', 'Grzegorzak',1,2
           ,1, '33445566','333444555','notka here','emailhere@pl'
           ,'2','123456','1122334455667788'
           ,1,'swift/adtres here','Michal Grzegorzak'
           ,'122','Ewa','11-11-1981','11-11-2009',1
           ,2,'11-11-2011;10-10-2010',66,1
           ,30, '11-11-2011','11-11-2011', NULL
           ,'czeslaw','czeslaw','11-11-2011')
GO
INSERT INTO [dbo].[Rozliczenie]
           ([Rok],[Kraj],[KlientId],[MandId],[Steuernummer]
           ,[Imie],[ImieDe],[Nazwisko],[NazwiskoDe],[AdresZameldId],[AdresKorespId]
           ,[Wyznanie],[Telefon],[Komorka],[Notka],[Email]
           ,[KontoLk],[KontoBlz],[KontoNr]
           ,[BankId],[KontoAdresBanku],[KontoWlasciciel]
           ,[PartnerMandId],[PartnerImie],[PartnerUrodz],[PartnerSlub],[PartnerWyznanie]
           ,[DzieciLiczba],[DzieciDaty],[Status],[Pozycja]
           ,[Zaplacono],[CreatedOn],[MovedOn],[RachunekId]
           ,[CreatedBy],[ModifiedBy],[ModifiedOn])
     VALUES
           (2009,2 ,2 , '222', '123456'
           ,'Michał2','Michal2', 'Grzegorzak2', 'Grzegorzak2',3,4
           ,1, '3344556611','33344455511','notka here2','email2here@pl'
           ,'22','12345678','1122321234455667788'
           ,2,'swift/adtres here2','Michal Grzegorzak2'
           ,'1222','Ewa','11-11-1981','11-11-2009',1
           ,3,'09-09-2011;10-10-2011;11-11-2011',66,1
           ,30, '11-11-2011','11-11-2011', NULL
           ,'czeslaw','czeslaw','11-11-2011')
GO


------ROZLICZENIA HISTORIA
INSERT INTO [test].[dbo].[RozliczHist]
           ([RozliczId]
           ,[Status]
           ,[CreatedBy]
           ,[CreatedOn])
     VALUES
           (1,
           88,
           'aaa',
           '2001-01-29')
GO

INSERT INTO [test].[dbo].[RozliczHist]
           ([RozliczId]
           ,[Status]
           ,[CreatedBy]
           ,[CreatedOn])
     VALUES
           (1,
           100,
           'bbb',
           '2001-01-31')
GO


------------------------



--------------------------------------------------------------
--------------------------------------------------------------
GO


