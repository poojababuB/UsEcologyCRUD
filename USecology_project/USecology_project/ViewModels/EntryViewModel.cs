using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using USecology_project.Models;
using USecology_project.Views;
using Xamarin.Forms;

namespace USecology_project.ViewModels
{
	public class EntryViewModel : INotifyPropertyChanged
	{
		public int ModelId { get; set; }
		public string ModelName { get; set; }
		public string ModelAddress { get; set; }
		public string ModelState { get; set; }
		public string ModelPhone { get; set; }

		private ObservableCollection<EntryModel> modelSql = new ObservableCollection<EntryModel>();

		public ObservableCollection<EntryModel> ModelSql
		{
			get { return modelSql; }
			set
			{
				modelSql = value;
			}
		}
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string PropertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
		}
		public ICommand submit { get; set; }
		public INavigation Navigation;
		public EntryViewModel(INavigation navigation)
		{
			try
			{

				Navigation = navigation;
				submit = new Command(AddMethod);


			}
			catch (Exception) { }
		}
		private void AddMethod(object obj)
		{
			try
			{
				if (!string.IsNullOrEmpty(ModelName) && !string.IsNullOrEmpty(ModelAddress) && !string.IsNullOrEmpty(ModelState) && !string.IsNullOrEmpty(ModelPhone))
				{
					EntryModel post = new EntryModel();
					post.Id = ModelId;
					post.Name = ModelName;
					post.Address = ModelAddress;
					post.State = ModelState;
					post.Phone = ModelPhone;

					App.Instance.database.InsertData(post);
					ModelSql.Add(post);
					Application.Current.MainPage.DisplayAlert("Success!", "Data Added Successfully", "Ok", "Cancel");
					
				}

				
				else
				{
					Application.Current.MainPage.DisplayAlert("ALERT!", "Please Fill All Details", "Ok", "Cancel");
				}
			}
			catch (Exception ex)
			{

			}
		}
		//public void ViewMethod()
		//{
		//	try
		//	{
		//		EntryModel sqlliteModel = new EntryModel();

		//		var clue = App.Instance.database.GetAllData();

		//		App.Instance.entrypage = new ShowEntryPage(clue);


		//	}
		//	catch (Exception e) { }
		//}
	}
}
