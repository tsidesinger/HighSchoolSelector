use sandbox;

-- Create the table in the specified schema
CREATE TABLE StudentProfile
(
    StudentId INT NOT NULL PRIMARY KEY, -- primary key column
    FirstName [NVARCHAR](50) NOT NULL,
    LastName [NVARCHAR](50) NOT NULL,
    GradePointAverage FLOAT,
    EntranceExamScore INT
    -- specify more columns here
);
GO