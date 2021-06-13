use sandbox;
insert into StudentProfile (StudentId, FirstName,LastName,GradePointAverage,EntranceExamScore, PlacementSchoolId)
values (1,'Toe','Moss',3.4,99, 1);

insert into StudentProfile (StudentId, FirstName,LastName,GradePointAverage,EntranceExamScore, PlacementSchoolId)
values (2,'And','Rew',1.0,22, 1);

insert into School (SchoolId, SchoolName, MinimiumTestScore, NumSeats, MinimiumGpa)
values (1, 'Boerum Hill For International Studies', 85, 400, 2.5)

<<<<<<< HEAD
insert into StudentSchoolChoice (StudentSchoolChoiceId, StudentId, SchoolId, Rank)
values (1, 1, 1, 1);

UPDATE School
SET MinimiumTestScore = 84, MinimiumGpa = 2.4, NumSeats = 399
WHERE schoolId=1;
=======
insert into StudentSchoolChoice (StudentId, SchoolId, Rank)
values (1, 1, 1);
>>>>>>> 14cde6cc122c5f6205ba69de97dd544e9503231c
