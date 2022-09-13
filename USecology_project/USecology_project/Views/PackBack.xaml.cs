using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace USecology_project.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PackBack : TabbedPage
	{
		public PackBack()
		{
			InitializeComponent();
			App.Instance.showentrypage = new ShowEntryPage();
			App.Instance.loginentrypage = new LoginEntryPage();
			var showpage = new NavigationPage(App.Instance.showentrypage);
			var navpage = new NavigationPage(App.Instance.loginentrypage);
			navpage.Title = "UserEntry";
			navpage.IconImageSource = "Entry.png";
			showpage.Title = "ListView";
			showpage.IconImageSource = "ListShow.png";
			this.Children.Add(navpage);
			this.Children.Add(showpage);
		}
	}
}