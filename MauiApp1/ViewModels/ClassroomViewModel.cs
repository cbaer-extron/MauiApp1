using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public partial class ClassroomViewModel
    {

        public List<PersonModel> Students { get; set; }
        public PersonModel Teacher { get; set; }
        public List<CourseModel> Courses { get; set; }
        public string RoomNumber { get; set; }

        public ClassroomViewModel()
        {
            Students = new List<PersonModel>();
            Teacher = new PersonModel();
            Courses = new List<CourseModel>();  

        }


        public void AddNewStudent(string FirstName, string LastName, string StudentImage)
        {

            Students.Add(new PersonModel { FirstName = FirstName, LastName = LastName, Thumbnail = StudentImage });

        }
        public void AddNewCourse(string Name, int Grade, DateTime StartTime, int Duration, string Subject )
        {

            Courses.Add(new CourseModel { Name = Name, Grade = Grade, StartTime = StartTime, Duration = Duration, Subject = Subject });

        }

        public void AssignTeacher(string FirstName, string LastName, string TeacherImage)
        {
            Teacher.FirstName = FirstName;
            Teacher.LastName = LastName;
            Teacher.Thumbnail = TeacherImage;
        }

    }
}

