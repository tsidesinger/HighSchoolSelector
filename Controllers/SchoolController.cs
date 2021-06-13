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
    public class SchoolController : ControllerBase
    {
        private IConfiguration _configuration;

        public SchoolController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPut]
        public void Put(int minimiumTestScore, float minimiumGpa, int numSeats, int schoolId)
        {
            using (var connection = new SqlConnection(_configuration["HighSchoolSettings:ConnectionString"]))
            {
                connection.Execute("UPDATE School SET MinimiumTestScore=@minimiumTestScore, MinimiumGpa=@minimiumGpa, NumSeats=@numSeats WHERE schoolId=@schoolId", 
                new {minimiumTestScore, minimiumGpa, numSeats, schoolId});
            }
        }

        [HttpGet]
        public SchoolAsignments GetAssignedStudents(int schoolId)
        {
            using (var connection = new SqlConnection(_configuration["HighSchoolSettings:ConnectionString"]))
            {
                var studentList = connection.Query<StudentProfile>("select * from StudentProfile where PlacementSchoolId=@schoolId", new { schoolId });
                var schoolAsignments = new SchoolAsignments { SchoolId = schoolId, StudentList = studentList };
                return schoolAsignments;
            }
        }
    }
}