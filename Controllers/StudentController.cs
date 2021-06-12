using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HighSchoolSelector.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        public StudentController()
        {

        }

        [HttpGet]
        public StudentProfile Get()
        {
            return new StudentProfile
            {
                Id = 100,
                EntranceExamScore = 93,
                FirstName = "Toe",
                LastName = "Moss",
                GradePointAverage = 3.2,
                PlacementSchool = new School
                {
                    Id = 1,
                    MinimiumGpa = 2.5,
                    MinimiumTestScore = 85,
                    NumSeats = 400,
                    SchoolName = "Boerum Hill School For International Studies"

                }
            };
        }
    }
}