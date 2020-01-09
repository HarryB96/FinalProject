--DROP DATABASE IF exists TrainingDB
--GO

--CREATE DATABASE TrainingDB
--GO

DROP TABLE IF exists Users
GO

DROP TABLE IF exists TypeOfUser
GO

DROP TABLE IF exists Course
GO

CREATE TABLE TypeOfUser(
TypeId int NOT NULL IDENTITY PRIMARY KEY,
TypeName VARCHAR (20),
CanEditUsers BIT,
CanAddAdmins BIT
)

CREATE TABLE Course(

CourseId INT NOT NULL IDENTITY PRIMARY KEY,
Cours+eName NVARCHAR(50)
)

CREATE TABLE Users(
UserId INT NOT NULL IDENTITY PRIMARY KEY,
FirstName VARCHAR (20),
LastName VARCHAR (20),
Email NVARCHAR (50) UNIQUE,
UserPassword NVARCHAR (20),
CurrentScore INT NULL,
MaxScore INT NULL,
EndDate DATE NULL,
TypeId INT NOT NULL FOREIGN KEY REFERENCES TypeOfUser(TypeId),
CourseId INT NULL FOREIGN KEY REFERENCES Course(CourseId)
)

INSERT INTO Course VALUES('C# Stream')


INSERT INTO TypeOfUser VALUES('Spartan',0,0)
INSERT INTO TypeOfUser VALUES('Admin',1,0)
INSERT INTO TypeOfUser VALUES('Master',1,1)



INSERT INTO Users VALUES('Johnny','Test','johnnytest@gmail.com','password1',0,100,'2020-01-06',1,1)
INSERT INTO Users VALUES('Michael','Admin','MichaelAdmin@gmail.com','password1',NULL,NULL,NULL,2,NULL)
INSERT INTO Users VALUES('Charlie','Master','CharlieMaster@gmail.com','password1',NULL,NULL,NULL,3,NULL)

SELECT * FROM Users
SELECT * FROM TypeOfUser
SELECT * FROM Course

-- NOTE:Cant do multiple select statements in azure