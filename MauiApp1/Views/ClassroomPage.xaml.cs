using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class ClassroomPage : ContentPage
{
	ClassroomViewModel crvm;
	public ClassroomPage()
	{
		crvm = new ClassroomViewModel();
        crvm.AssignTeacher("Joan", "Jett", "teacher.jpg");

        crvm.AddNewStudent("John", "Smith", "student1.jpg");
        crvm.AddNewStudent("Sally", "Hale", "student2.jpg");
        crvm.AddNewStudent("Janet", "Reno", "student3.jpg");
        crvm.AddNewStudent("Cary", "Baer", "student4.jpg");

		crvm.AddNewCourse("Algebra", 11, ConvertStringToTime("09:00:00"), 60, "Math");
        crvm.AddNewCourse("Creative Writing", 10, ConvertStringToTime("09:00:00"), 60, "English");
        crvm.AddNewCourse("Biology 2", 11, ConvertStringToTime("09:00:00"), 60, "Science");
        crvm.RoomNumber = "212";
		InitializeComponent();
		BindingContext = crvm;
        
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        collStudents.ItemsSource = crvm.Students;
        collCourses.ItemsSource = crvm.Courses; 
    }

    DateTime ConvertStringToTime(string time)
    {
       // string Time = "16:23:01";
        DateTime res = DateTime.ParseExact(time, "hh:mm:ss", System.Globalization.CultureInfo.CurrentCulture);
        return res;
    }

    private async void btnAssignTeacher_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AssignTeacherPage(crvm));

    }
}