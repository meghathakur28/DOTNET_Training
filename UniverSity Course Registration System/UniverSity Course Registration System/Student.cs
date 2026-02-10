using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Student Class
    // =========================
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public int MaxCredits { get; private set; }

        public List<string> CompletedCourses { get; private set; }
        public List<Course> RegisteredCourses { get; private set; }

        public Student(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            StudentId = id;
            Name = name;
            Major = major;
            MaxCredits = maxCredits;
            CompletedCourses = completedCourses ?? new List<string>();
            RegisteredCourses = new List<Course>();
        }

        public int GetTotalCredits()
        {
            int sum = 0;
            foreach (var course in RegisteredCourses)
            {
                sum += course.Credits;
            }
            return sum; 
        }

        public bool CanAddCourse(Course course)
        {
            // TODO:
            // 1. Course should not already be registered
            if (RegisteredCourses.Contains(course))
            { return false; }
            // 2. Total credits + course credits <= MaxCredits
            if(course.Credits+GetTotalCredits()<=MaxCredits)
            {
                foreach(var pre in course.Prerequisites)
                {
                    if(!CompletedCourses.Contains(pre))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool AddCourse(Course course)
        {
            // TODO:
            // 1. Call CanAddCourse
            if (CanAddCourse(course) == true)
            {
                if(!course.IsFull())
                {
                    RegisteredCourses.Add(course);
                    course.EnrollStudent();
                    return true;
                }
            }
            return false;
        }

        public bool DropCourse(string courseCode)
        {
            Course course = RegisteredCourses.Find(x => x.CourseCode == courseCode);
            if(course==null)
            {
                return false;
            }
            RegisteredCourses.Remove(course);
            course.DropStudent();
            return true;
        }

        public void DisplaySchedule()
        {
            if(RegisteredCourses.Count==0)
            {
                Console.WriteLine("There is no course registered");
                return;
            }
            foreach(var i in RegisteredCourses)
            {
                Console.WriteLine($"{i.CourseCode},{i.CourseName}, {i.Credits} ");
            }
        }
    }
}
