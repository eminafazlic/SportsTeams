USE [SportsTeamsDb]
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1013, N'Bosna i Hercegovina', N'BiH', N'https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Flag_of_Bosnia_and_Herzegovina.svg/450px-Flag_of_Bosnia_and_Herzegovina.svg.png', N'Sarajevo', 4377033)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1014, N'Hrvatska', N'HR', N'https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Croatia.svg/300px-Flag_of_Croatia.svg.png', N'Zagreb', 4437460)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1015, N'Srbija', N'RS', N'https://upload.wikimedia.org/wikipedia/commons/thumb/f/ff/Flag_of_Serbia.svg/300px-Flag_of_Serbia.svg.png', N'Beograd', 7186862)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1016, N'Španija', N'ESP', N'https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Flag_of_Spain.svg/250px-Flag_of_Spain.svg.png', N'Madrid', 46934632)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1017, N'Engleska', N'GB-ENG', N'https://upload.wikimedia.org/wikipedia/commons/6/68/Flag_of_England_%28bordered%29.png', N'London', 56286961)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1018, N'Francuska', N'FRA', N'https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Flag_of_France.svg/300px-Flag_of_France.svg.png', N'Pariz', 61538322)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1019, N'Njemačka', N'DE', N'https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Flag_of_Germany.svg/300px-Flag_of_Germany.svg.png', N'Berlin', 81770944)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1020, N'Italija', N'ITA', N'https://upload.wikimedia.org/wikipedia/commons/0/03/Flag_of_Italy.svg', N'Rim', 60589445)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1021, N'Nizozemska', N'NED', N'https://upload.wikimedia.org/wikipedia/commons/2/20/Flag_of_the_Netherlands.svg', N'Amsterdam', 16669112)
GO
INSERT [dbo].[Countries] ([Id], [Name], [Abbreviation], [Picture], [Capital], [Population]) VALUES (1022, N'Turska', N'TUR', N'https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Flag_of_Turkey.svg/300px-Flag_of_Turkey.svg.png', N'Ankara', 83154997)
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (13, N'FK Sarajevo', N'https://upload.wikimedia.org/wikipedia/en/thumb/0/04/FK_Sarajevo_logo.svg/1200px-FK_Sarajevo_logo.svg.png', 1013, 1946, N'Asim Ferhatović Hase', 6230000, 29, N'Goran Sablić', N'Premijer liga', N'Damir Kasum', 34500)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (14, N'FK Željezničar', N'https://upload.wikimedia.org/wikipedia/en/thumb/9/9e/Zeljeznicar_logo.svg/1200px-Zeljeznicar_logo.svg.png', 1013, 1921, N'Grbavica', 2830000, 27, N'Tomislav Ivković', N'Premijer liga', N'Ivan Ivica Osim', 13146)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (15, N'FK Velež', N'https://i2.wp.com/fkvelez.ba/wp-content/uploads/2019/10/FK_Vele%C5%BE.png?fit=316%2C316&ssl=1', 1013, 1922, N'Stadion Rođeni', 5530000, 24, N'Feđa Dudović', N'Premijer liga', N'Šemsudin Hasić', 6000)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (16, N'HŠK Zrinjski', N'https://upload.wikimedia.org/wikipedia/en/thumb/6/69/H%C5%A0K_Zrinjski_Mostar.svg/1200px-H%C5%A0K_Zrinjski_Mostar.svg.png', 1013, 1905, N'Bijeli Brijeg', 5150000, 27, N'Zoran Glomazić', N'Premijer liga', N'Denis Lasić', 25000)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (17, N'FK Sloboda', N'https://upload.wikimedia.org/wikipedia/bs/f/fe/FK_Sloboda_Tuzla.png', 1013, 1919, N'Tušanj', 2980000, 20, N'Admir Smajić', N'Premijer liga', N'Mladen Zizović', 15000)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (18, N'GNK Dinamo Zagreb', N'https://banner2.cleanpng.com/20180609/bwg/kisspng-gnk-dinamo-zagreb-croatian-first-football-league-s-chk-dinamo-5b1c8c6e1ea850.5987832515285976141256.jpg', 1014, 1945, N'Maksimir', 1.318E+08, 37, N'Damir Krznar', N'1.HNL', N'Mirko Barišić', 35123)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (19, N'HNK Hajduk Split', N'https://upload.wikimedia.org/wikipedia/bs/c/c4/HNK_Hajduk_Split.png', 1014, 1911, N'Poljud', 3.325E+07, 29, N'Jens Gustafsson', N'1.HNL', N'Lukša Jakobušić', 34183)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (20, N'NK Osijek', N'https://upload.wikimedia.org/wikipedia/hr/thumb/4/4c/NK_Osijek.svg/1200px-NK_Osijek.svg.png', 1014, 1947, N'Gradski vrt', 3.14E+07, 33, N'Nenad Bjelić', N'1.HNL', N'Ivan Meštrović', 18856)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (21, N'HNK Gorica', N'https://www.logofootball.net/wp-content/uploads/HNK-Gorica-HD-Logo.png', 1014, 2009, N'SRC Velika Gorica', 2.23E+07, 29, N'Krunoslav Rendulić', N'1.HNL', N'Nenad Črnko', 3400)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (22, N'HNK Rijeka', N'https://upload.wikimedia.org/wikipedia/hr/a/ad/HNK_Rijeka.svg', 1014, 1946, N'Stadion Rujevica', 2.073E+07, 35, N'Goran Tomić', N'1.HNL', N'Damir Mišković', 8136)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (23, N'Crvena Zvezda Beograd', N'https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Grb-fk-crvena-zvezda.svg/1200px-Grb-fk-crvena-zvezda.svg.png', 1015, 1945, N'Rajko Mitić stadion', 5.885E+07, 29, N'Dejan Stanković', N'Super Liga Srbije', N'Svetozar Mijailović', 51755)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (24, N'FK Partizan Beograd', N'https://upload.wikimedia.org/wikipedia/en/thumb/e/ed/FK_Partizan.svg/1200px-FK_Partizan.svg.png', 1015, 1945, N'Partizan', 2.99E+07, 32, N'Aleksandar Stanojević', N'Super Liga Srbije', N'Ivan Ćurković', 32710)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (25, N'FK Čukarički', N'https://seeklogo.com/images/F/fk-cukaricki-stankom-logo-6A17DC2F49-seeklogo.com.png', 1015, 1926, N'Čukarički', 1.378E+07, 29, N'Aleksandar Veselinović', N'Super Liga Srbije', N'Aleksandar Veselinović', 4070)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (26, N'FK Vojvodina Novi Sad', N'https://upload.wikimedia.org/wikipedia/en/thumb/4/4d/FK_Vojvodina_logo.svg/1200px-FK_Vojvodina_logo.svg.png', 1015, 1914, N'Karađorđe', 1.17E+07, 24, N'Nenad Lalatović', N'Super Liga Srbije', N'Dušan Vlaović', 14852)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (27, N'FK TSC Backa Topola', N'https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/022018/fk_backa_topola.gif?s13ClC8YPI76MW8ivLeV5YOc4QlZzNtm&itok=cR0UEvVU', 1015, 1913, N'Stadion Senta', 9250000, 28, N'Zoltan Sabo', N'Super Liga Srbije', N'Sabolč Palađi', 5000)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (28, N'Real Madrid', N'https://www.logofootball.net/wp-content/uploads/Real-Madrid-CF-Logo.png', 1016, 1902, N'Estadio Alfredo Di Stéfano', 7.785E+08, 26, N'Carlo Ancelotti', N' UEFA Liga prvaka, Kup Kralja, FIFA Svjetsko klupsko prvenstvo', N'Florentino Pérez', 9000)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (29, N'FC Barcelona', N'https://upload.wikimedia.org/wikipedia/en/thumb/4/47/FC_Barcelona_%28crest%29.svg/1200px-FC_Barcelona_%28crest%29.svg.png', 1016, 1899, N'Camp Nou', 7.587E+08, 27, N'Ronald Koeman', N' LaLiga, UEFA Liga prvaka, Kup Kralja', N'Joan Laporta', 99354)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (30, N'Atlético de Madrid', N'https://upload.wikimedia.org/wikipedia/en/thumb/f/f4/Atletico_Madrid_2017_logo.svg/1200px-Atletico_Madrid_2017_logo.svg.png', 1016, 1903, N' Wanda Metropolitano', 7.214E+08, 25, N'Diego Simeone', N' LaLiga, UEFA Liga prvaka, Kup Kralja', N'Enrique Cerezo', 68456)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (31, N'Sevilla FC', N'https://upload.wikimedia.org/wikipedia/en/thumb/3/3b/Sevilla_FC_logo.svg/1200px-Sevilla_FC_logo.svg.png', 1016, 1890, N'Ramón Sánchez Pizjuan', 4.179E+08, 27, N'Julen Lopetegui', N'LaLiga, UEFA Liga prvaka, UEFA Europska liga, Kup Kralja', N'José Castro Carmona', 48883)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (32, N'Real Sociedad', N'https://upload.wikimedia.org/wikipedia/en/thumb/f/f1/Real_Sociedad_logo.svg/1200px-Real_Sociedad_logo.svg.png', 1016, 1909, N'Reale Arena', 3.817E+08, 27, N'Imanol Alguacil', N'LaLiga, Kup Kralja', N'Jokin Aperribay', 39500)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (33, N'Manchester City', N'https://upload.wikimedia.org/wikipedia/en/thumb/e/eb/Manchester_City_FC_badge.svg/1200px-Manchester_City_FC_badge.svg.png', 1017, 1894, N'Etihad Stadium', 1.06E+09, 25, N'Pep Guardiola', N'Premier League', N'Sheikh Mansour', 55017)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (34, N'Chelsea FC', N'https://upload.wikimedia.org/wikipedia/sco/thumb/c/cc/Chelsea_FC.svg/2048px-Chelsea_FC.svg.png', 1017, 1905, N'Stamford Bridge', 9.4E+08, 34, N'Thomas Tuchel', N'Premier League', N'Thomas Tuchel', 40853)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (35, N'Manchester United', N'https://upload.wikimedia.org/wikipedia/en/thumb/7/7a/Manchester_United_FC_crest.svg/1200px-Manchester_United_FC_crest.svg.png', 1017, 1878, N'Old Trafford', 9.2825E+08, 30, N'Ole Gunnar Solskjær', N'Premier League', N'Glazer ownership of Manchester United', 74879)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (36, N'Liverpool FC', N'https://upload.wikimedia.org/wikipedia/en/thumb/0/0c/Liverpool_FC.svg/1200px-Liverpool_FC.svg.png', 1017, 1892, N'Anfield', 9.015E+08, 31, N'Jürgen Klopp', N'Premier League', N'Tom Werner', 54074)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (37, N'Tottenham Hotspur', N'https://upload.wikimedia.org/wikipedia/en/thumb/b/b4/Tottenham_Hotspur.svg/1200px-Tottenham_Hotspur.svg.png', 1017, 1882, N'Tottenham Hotspur Stadium', 7.04E+08, 26, N'Nuno Espírito Santo', N'Premier League', N'ENIC Group', 62062)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (38, N'Paris Saint-Germain', N'https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/Paris_Saint-Germain_F.C..svg/1200px-Paris_Saint-Germain_F.C..svg.png', 1018, 1970, N'Parc des Princes', 9.9325E+08, 34, N'Mauricio Pochettino', N'Ligue 1', N'Nasser Al-Khelaifi', 49691)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (39, N'AS Monaco', N'https://upload.wikimedia.org/wikipedia/en/thumb/b/ba/AS_Monaco_FC.svg/1200px-AS_Monaco_FC.svg.png', 1018, 1919, N'Stade Louis-II', 3.8585E+08, 35, N'Niko Kovač', N'Ligue 1', N' Dmitrij Ribolovljev', 18523)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (40, N'Olympique Lyon', N'https://logodownload.org/wp-content/uploads/2019/09/lyon-logo-4.png', 1018, 1950, N'Groupama Stadium', 3.2615E+08, 28, N'Peter Bosz', N'Ligue 1', N'Jean-Michel Aulas', 59186)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (41, N'LOSC Lille', N'https://upload.wikimedia.org/wikipedia/en/thumb/3/3f/Lille_OSC_2018_logo.svg/1200px-Lille_OSC_2018_logo.svg.png', 1018, 1944, N'Stade Pierre-Mauroy', 2.676E+08, 26, N'Christophe Galtier', N'Ligue 1', N'Christophe Galtier', 50186)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (42, N'Stade Rennais FC', N'https://upload.wikimedia.org/wikipedia/en/thumb/9/9e/Stade_Rennais_FC.svg/1200px-Stade_Rennais_FC.svg.png', 1018, 1901, N'Roazhon Park', 2.5015E+08, 33, N'Bruno Génésio', N'Ligue 1', N'Nicolas Holveck', 29778)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (43, N'Bayern Munich', N'https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/FC_Bayern_M%C3%BCnchen_logo_%282017%29.svg/1200px-FC_Bayern_M%C3%BCnchen_logo_%282017%29.svg.png', 1019, 1900, N'Allianz Arena', 8.185E+08, 26, N'Julian Nagelsmann', N'Bundesliga', N'Franz John', 75024)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (44, N'Borussia Dortmund', N'https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Borussia_Dortmund_logo.svg/560px-Borussia_Dortmund_logo.svg.png', 1019, 1909, N'SIGNAL IDUNA PARK', 5.724E+08, 34, N'Marco Rose', N'Bundesliga', N'Reinhard Rauball', 81365)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (45, N'RB Leipzig', N'https://upload.wikimedia.org/wikipedia/hr/thumb/0/04/RB_Leipzig_2014_logo.svg/1200px-RB_Leipzig_2014_logo.svg.png', 1019, 2009, N'Red Bull Arena', 5.6055E+08, 31, N'Jesse Marsch', N'Bundesliga', N'Oliver Mintzlaff', 42146)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (46, N'Bayer 04 Leverkusen', N'https://upload.wikimedia.org/wikipedia/bs/thumb/f/f7/Bayer_Leverkusen_Logo.svg/1200px-Bayer_Leverkusen_Logo.svg.png', 1019, 1904, N'BayArena', 3.6025E+08, 31, N'Gerardo Seoane', N'Bundesliga', N'Gerardo Seoane', 30210)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (47, N'Borussia Mönchengladbach', N'https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Borussia_M%C3%B6nchengladbach_logo.svg/1200px-Borussia_M%C3%B6nchengladbach_logo.svg.png', 1019, 1900, N'Stadion im Borussia-Park', 3.01E+08, 30, N'Adi Hütter', N'Bundesliga', N'Rolf Königs', 54022)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (48, N'Juventus FC', N'https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Juventus_FC_2017_logo.svg/1031px-Juventus_FC_2017_logo.svg.png', 1020, 1897, N'Allianz Stadium', 6.546E+08, 27, N'Massimiliano Allegri', N'Serie A', N'Andrea Agnelli', 41507)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (49, N'Inter Milan', N'https://e7.pngegg.com/pngimages/6/206/png-clipart-inter-milan-cagliari-a-c-milan-logo-football-emblem-trademark.png', 1020, 1908, N'Giuseppe Meazza', 5.788E+08, 31, N'Simone Inzaghi', N'Serie A', N'Steven Zhang', 75923)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (50, N'SSC Napoli', N'https://upload.wikimedia.org/wikipedia/commons/thumb/2/2d/SSC_Neapel.svg/600px-SSC_Neapel.svg.png', 1020, 1926, N'Stadio Diego Armando Maradona ', 4.9795E+08, 30, N'Luciano Spalletti', N'Serie A', N'Aurelio De Laurentiis', 54726)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (51, N'AS Roma', N'https://upload.wikimedia.org/wikipedia/en/thumb/f/f7/AS_Roma_logo_%282017%29.svg/1200px-AS_Roma_logo_%282017%29.svg.png', 1020, 1927, N' Olimpico di Roma ', 4.4585E+08, 42, N'José Mourinho', N'Serie A', N'James Pallotta', 73261)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (52, N'AC Milan', N'https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Logo_of_AC_Milan.svg/653px-Logo_of_AC_Milan.svg.png', 1020, 1899, N'Giuseppe Meazza ', 4.304E+08, 25, N'Stefano Pioli', N'Serie A', N'Paolo Scaroni', 75923)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (53, N'Ajax Amsterdam', N'https://upload.wikimedia.org/wikipedia/en/thumb/7/79/Ajax_Amsterdam.svg/1200px-Ajax_Amsterdam.svg.png', 1021, 1900, N'Johan Cruijff ArenA ', 3.449E+08, 26, N'Erik ten Hag', N'Eredivisie', N'Frank Eijken', 54990)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (54, N'PSV Eindhoven', N'https://upload.wikimedia.org/wikipedia/en/thumb/0/05/PSV_Eindhoven.svg/1200px-PSV_Eindhoven.svg.png', 1021, 1913, N'Philips Stadion', 1.5555E+08, 29, N'Roger Schmidt', N'Eredivisie', N'Jan Albers', 35000)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (55, N'Feyenoord Rotterdam', N'https://upload.wikimedia.org/wikipedia/sco/thumb/e/e3/Feyenoord_logo.svg/1200px-Feyenoord_logo.svg.png', 1021, 1908, N'Stadion Feyenoord De Kuip', 9.95E+07, 28, N'Dick Advocaat', N'Eredivisie', N'Gerard Hoetmer', 47500)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (56, N'AZ Alkmaar', N'https://brandslogos.com/wp-content/uploads/images/large/az-alkmaar-logo.png', 1021, 1967, N'AFAS Stadion ', 8.905E+07, 27, N'Pascal Jansen', N'Eredivisie', N'René Neelissen', 17023)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (57, N'FC Utrecht', N'https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/Logo_FC_Utrecht.svg/1200px-Logo_FC_Utrecht.svg.png', 1021, 1970, N'Stadion Galgenwaard', 3.449E+08, 29, N'René Hake', N'Eredivisie', N'Netherlands flag Thijs van Es', 23750)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (58, N'Fenerbahce SK', N'https://brandslogos.com/wp-content/uploads/images/fenerbahce-spor-kulubu-logo-vector.svg', 1022, 1907, N'Stadion Ülker Stadyumu FB Şükrü Saraçoğlu Spor Kompleksi', 1.0193E+08, 38, N'Aleksandar Đorđević', N'SÜPER LIGTurkey', N'Ali Koč', 47834)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (59, N'Besiktas JK', N'https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Logo_of_Be%C5%9Fikta%C5%9F_JK.svg/2002px-Logo_of_Be%C5%9Fikta%C5%9F_JK.svg.png', 1022, 1903, N'Vodafone Park', 1.0145E+08, 33, N'Sergen Yalçın', N'SÜPER LIGTurkey', N'Ahmet Nur Çebi', 41188)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (60, N'Galatasaray A.S.', N'https://upload.wikimedia.org/wikipedia/commons/f/f6/Galatasaray_Sports_Club_Logo.png', 1022, 1905, N'Ali Sami Yen Spor Kompleksi Türk Telekom Stadyumu', 9.843E+07, 35, N'Fatih Terim', N'SÜPER LIGTurkey', N'Burak Elmas', 52223)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (61, N'Trabzonspor', N'https://upload.wikimedia.org/wikipedia/en/thumb/c/c7/Trabzonspor_logo.svg/1200px-Trabzonspor_logo.svg.png', 1022, 1963, N'Stadion Şenol Güneş Spor Kompleksi', 9.29E+07, 29, N'Abdullah Avcı', N'SÜPER LIGTurkey', N'Ahmet Ağaoğlu', 40782)
GO
INSERT [dbo].[Teams] ([Id], [Name], [Picture], [CountryId], [Founded], [HomeGround], [MarketValue], [NumberOfPlayers], [HeadCoach], [League], [President], [StadiumCapacity]) VALUES (62, N'Istanbul Basaksehir FK', N'https://upload.wikimedia.org/wikipedia/en/thumb/e/e1/%C4%B0stanbul_Ba%C5%9Fak%C5%9Fehir_logo.svg/1200px-%C4%B0stanbul_Ba%C5%9Fak%C5%9Fehir_logo.svg.png', 1022, 2014, N'Stadion Başakşehir Fatih Terim Stadium', 5.403E+07, 33, N'Aykut Kocaman', N'SÜPER LIGTurkey', N' Göksel Gümüşdağ', 17156)
GO
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210818083752_init', N'3.1.0')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210818101604_teamdetails', N'3.1.0')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210819102931_teamnewattributes', N'3.1.0')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210826072838_slike', N'3.1.0')
GO
