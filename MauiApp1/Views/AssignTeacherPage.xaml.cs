using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class AssignTeacherPage : ContentPage
{
    ClassroomViewModel crvm;

    public AssignTeacherPage(ClassroomViewModel _crvm)
	{
		InitializeComponent();
        crvm = _crvm;
	}

    private async void btnOK_Clicked(object sender, EventArgs e)
    {
        crvm.Teacher.FirstName = entryFirstName.Text;
        crvm.Teacher.LastName = entryLastName.Text;
        crvm.Teacher.Thumbnail = entryFilename.Text;
        await Navigation.PopModalAsync(true);
    }

    private async void btnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync(true);
    }
}