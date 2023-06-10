using MonkeyPhotosProject.ViewModel;
namespace MonkeyPhotosProject;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        this.BindingContext = vm;
        
    }
}




