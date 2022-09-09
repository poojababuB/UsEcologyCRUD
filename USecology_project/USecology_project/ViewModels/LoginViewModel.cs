using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using USecology_project.Views;
using Xamarin.Forms;

namespace USecology_project.ViewModels
{
	public class LoginViewModel: INotifyPropertyChanged
	{
		public INavigation Navigation;
		
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged(string PropertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
		}

		
		public ICommand LoginCommand { get; set; }
		

		public LoginViewModel(INavigation navigation)
		{
			Navigation = navigation;
			LoginCommand = new Command(validationMethod);
		}
		private void validationMethod(object obj)
		{
			try
			{

				Navigation.PushAsync(new PackBack());
			}
			catch (Exception e) { }
		}
	}
}
