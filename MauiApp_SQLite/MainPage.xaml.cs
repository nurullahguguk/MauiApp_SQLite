namespace MauiApp_SQLite;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
        Stu_List_View.ItemsSource = App.DbTrans.GetAllStudents();
    }

    private void Btn_Add_Clicked(object sender, EventArgs e)
    {
        App.DbTrans.Add(new Models.Student
        {
            Name = Stu_Name.Text,
            Department=Stu_Dept.Text,
        }); 
        Stu_List_View.ItemsSource=App.DbTrans.GetAllStudents();
    }


    private void Btn_Delete_Clicked(object sender, EventArgs e)
    {
        Button button =(Button)sender;
        App.DbTrans.Delete((int)button.BindingContext);
        Stu_List_View.ItemsSource = App.DbTrans.GetAllStudents();
    }

    private void Btn_Show_Clicked(object sender, EventArgs e)
    {
        Stu_List_View.ItemsSource=App.DbTrans.GetAllStudents();
    }
}

