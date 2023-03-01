using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.DataTemplates
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavigationViewTemplatexaml : ContentView
    {
		public NavigationViewTemplatexaml ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            try
            {
                Shell.Current.FlyoutIsPresented = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}