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
    public class DistrictController : ControllerBase
    {
        private IConfiguration _configuration;
        private PlacementGenerator _placementGenerator;

        public DistrictController(IConfiguration configuration)
        {
            _configuration = configuration;
            _placementGenerator = new PlacementGenerator();
        }

        [HttpGet]
        public IEnumerable<School> GetAllSchools()
        {
            using (var connection = new SqlConnection(_configuration["HighSchoolSettings:ConnectionString"]))
            {
                var schools = connection.Query<StudentProfile>("select * from School");
                return schools;
            }
        }

        [HttpGet]
        public IEnumerable<School> GetTentitivePlacements()
        {
            return _placementGenerator.CalculatePlacements();
        }

        [HttpPost]
        public void SetPlacements()
        {
            return _placementGenerator.SavePlacements();
        }
    }
}