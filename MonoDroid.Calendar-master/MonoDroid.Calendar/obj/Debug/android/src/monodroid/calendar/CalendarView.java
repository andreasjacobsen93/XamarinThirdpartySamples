package monodroid.calendar;


public class CalendarView
	extends android.widget.ImageView
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"";
		mono.android.Runtime.register ("MonoDroid.Calendar.CalendarView, MonoDroid.Calendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CalendarView.class, __md_methods);
	}

	public CalendarView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CalendarView.class)
			mono.android.TypeManager.Activate ("MonoDroid.Calendar.CalendarView, MonoDroid.Calendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}

	public CalendarView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CalendarView.class)
			mono.android.TypeManager.Activate ("MonoDroid.Calendar.CalendarView, MonoDroid.Calendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0, p1 });
	}

	public CalendarView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CalendarView.class)
			mono.android.TypeManager.Activate ("MonoDroid.Calendar.CalendarView, MonoDroid.Calendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}

	@Override
	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);

	java.util.ArrayList refList;
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
