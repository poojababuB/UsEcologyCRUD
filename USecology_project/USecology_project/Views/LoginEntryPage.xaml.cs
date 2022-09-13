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
		//List<string> state = new List<string>();
		public LoginEntryPage()
		{
			InitializeComponent();
			//state.Add("Tamilnadu");
			BindingContext =new EntryViewModel(Navigation);


			

		}

	}
		
	
}