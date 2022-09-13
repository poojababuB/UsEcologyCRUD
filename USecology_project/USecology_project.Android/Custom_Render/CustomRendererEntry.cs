using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using USecology_project.Custom;
using USecology_project.Droid.Custom_Render;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomRendererEntry))]
namespace USecology_project.Droid.Custom_Render
{
	public class CustomRendererEntry:EntryRenderer
	{
		public CustomRendererEntry(Context context) : base(context)
		{

		}
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
				Control.SetHeight(100);
				Control.SetWidth(500);
				
			}
		}
	}
}