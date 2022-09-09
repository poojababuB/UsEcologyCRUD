using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace USecology_project.Models
{
	public class EntryModel
	{
		[PrimaryKey]
		[AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string State { get; set; }
		[MaxLength(10)]
		public string Phone { get; set; }
	}
}
