using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USecology_project.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace USecology_project
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
			BindingContext = new LoginViewModel(Navigation);
		}

		
	}
}