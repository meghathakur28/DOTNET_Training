using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            if (AvailableCourses.ContainsKey(code))
            {
                throw new ArgumentException();
            }
            Course course = new Course(code, name, credits, maxCapacity, prerequisites);

            // 2. Create Course object
            // 3. Add to AvailableCourses
            AvailableCourses.Add(code, course);
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            if (Students.ContainsKey(id))
            {
                throw new ArgumentException();
            }
            // 2. Create Student object
            Student student = new Student(id,name, major, maxCredits, completedCourses);
            Students.Add(id,student);
            // 3. Add to Students dictionary
            throw new NotImplementedException();
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
             if(Students.ContainsKey(studentId)&&AvailableCourses.ContainsKey(courseCode))
            {
                Student student = Students[studentId];
                Course course = AvailableCourses[courseCode];
                student.AddCourse(course);
                return true;
            }
            return false;
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            if (Students.ContainsKey(studentId) && AvailableCourses.ContainsKey(courseCode))
            {
                Student student = Students[studentId];
                Course course = AvailableCourses[courseCode];
                student.DropCourse(courseCode);
                return true;
            }
            return false;
        }

        public void DisplayAllCourses()
        {
            // TODO:
            foreach(var i in AvailableCourses)
            {
                Course course = i.Value;
                Console.WriteLine($"{course.CourseCode}, {course.CourseName}, {course.Credits},{course.GetEnrollmentInfo}");
            }
            // Display course code, name, credits, enrollment info\
        }

        public void DisplayStudentSchedule(string studentId)
        {
            // TODO:
            // Validate student existence
            if(Students.ContainsKey(studentId))
            {
                Student student = Students[studentId];
                student.DisplaySchedule();
            }
            // Call student.DisplaySchedule()
        }

        public void DisplaySystemSummary()
        {
            // TODO:
            // Display total students, total courses, average enrollment
            Console.WriteLine($"{Students.Count}, {AvailableCourses.Count}");
        }
    }
}
