using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USecology_project.Models;
using USecology_project.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace USecology_project.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShowEntryPage : ContentPage
	{
		public ShowViewModel showview;
		
		public ShowEntryPage()
		{

			InitializeComponent();
			BindingContext = showview = new ShowViewModel(Navigation);

		}
		protected override void OnAppearing()
		{
			try
			{
				base.OnAppearing();
				showview.ViewMethod();
			}
			catch(Exception e)
			{

			}
		}

		
	}
}