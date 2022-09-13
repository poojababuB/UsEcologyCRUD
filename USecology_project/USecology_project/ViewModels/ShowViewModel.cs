using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using USecology_project.Models;
using USecology_project.Views;
using Xamarin.Forms;

namespace USecology_project.ViewModels
{
	public class ShowViewModel:INotifyPropertyChanged
	{
		#region[Properties]
		public int ShowId { get; set; }
		public string ShowName { get; set; }
		public string ShowAddress { get; set; }
		public string ShowState { get; set; }
		public string ShowPhone { get; set; }
		#endregion

		private ObservableCollection<EntryModel> viewData = new ObservableCollection<EntryModel>();
		#region[RefreshList]
		public async Task Delete(EntryModel model)
		{
			var index = viewData.Where(x => x.Id == model.Id).FirstOrDefault();
			var ind = viewData.IndexOf(index);
			viewData.RemoveAt(ind);
			viewData.Remove(model);
		}

		public async Task RefreshList(EntryModel model)
		{
			//ViewData = App.Instance.database.GetAllData();
			var index = viewData.Where(x => x.Id == model.Id).FirstOrDefault();
			var ind = viewData.IndexOf(index);
			viewData.RemoveAt(ind);
			viewData.Add(model);
		}
		#endregion

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
			
			Navigation = navigation;
			Edititem = new Command(EditMethod);
		}
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string PropertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
		}
		public INavigation Navigation;
		public ICommand Edititem { get; set; }
		#region[Methods]
		public async Task ViewMethod()
		{
			try
			{
				EntryModel entrymodel = new EntryModel();

				ViewData = App.Instance.database.GetAllData();
			}
			catch (Exception e) { }
		}
		private void EditMethod(object obj)
		{
			try
			{
				var get = obj as EntryModel;

				Navigation.PushAsync(new EditListItem(get));
			}
			catch (Exception) { }
		}

		#endregion
	}
}
