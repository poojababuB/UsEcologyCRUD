using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using USecology_project.Droid.Services;
using USecology_project.Interface;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqliteService))]
namespace USecology_project.Droid.Services
{
	public class SqliteService : ISqlite
	{
		public SQLiteConnection GetSQLiteConnection()
		{
			var database = "MyDatabase";
			var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
			var combine = Path.Combine(path, database);
			var connect = new SQLiteConnection(combine);
			return connect;
		}
	}
}