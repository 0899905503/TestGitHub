using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace OnTap
{
    class Chung
    {
        public string studentId { get; set; }
        public string courseId { get; set; }
        public int sectionIdentifier { get; set; }
    }
    class Student : Chung
    {
        public string name { get; set; }    
        public string major { get; set; }
        public Student(string name, string studentId, string major)
        {
            this.name = name;   
            this.studentId = studentId;
            this.major = major;
        }
        public void Output()
        {
           Console.WriteLine("Name : "+name + "  StudentId : " + studentId + " Major : "+major);
        }
    }
    class Course : Chung
    {
        public string courseName { get; set; }
        public string department { get; set; }
        public Course(string courseName, string courseId ,string department)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.department = department;
        }
        public void Output()
        {
            Console.WriteLine("courseName : " + courseName + "  courseId : " + courseId + " department : " + department);
        }
    }
    class Section :Chung
    {
        public float year { get; set; }
        public Section(int sectionIdentifier,string  courseId, float year)
        {
            this.sectionIdentifier = sectionIdentifier;
            this.courseId=courseId;
            this.year = year;
        }
        public void Output()
        {
            Console.WriteLine("sectionIdentifier : " + sectionIdentifier + "  courseId : " + courseId + " year : " + year);
        }
    }
    class Gradereport :Chung 
    {
        public Section sectionIdentifier { get; set; }
        public string grade { get; set; }
        public Gradereport(string studentId, Section sectionIdentifier, string grade)
        {
            this.studentId = studentId;
            this.sectionIdentifier = sectionIdentifier;
            this.grade = grade;
        }
        public void Output()
        {
            Console.WriteLine("studentId : " + studentId + "  sectionIdentifier : " + sectionIdentifier + "  grade : " + grade);
        }
    }
    class Prerequisite : Chung
    {
        public string prerequisiteId { get; set; }
        public Prerequisite(string courseId, string prerequisiteId)
        {
            this.courseId = courseId;
            this.prerequisiteId = prerequisiteId;
        }
        public void Output()
        {
            Console.WriteLine("courseId : " + courseId + "  prerequisiteId : " + prerequisiteId);
        }
    }
    class Tester
    {
        static void Main()
        {
            Student a = new Student("Smith", "17", "cs");
            Student b = new Student("Brown", "8", "cs");
            a.Output();
            b.Output();
            Course a1 = new Course("Intro to Computer Science", "cs1310", "cs");
            Course a2 = new Course("Data structures", "cs3320", "cs");
            Course a3 = new Course("Discrete mathematics", "math2410", "math");
            Course a4 = new Course("Database", "cs3380", "cs");
            a1.Output();
            a2.Output();
            a3.Output();
            a4.Output();
            Section b1 = new Section(85, "math2410", 7 );
            Section b2 = new Section(92, "cs1310", 7 );
            Section b3 = new Section(102, "cs3320", 8);
            Section b4 = new Section(112, "math2410", 8 );
            Section b5 = new Section(119, "cs1310", 8);
            Section b6 = new Section(135, "cs3380", 8);
            b1.Output();
            b2.Output();
            b3.Output();
            b4.Output();
            b5.Output();
            b6.Output();
        }
    }
}