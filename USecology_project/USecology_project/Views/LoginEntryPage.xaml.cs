using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USecology_project.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace USecology_project.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginEntryPage : ContentPage
	{
		
		public LoginEntryPage()
		{
			InitializeComponent();
			
			BindingContext =new EntryViewModel(Navigation);


			

		}

	}
		
	
}