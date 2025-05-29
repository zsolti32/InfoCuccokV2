-- CREATE DATABASE horsesDB
-- USE horsesDB

-- Create the Horses table (with all the necessary columns)
CREATE TABLE Horses (
    HorseID INT IDENTITY PRIMARY KEY,
    HorseName VARCHAR(100),
    BreedName VARCHAR(100),
    BreedOrigin VARCHAR(100),
    OwnerFirstName VARCHAR(100),
    OwnerLastName VARCHAR(100),
    OwnerContact VARCHAR(100),
    DateOfBirth DATE,
    Gender VARCHAR(10),
    Color VARCHAR(50),
    RaceName VARCHAR(100),
    RaceDate DATE,
    RaceLocation VARCHAR(100),
    RaceDistance INT,
    FinishPosition INT
);

-- Insert data into the Horses table
INSERT INTO Horses (HorseName, BreedName, BreedOrigin, OwnerFirstName, OwnerLastName, OwnerContact, DateOfBirth, Gender, Color, RaceName, RaceDate, RaceLocation, RaceDistance, FinishPosition)
VALUES
('Stormy', 'Thoroughbred', 'United Kingdom', 'John', 'Doe', 'john.doe@email.com', '2015-06-12', 'Male', 'Bay', 'Grand Derby', '2025-05-15', 'New York', 2400, 2),
('Whisper', 'Arabian', 'Saudi Arabia', 'Alice', 'Smith', 'alice.smith@email.com', '2018-04-22', 'Female', 'Gray', 'Grand Derby', '2025-05-15', 'New York', 2400, 1),
('Blaze', 'Mustang', 'United States', 'Robert', 'Brown', 'robert.brown@email.com', '2017-08-01', 'Male', 'Chestnut', 'Spring Invitational', '2025-06-10', 'Los Angeles', 1800, 3),
('Thunder', 'Clydesdale', 'Scotland', 'Emily', 'Davis', 'emily.davis@email.com', '2016-10-15', 'Male', 'Black', 'Champions Cup', '2025-07-04', 'Chicago', 2200, 4),
('Princess', 'Andalusian', 'Spain', 'Michael', 'Johnson', 'michael.johnson@email.com', '2019-03-10', 'Female', 'White', 'Summer Sprint', '2025-08-01', 'Miami', 1600, 1),
('Stormy', 'Thoroughbred', 'United Kingdom', 'John', 'Doe', 'john.doe@email.com', '2015-06-12', 'Male', 'Bay', 'Autumn Classic', '2025-09-20', 'Dallas', 2000, 5),
('Whisper', 'Arabian', 'Saudi Arabia', 'Alice', 'Smith', 'alice.smith@email.com', '2018-04-22', 'Female', 'Gray', 'Autumn Classic', '2025-09-20', 'Dallas', 2000, 3);