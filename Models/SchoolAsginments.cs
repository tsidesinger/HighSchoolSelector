using System;
using System.Collections.Generic;

namespace HighSchoolSelector
{
    public class SchoolAsignments
    {
        public IDictionary<int, StudentProfile> WaitList => 
          new SortedDictionary<int, StudentProfile>();

        public IEnumerable<StudentProfile> StudentList { get; set; } =
         new List<StudentProfile>();

        public int SchoolId { get; set; }
    }
}      