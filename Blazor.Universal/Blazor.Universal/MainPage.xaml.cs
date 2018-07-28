using Xamarin.Forms;

namespace Blazor.Universal
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		    Startup.BlazorInitialized += () => Device.BeginInvokeOnMainThread(() => WebView.Source = "http://localhost:55300/");
		}
	}
}
