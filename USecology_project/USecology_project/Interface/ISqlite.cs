using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace USecology_project.Interface
{
	public interface ISqlite
	{
		SQLiteConnection GetSQLiteConnection();
	}
}
