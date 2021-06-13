use sandbox;
SELECT * from StudentProfile where studentid = 1;

SELECT * FROM School;

DELETE FROM StudentProfile;

DELETE FROM School;

SELECT * FROM StudentSchoolChoice;

SELECT * FROM StudentProfile s left outer join 
StudentSchoolChoice c on s.StudentId = c.StudentId 
 left outer join School sc on c.SchoolId = sc.SchoolId
where s.StudentId = 2

select * from StudentSchoolChoice c inner join School s 
on c.schoolId = s.schoolId where studentId=1 
order by c.Rank asc--@studentId

select * from StudentProfile where PlacementSchoolId=1--=@schoolId



-- Delete rows from table 'School'
