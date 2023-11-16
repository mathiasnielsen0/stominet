CREATE TABLE Bruger
(
    ID   MEDIUMINT     NOT NULL AUTO_INCREMENT,
    Navn NVARCHAR(255) NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE Stomi
(
    ID           MEDIUMINT NOT NULL AUTO_INCREMENT,
    StomiEjer    INT       NOT NULL REFERENCES Bruger (ID),
    StomiGiver   INT       NOT NULL REFERENCES Bruger (ID),
    TilfoejetDen DATETIME  NOT NULL,
    PRIMARY KEY (id)
)