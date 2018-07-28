namespace Blazor.Universal.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            LoadApplication(new Universal.App());
        }
    }
}
