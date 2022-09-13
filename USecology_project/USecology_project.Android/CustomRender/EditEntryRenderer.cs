using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using USecology_project.Custom;
using USecology_project.Droid.CustomRender;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EditEntry), typeof(EditEntryRenderer))]
namespace USecology_project.Droid.CustomRender
{
	public class EditEntryRenderer : EntryRenderer
	{
		public EditEntryRenderer(Context context) : base(context)
		{

		}
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				
				Control.SetHeight(150);
				Control.SetWidth(500);

			}
		}
	}
}