using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USecology_project.Models;
using USecology_project.Views;
using Xamarin.Forms;

namespace USecology_project.ViewModels
{
	public class ShowViewModel:INotifyPropertyChanged
	{
		public int ShowId { get; set; }
		public string ShowName { get; set; }
		public string ShowAddress { get; set; }
		public string ShowState { get; set; }
		public string ShowPhone { get; set; }

		private ObservableCollection<EntryModel> viewData = new ObservableCollection<EntryModel>();

		
		public ObservableCollection<EntryModel> ViewData
		{
			get { return viewData; }
			set
			{
				viewData = value;
				OnPropertyChanged("ViewData");
			}
		}
		public ShowViewModel(INavigation navigation)
		{
			//ViewData = _ViewData;
			Navigation = navigation;
		}
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string PropertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
		}
		public INavigation Navigation;

		public void ViewMethod()
		{
			try
			{
				EntryModel entrymodel = new EntryModel();

				ViewData = App.Instance.database.GetAllData();

				//App.Instance.showentrypage = new ShowEntryPage();


			}
			catch (Exception e) { }
		}
	}
}
