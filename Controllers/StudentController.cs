using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace HighSchoolSelector.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private IConfiguration _configuration;

        public StudentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public StudentProfile Get(int studentId)
        {
            using (var connection = new SqlConnection(_configuration["HighSchoolSettings:ConnectionString"]))
            {
                var student = connection.QuerySingle<StudentProfile>("select * from StudentProfile where StudentId=@studentId", new {studentId});
                var choices = connection.Query<School>("select * from StudentSchoolChoice c inner join School s on c.schoolId = s.schoolId where studentId=@studentId order by c.Rank asc", new {studentId}); 
                student.SchoolRankings = choices;
                return student;
            }
            
            // return new StudentProfile
            // // {
            //     Id = 100,
            //     EntranceExamScore = 93,
            //     FirstName = "Toe",
            //     LastName = "Moss",
            //     GradePointAverage = 3.2,
            //     PlacementSchool = new School
            //     {
            //         Id = 1,
            //         MinimiumGpa = 2.5,
            //         MinimiumTestScore = 85,
            //         NumSeats = 400,
            //         SchoolName = "Boerum Hill School For International Studies"

            //     }
            // };
        }

        [HttpPost]
        public void PostSchoolChoices(int studentId, IEnumerable<int> choices) 
        {
            using (var connection = new SqlConnection(_configuration["HighSchoolSettings:ConnectionString"]))
            {
                connection.Execute("DELETE FROM StudentSchoolChoice where studentId=@studentId", new { studentId});
                for(var i = 0; i < choices.Count(); i++)
                {
                    connection.Execute("insert into StudentSchoolChoice (StudentId, SchoolId, Rank) values (@studentId, @schoolId, @rank)",
                     new {studentId, schoolId = choices.ToList()[i], rank = i+1 });
                } 
            }
        }
    }
}