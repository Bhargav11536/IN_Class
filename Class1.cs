using System;

namespace SchoolHierarchy
{
    class School
    {
        public string Name { get; set; }
        public string Principal { get; set; }
        public int StudentCount { get; set; }

        public School(string name, string principal, int studentCount)
        {
            Name = name;
            Principal = principal;
            StudentCount = studentCount;
        }

        public virtual string GetInfo()
        {
            return $"School Name: {Name}, Principal: {Principal}, Students: {StudentCount}";
        }
    }

   
    class MiddleSchool : School
    {
        public int LowestGrade { get; set; }
        public int HighestGrade { get; set; }

        public MiddleSchool(string name, string principal, int studentCount, int lowestGrade, int highestGrade)
            : base(name, principal, studentCount)
        {
            LowestGrade = lowestGrade;
            HighestGrade = highestGrade;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Grades: {LowestGrade}-{HighestGrade}";
        }
    }

    // HighSchool subclass
    class HighSchool : School
    {
        public string SportsFieldName { get; set; }

        public HighSchool(string name, string principal, int studentCount, string sportsFieldName)
            : base(name, principal, studentCount)
        {
            SportsFieldName = sportsFieldName;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Sports Field: {SportsFieldName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MiddleSchool middleSchool = new MiddleSchool("Lincoln Middle School", "Mr. Johnson", 600, 6, 8);
            HighSchool highSchool = new HighSchool("Roosevelt High School", "Mrs. Smith", 1200, "Roosevelt Field");

            Console.WriteLine(middleSchool.GetInfo());
            Console.WriteLine(highSchool.GetInfo());
        }
    }
}