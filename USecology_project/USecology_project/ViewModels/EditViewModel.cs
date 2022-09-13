using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using USecology_project.Interface;
using USecology_project.Models;
using USecology_project.Views;
using Xamarin.Forms;

namespace USecology_project.ViewModels
{
	public class EditViewModel 
	{
		#region [Properties]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string State { get; set; }
		public string Phone { get; set; }

		
		public int StoreId { get; set; }
		public string StoreName { get; set; }
		public string StoreAddress { get; set; }
		public string StoreState { get; set; }
		public string StorePhone { get; set; }
		#endregion

		public EditViewModel(EntryModel entrydata, INavigation navigation)
		{
			
			Navigation = navigation;
			App.Instance.connection = DependencyService.Get<ISqlite>().GetSQLiteConnection();
			SaveAndUpdate = new Command(SaveAndUpdateMethod);
			Deleteitem = new Command(DeleteMethod);
			Id = entrydata.Id;
			Name = entrydata.Name;
			Address = entrydata.Address;
			State = entrydata.State;
			Phone = entrydata.Phone;
			

			StoreId = Id;
			StoreName = Name;
			StoreAddress = Address;
			StoreState = State;
			StorePhone = Phone;


		}
		public event PropertyChangedEventHandler PropertyChanged;
		

		public void OnPropertyChanged(string PropertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
		}
		public ICommand SaveAndUpdate { get; set; }
		public ICommand Deleteitem { get; set; }
		public INavigation Navigation;
		#region[Methods]
		private async void SaveAndUpdateMethod(object obj)
		{
			try
			{
				if (StoreName != Name || StoreAddress != Address||StoreState!=State||StorePhone!=Phone)
				{

					if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Address)&&!string.IsNullOrEmpty(State)&&!string.IsNullOrEmpty(Phone))
					{
						EntryModel sqlliteModel = new EntryModel();
						sqlliteModel.Id = Id;
						sqlliteModel.Name = Name;
						sqlliteModel.Address = Address;
						sqlliteModel.State = State;
						sqlliteModel.Phone = Phone;
						App.Instance.database.SaveUpdateData(sqlliteModel);
						await App.Instance.showentrypage.showview.RefreshList(sqlliteModel);
						await Navigation.PopAsync();
					}
					else
					{
						App.Current.MainPage.DisplayAlert("Alert!", "Please Fill All Details", "Ok", "Cancel");
					}
				}
				else
				{
					App.Current.MainPage.DisplayAlert("Alert!", "Please Change Any One Of The Value", "Ok", "Cancel");
				}

			}
			catch (Exception e)
			{

			}
		}
		private async void DeleteMethod(object obj)
		{
			try
			{
				EntryModel sqlliteModel = new EntryModel();
				sqlliteModel.Id = Id;
				sqlliteModel.Name = Name;
				sqlliteModel.Address = Address;
				sqlliteModel.State = State;
				sqlliteModel.Phone = Phone;
				App.Instance.database.DeleteItemData(sqlliteModel);
				await App.Instance.showentrypage.showview.Delete(sqlliteModel);
				App.Current.MainPage.DisplayAlert("Delete", "Deleted Successfully", "ok", "cancel");
				await Navigation.PopAsync();
			}
			catch (Exception e) { }
		}
		#endregion

	}
}
