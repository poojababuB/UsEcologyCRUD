using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using USecology_project.Models;

namespace USecology_project.Helper
{
	public class AppDB
	{
		public SQLiteConnection connection = null;

		public ObservableCollection<EntryModel> ModelSql { get; private set; }

		public AppDB(string DBname)
		{
			connection = new SQLiteConnection(DBname);
			connection.CreateTable<EntryModel>();
		}
		public void InsertData(EntryModel entryModel)
		{
			connection.Insert(entryModel);
		}

		public ObservableCollection<EntryModel> GetAllData()
		{
			var datas = new ObservableCollection<EntryModel>(connection.Table<EntryModel>().ToList());

			return datas;

		}

		public void DeleteItemData(EntryModel entryModel)
		{
			connection.Delete(entryModel);
		}

		public void SaveUpdateData(EntryModel entryModel)
		{
			connection.Update(entryModel);
		}

	}
}
