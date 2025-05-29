-- CREATE DATABASE paralimpiadb;
-- USE paralimpiadbdb;

CREATE TABLE paralimpia (
  id INT NOT NULL PRIMARY KEY IDENTITY,
  orszag VARCHAR(20) NOT NULL,
  varos VARCHAR(20) NOT NULL,
  ev INT NOT NULL,
  arany INT NULL,
  ezust INT NULL,
  bronz INT NULL
);

INSERT INTO paralimpia VALUES
('Olaszország', 'Róma', 1960, NULL, NULL, NULL),
('Japán', 'Tokió', 1964, NULL, NULL, NULL),
('Izrael', 'Tel Aviv', 1968, NULL, NULL, NULL),
('Németország', 'Heidelberg', 1972, 0, 0, 1),
('Kanada', 'Torontó', 1976, 1, 0, 1),
('Hollandia', 'Arnheim', 1980, 0, 0, 0),
('Egyesült Államok', 'New York', 1984, 13, 11, 5),
('Dél-Korea', 'Szöul', 1988, 0, 5, 7),
('Spanyolország', 'Barcelona', 1992, 4, 3, 4),
('Egyesült Államok', 'Atlanta', 1996, 5, 2, 3),
('Ausztrália', 'Sydney', 2000, 4, 5, 14),
('Görögország', 'Athén', 2004, 1, 8, 10),
('Kína', 'Peking', 2008, 1, 0, 5),
('Egyesült Királyság', 'London', 2012, 2, 6, 6),
('Brazília', 'Rio de Janeiro', 2016, 1, 8, 9),
('Japán', 'Tokió', 2020, 7, 5, 4);