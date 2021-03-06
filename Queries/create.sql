use sandbox;

-- Create the table in the specified schema
CREATE TABLE StudentProfile
(
    StudentId INT NOT NULL PRIMARY KEY, -- primary key column
    FirstName [NVARCHAR](50) NOT NULL,
    LastName [NVARCHAR](50) NOT NULL,
    GradePointAverage FLOAT,
    EntranceExamScore INT,
    PlacementSchoolId INT
    -- specify more columns here
);
GO
ALTER TABLE StudentProfile 
ADD PlacementSchoolId int;

CREATE TABLE School
(
    SchoolId INT NOT NULL PRIMARY KEY,
    SchoolName [NVARCHAR](50) NOT NULL,
    MinimiumTestScore INT,
    NumSeats INT,
    MinimiumGpa FLOAT
);
GO

CREATE TABLE StudentSchoolChoice
(
    StudentSchoolChoiceId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    StudentId INT NOT NULL,
    SchoolId INT NOT NULL,
    Rank INT NOT NULL
);
go
