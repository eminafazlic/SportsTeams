USE [SportsTeamsDb]
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1013, N'Bosna i Hercegovina', N'BiH', NULL, N'Sarajevo', 4377033)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1014, N'Hrvatska', N'HR', NULL, N'Zagreb', 4437460)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1015, N'Srbija', N'RS', NULL, N'Beograd', 7186862)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1016, N'Španija', N'ESP', NULL, N'Madrid', 46934632)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1017, N'Engleska', N'GB-ENG', NULL, N'London', 56286961)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1018, N'Francuska', N'FRA', NULL, N'Pariz', 61538322)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1019, N'Njemačka', N'DE', NULL, N'Berlin', 81770944)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1020, N'Italija', N'ITA', NULL, N'Rim', 60589445)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1021, N'Nizozemska', N'NED', NULL, N'Amsterdam', 16669112)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1022, N'Turska', N'TUR', NULL, N'Ankara', 83154997)
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (13, N'FK Sarajevo', NULL, 1013, 1946, N'Asim Ferhatović Hase', 6230000, 29, N'Goran Sablić', N'Premijer liga', N'Damir Kasum', 34500)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (14, N'FK Željezničar', NULL, 1013, 1921, N'Grbavica', 2830000, 27, N'Tomislav Ivković', N'Premijer liga', N'Ivan Ivica Osim', 13146)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (15, N'FK Velež', NULL, 1013, 1922, N'Stadion Rođeni', 5530000, 24, N'Feđa Dudović', N'Premijer liga', N'Šemsudin Hasić', 6000)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (16, N'HŠK Zrinjski', NULL, 1013, 1905, N'Bijeli Brijeg', 5150000, 27, N'Zoran Glomazić', N'Premijer liga', N'Denis Lasić', 25000)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (17, N'FK Sloboda', NULL, 1013, 1919, N'Tušanj', 2980000, 20, N'Admir Smajić', N'Premijer liga', N'Mladen Zizović', 15000)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (18, N'GNK Dinamo Zagreb', NULL, 1014, 1945, N'Maksimir', 131800000, 37, N'Damir Krznar', N'1.HNL', N'Mirko Barišić', 35123)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (19, N'HNK Hajduk Split', NULL, 1014, 1911, N'Poljud', 33250000, 29, N'Jens Gustafsson', N'1.HNL', N'Lukša Jakobušić', 34183)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (20, N'NK Osijek', NULL, 1014, 1947, N'Gradski vrt', 31400000, 33, N'Nenad Bjelić', N'1.HNL', N'Ivan Meštrović', 18856)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (21, N'HNK Gorica', NULL, 1014, 2009, N'SRC Velika Gorica', 22300000, 29, N'Krunoslav Rendulić', N'1.HNL', N'Nenad Črnko', 3400)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (22, N'HNK Rijeka', NULL, 1014, 1946, N'Stadion Rujevica', 20730000, 35, N'Goran Tomić', N'1.HNL', N'Damir Mišković', 8136)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (23, N'Crvena Zvezda Beograd', NULL, 1015, 1945, N'Rajko Mitić stadion', 58850000, 29, N'Dejan Stanković', N'Super Liga Srbije', N'Svetozar Mijailović', 51755)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (24, N'FK Partizan Beograd', NULL, 1015, 1945, N'Partizan', 29900000, 32, N'Aleksandar Stanojević', N'Super Liga Srbije', N'Ivan Ćurković', 32710)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (25, N'FK Čukarički', NULL, 1015, 1936, N'Čukarički', 13780000, 29, N'Aleksandar Veselinović', N'Super Liga Srbije', N'Aleksandar Veselinović', 4070)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (26, N'FK Vojvodina Novi Sad', NULL, 1015, 1914, N'Karađorđe', 11700000, 24, N'Nenad Lalatović', N'Super Liga Srbije', N'Dušan Vlaović', 14852)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (27, N'FK TSC Backa Topola', NULL, 1015, 1913, N'Stadion Senta', 9250000, 28, N'Zoltan Sabo', N'Super Liga Srbije', N'Sabolč Palađi', 5000)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (28, N'Real Madrid', NULL, 1016, 1902, N'Estadio Alfredo Di Stéfano', 778500000, 26, N'Carlo Ancelotti', N' UEFA Liga prvaka, Kup Kralja, FIFA Svjetsko klupsko prvenstvo', N'Florentino Pérez', 9000)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (29, N'FC Barcelona', NULL, 1016, 1899, N'Camp Nou', 758700000, 27, N'Ronald Koeman', N' LaLiga, UEFA Liga prvaka, Kup Kralja', N'Joan Laporta', 99354)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (30, N'Atlético de Madrid', NULL, 1016, 1903, N' Wanda Metropolitano', 721400000, 25, N'Diego Simeone', N' LaLiga, UEFA Liga prvaka, Kup Kralja', N'Enrique Cerezo', 68456)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (31, N'Sevilla FC', NULL, 1016, 1890, N'Ramón Sánchez Pizjuan', 417900000, 27, N'Julen Lopetegui', N'LaLiga, UEFA Liga prvaka, UEFA Europska liga, Kup Kralja', N'José Castro Carmona', 48883)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (32, N'Real Sociedad', NULL, 1016, 1909, N'Reale Arena', 381700000, 27, N'Imanol Alguacil', N'LaLiga, Kup Kralja', N'Jokin Aperribay', 39500)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (33, N'Manchester City', NULL, 1017, 1894, N'Etihad Stadium', 1060000000, 25, N'Pep Guardiola', N'Premier League', N'Sheikh Mansour', 55017)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (34, N'Chelese FC', NULL, 1017, 1905, N'Stamford Bridge', 940000000, 34, N'Thomas Tuchel', N'Premier League', N'Thomas Tuchel', 40853)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (35, N'Mancheseter United', NULL, 1017, 1878, N'Old Trafford', 928250000, 30, N'Ole Gunnar Solskjær', N'Premier League', N'Glazer ownership of Manchester United', 74879)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (36, N'Liverpool FC', NULL, 1017, 1892, N'Anfield', 901500000, 31, N'Jürgen Klopp', N'Premier League', N'Tom Werner', 54074)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (37, N'Tottenham Hotspur', NULL, 1017, 1882, N'Tottenham Hotspur Stadium', 704000000, 26, N'Nuno Espírito Santo', N'Premier League', N'ENIC Group', 62062)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (38, N'Paris Saint-Germain', NULL, 1018, 1970, N'Parc des Princes', 993250000, 34, N'Mauricio Pochettino', N'Ligue 1', N'Nasser Al-Khelaifi', 49691)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (39, N'AS Monaco', NULL, 1018, 1919, N'Stade Louis-II', 385850000, 35, N'Niko Kovač', N'Ligue 1', N' Dmitrij Ribolovljev', 18523)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (40, N'Olympique Lyon', NULL, 1018, 1950, N'Groupama Stadium', 326150000, 28, N'Peter Bosz', N'Ligue 1', N'Jean-Michel Aulas', 59186)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (41, N'LOSC Lille', NULL, 1018, 1944, N'Stade Pierre-Mauroy', 267600000, 26, N'Christophe Galtier', N'Ligue 1', N'Christophe Galtier', 50186)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (42, N'Stade Rennais FC', NULL, 1018, 1901, N'Roazhon Park', 250150000, 33, N'Bruno Génésio', N'Ligue 1', N'Nicolas Holveck', 29778)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (43, N'Bayern Munich', NULL, 1019, 1900, N'Allianz Arena', 818500000, 26, N'Julian Nagelsmann', N'Bundesliga', N'Franz John', 75024)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (44, N'Borussia Dortmund', NULL, 1019, 1909, N'SIGNAL IDUNA PARK', 572400000, 34, N'Marco Rose', N'Bundesliga', N'Reinhard Rauball', 81365)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (45, N'RB Leipzig', NULL, 1019, 2009, N'Red Bull Arena', 560550000, 31, N'Jesse Marsch', N'Bundesliga', N'Oliver Mintzlaff', 42146)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (46, N'Bayer 04 Leverkusen', NULL, 1019, 1904, N'BayArena', 360250000, 31, N'Gerardo Seoane', N'Bundesliga', N'Gerardo Seoane', 30210)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (47, N'Borussia Mönchengladbach', NULL, 1019, 1900, N'Stadion im Borussia-Park', 301000000, 30, N'Adi Hütter', N'Bundesliga', N'Rolf Königs', 54022)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (48, N'Juventus FC', NULL, 1020, 1897, N'Allianz Stadium', 654600000, 27, N'Massimiliano Allegri', N'Serie A', N'Andrea Agnelli', 41507)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (49, N'Inter Milan', NULL, 1020, 1908, N'Giuseppe Meazza', 578800000, 31, N'Simone Inzaghi', N'Serie A', N'Steven Zhang', 75923)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (50, N'SSC Napoli', NULL, 1020, 1926, N'Stadio Diego Armando Maradona ', 497950000, 30, N'Luciano Spalletti', N'Serie A', N'Aurelio De Laurentiis', 54726)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (51, N'AS Roma', NULL, 1020, 1927, N' Olimpico di Roma ', 445850000, 42, N'José Mourinho', N'Serie A', N'James Pallotta', 73261)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (52, N'AC Milan', NULL, 1020, 1899, N'Giuseppe Meazza ', 430400000, 25, N'Stefano Pioli', N'Serie A', N'Paolo Scaroni', 75923)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (53, N'Ajax Amsterdam', NULL, 1021, 1900, N'Johan Cruijff ArenA ', 344900000, 26, N'Erik ten Hag', N'Eredivisie', N'Frank Eijken', 54990)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (54, N'PSV Eindhoven', NULL, 1021, 1913, N'Philips Stadion', 155550000, 29, N'Roger Schmidt', N'Eredivisie', N'Jan Albers', 35000)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (55, N'Feyenoord Rotterdam', NULL, 1021, 1908, N'Stadion Feyenoord De Kuip', 99500000, 28, N'Dick Advocaat', N'Eredivisie', N'Gerard Hoetmer', 47500)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (56, N'AZ Alkmaar', NULL, 1021, 1967, N'AFAS Stadion ', 89050000, 27, N'Pascal Jansen', N'Eredivisie', N'René Neelissen', 17023)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (57, N'FC Utrecht', NULL, 1021, 1970, N'Stadion Galgenwaard', 344900000, 29, N'René Hake', N'Eredivisie', N'Netherlands flag Thijs van Es', 23750)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (58, N'Fenerbahce SK', NULL, 1022, 1907, N'Stadion Ülker Stadyumu FB Şükrü Saraçoğlu Spor Kompleksi', 101930000, 38, N'Aleksandar Đorđević', N'SÜPER LIGTurkey', N'Ali Koč', 47834)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (59, N'Besiktas JK', NULL, 1022, 1903, N'Vodafone Park', 101450000, 33, N'Sergen Yalçın', N'SÜPER LIGTurkey', N'Ahmet Nur Çebi', 41188)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (60, N'Galatasaray A.S.', NULL, 1022, 1905, N'Ali Sami Yen Spor Kompleksi Türk Telekom Stadyumu', 98430000, 35, N'Fatih Terim', N'SÜPER LIGTurkey', N'Burak Elmas', 52223)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (61, N'Trabzonspor', NULL, 1022, 1963, N'Stadion Şenol Güneş Spor Kompleksi', 92900000, 29, N'Abdullah Avcı', N'SÜPER LIGTurkey', N'Ahmet Ağaoğlu', 40782)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (62, N'Istanbul Basaksehir FK', NULL, 1022, 2014, N'Stadion Başakşehir Fatih Terim Stadium', 54030000, 33, N'Aykut Kocaman', N'SÜPER LIGTurkey', N' Göksel Gümüşdağ', 17156)
GO
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210818083752_init', N'3.1.0')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210818101604_teamdetails', N'3.1.0')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210819102931_teamnewattributes', N'3.1.0')
GO
