using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using USecology_project.Models;
using USecology_project.Views;
using Xamarin.Forms;

namespace USecology_project.ViewModels
{
	public class EntryViewModel : INotifyPropertyChanged
	{
		#region[Properties]
		private int modelId { get; set; }
		private string modelName { get; set; }
		private string modelAddress { get; set; }
		private string modelState { get; set; }
		private string modelPhone { get; set; }

		public int ModelId 
		{ 
			get { return modelId; } 
			set { 
				modelId = value;
				OnPropertyChanged("ModelId");
					}
		}

		public string ModelName
		{
			get { return modelName; }
			set
			{
				modelName = value;
				OnPropertyChanged("ModelName");
			}
		}

		public string ModelAddress
		{
			get { return modelAddress; }
			set
			{
				modelAddress = value;
				OnPropertyChanged("ModelAddress");
			}
		}

		public string ModelState
		{
			get { return modelState; }
			set
			{
				modelState = value;
				OnPropertyChanged("ModelState");
			}
		}
		public string ModelPhone
		{
			get { return modelPhone; }
			set
			{
				modelPhone = value;
				OnPropertyChanged("ModelPhone");
			}
		}
		#endregion

		private ObservableCollection<EntryModel> modelSql = new ObservableCollection<EntryModel>();

		public ObservableCollection<EntryModel> ModelSql
		{
			get { return modelSql; }
			set
			{
				modelSql = value;
				OnPropertyChanged("ModelSql");

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
		#region[Methods]
		async void AddMethod(object obj)
		{
			try
			{
				if (!string.IsNullOrEmpty(ModelName) && !string.IsNullOrEmpty(ModelAddress) && !string.IsNullOrEmpty(ModelState) && !string.IsNullOrEmpty(ModelPhone))
				{
					EntryModel post = new EntryModel();
					//post.Id = ModelId;
					post.Name = ModelName;
					post.Address = ModelAddress;
					post.State = ModelState;
					post.Phone = ModelPhone;

					App.Instance.database.InsertData(post);
					ModelSql.Add(post);
					bool answer = await Application.Current.MainPage.DisplayAlert("Success!", "Data Added Successfully", "Ok", "Cancel");
					
					
					await App.Instance.showentrypage.showview.ViewMethod();
					if (answer)
					{
						ModelName = string.Empty;
						ModelAddress = string.Empty;
						ModelState = string.Empty;
						ModelPhone = string.Empty;
					}

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
		#endregion
	}
}
