IF NOT EXISTS
(Select * from Cities where CityName = 'Acoma' , 'StateCode = 'NM' , 'AND CountryCode = 'US)
Begin
Insert into Cities (CityName, StateCode, CountryCode, Latitude, Longitude, IsEnabled, IataCityCode, FullTextColumn) values('Acoma' , 'NM' , 'US' , '34.8961' , '-107.5816' , '1' , 'NULL' , 'aco acom acoma');
End

IF NOT EXISTS
(Select * from Cities where CityName = 'Advance' , 'StateCode = 'NC' , 'AND CountryCode = 'US)
Begin
Insert into Cities (CityName, StateCode, CountryCode, Latitude, Longitude, IsEnabled, IataCityCode, FullTextColumn) values('Advance' , 'NC' , 'US' , '35.95468' , '-80.44132' , '1' , 'NULL' , 'adv adva advan advanc advance');
End

IF NOT EXISTS
(Select * from Cities where CityName = 'Alexander' , 'StateCode = 'ND' , 'AND CountryCode = 'US)
Begin
Insert into Cities (CityName, StateCode, CountryCode, Latitude, Longitude, IsEnabled, IataCityCode, FullTextColumn) values('Alexander' , 'ND' , 'US' , '47.843' , '-103.6426' , '1' , 'NULL' , 'ale alex alexa alexan alexand alexande alexander');
End

IF NOT EXISTS
(Select * from Cities where CityName = 'Aliceville' , 'StateCode = 'AL' , 'AND CountryCode = 'US)
Begin
Insert into Cities (CityName, StateCode, CountryCode, Latitude, Longitude, IsEnabled, IataCityCode, FullTextColumn) values('Aliceville' , 'AL' , 'US' , '33.0955' , '-88.18653' , '1' , 'NULL' , 'ali alic alice alicev alicevi alicevil alicevill aliceville');
End

IF NOT EXISTS
(Select * from Cities where CityName = 'Aliso Viejo' , 'StateCode = 'CA' , 'AND CountryCode = 'US)
Begin
Insert into Cities (CityName, StateCode, CountryCode, Latitude, Longitude, IsEnabled, IataCityCode, FullTextColumn) values('Aliso Viejo' , 'CA' , 'US' , '33.58153' , '-117.7247' , '1' , 'NULL' , 'ali alis aliso vie viej viejo');
End

