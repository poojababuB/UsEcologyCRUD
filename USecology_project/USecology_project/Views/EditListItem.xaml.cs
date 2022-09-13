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
	public partial class EditListItem : ContentPage
	{
		public EditListItem(EntryModel entryModel)
		{
			InitializeComponent();
			BindingContext = new EditViewModel(entryModel, Navigation);
		}
	}
}