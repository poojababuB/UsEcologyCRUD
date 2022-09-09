package crc641604e781815c1990;


public class CustomRendere_Entry
	extends crc643f46942d9dd1fff9.EntryRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("USecology_project.Droid.Custom_Render.CustomRendere_Entry, USecology_project.Android", CustomRendere_Entry.class, __md_methods);
	}


	public CustomRendere_Entry (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomRendere_Entry.class)
			mono.android.TypeManager.Activate ("USecology_project.Droid.Custom_Render.CustomRendere_Entry, USecology_project.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public CustomRendere_Entry (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomRendere_Entry.class)
			mono.android.TypeManager.Activate ("USecology_project.Droid.Custom_Render.CustomRendere_Entry, USecology_project.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomRendere_Entry (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomRendere_Entry.class)
			mono.android.TypeManager.Activate ("USecology_project.Droid.Custom_Render.CustomRendere_Entry, USecology_project.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
