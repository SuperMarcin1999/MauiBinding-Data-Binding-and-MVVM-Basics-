namespace MauiBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new PersonPageViewModel();
        }
    }

}
