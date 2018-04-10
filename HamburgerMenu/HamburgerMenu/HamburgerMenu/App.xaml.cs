using HamburgerMenu.Views;
using Xamarin.Forms;

namespace HamburgerMenu
{
    public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}
	}
}