-- CREATE DATABASE shipdb;
-- USE shipdb;

CREATE TABLE Ships (
    ShipID INT IDENTITY PRIMARY KEY,
    ShipName VARCHAR(100),
    ShipType VARCHAR(50),
    YearBuilt INT,
    Capacity INT,
    Owner VARCHAR(100),
    IsInService BIT
);

INSERT INTO Ships VALUES
('Titanic', 'Cruise Ship', 1912, 2200, 'White Star Line', 0),
('Queen Mary 2', 'Cruise Ship', 2004, 2620, 'Cunard Line', 1),
('USS Enterprise', 'Aircraft Carrier', 1961, 4000, 'United States Navy', 0),
('Harmony of the Seas', 'Cruise Ship', 2016, 6700, 'Royal Caribbean', 1),
('Nimitz', 'Aircraft Carrier', 1975, 5000, 'United States Navy', 1),
('Oasis of the Seas', 'Cruise Ship', 2009, 5400, 'Royal Caribbean', 1),
('Bismarck', 'Battleship', 1939, 2200, 'Kriegsmarine', 0),
('Independence of the Seas', 'Cruise Ship', 2008, 4370, 'Royal Caribbean', 1),
('Queen Elizabeth 2', 'Cruise Ship', 1967, 1800, 'Cunard Line', 0),
('USS Missouri', 'Battleship', 1944, 2700, 'United States Navy', 0);