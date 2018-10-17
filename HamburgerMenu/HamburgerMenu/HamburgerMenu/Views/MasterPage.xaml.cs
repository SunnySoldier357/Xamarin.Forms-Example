using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HamburgerMenu.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
        public ListView ContentPane { get { return contentPane; } }

        public MasterPage()
		{
			InitializeComponent();
		}
	}
}