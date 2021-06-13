use sandbox;
insert into StudentProfile (StudentId, FirstName,LastName,GradePointAverage,EntranceExamScore)
values (1,'Toe','Moss',3.4,99);

insert into StudentProfile (StudentId, FirstName,LastName,GradePointAverage,EntranceExamScore)
values (2,'And','Rew',1.0,22);

insert into School (SchoolId, SchoolName, MinimiumTestScore, NumSeats, MinimiumGpa)
values (1, 'Boerum Hill For International Studies', 85, 400, 2.5)

insert into StudentSchoolChoice (StudentId, SchoolId, Rank)
values (1, 1, 1);