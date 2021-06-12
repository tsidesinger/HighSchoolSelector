using System;
using System.Collections.Generic;
namespace HighSchoolSelector
{
    public class StudentProfile
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int EntranceExamScore { get; set; }

        public double GradePointAverage { get; set; }

        public IEnumerable<School> SchoolRankings { get; set; }

        public School PlacementSchool { get; set; }

        // public List<WaitListSchool> WaitList { get; set; }
    }
}
