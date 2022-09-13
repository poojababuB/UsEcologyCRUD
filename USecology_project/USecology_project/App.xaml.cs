using SQLite;
using System;
using System.IO;
using USecology_project.Helper;
using USecology_project.Interface;
using USecology_project.Models;
using USecology_project.ViewModels;
using USecology_project.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace USecology_project
{
	public partial class App : Application
	{
		public AppDB database = null;
		public SQLiteConnection connection = null;
		public static App Instance = null;
		public ShowEntryPage showentrypage;
		public LoginEntryPage loginentrypage;
		public App()
		{
			InitializeComponent();
			database = new AppDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "UsEcologyProject.db3"));
			connection = DependencyService.Get<ISqlite>().GetSQLiteConnection();
			connection.CreateTable<EntryModel>();
			Instance = this;
			MainPage = new NavigationPage(new LoginPage());
			//showentrypage = new ShowEntryPage();
			
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
