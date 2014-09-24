package monodroid.datepickersample;


public class Activity1
	extends android.app.Activity
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateDialog:(I)Landroid/app/Dialog;:GetOnCreateDialog_IHandler\n" +
			"";
		mono.android.Runtime.register ("MonoDroid.DatePickerSample.Activity1, MonoDroid.DatePickerSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Activity1.class, __md_methods);
	}

	public Activity1 ()
	{
		super ();
		if (getClass () == Activity1.class)
			mono.android.TypeManager.Activate ("MonoDroid.DatePickerSample.Activity1, MonoDroid.DatePickerSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	@Override
	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	@Override
	public android.app.Dialog onCreateDialog (int p0)
	{
		return n_onCreateDialog (p0);
	}

	private native android.app.Dialog n_onCreateDialog (int p0);

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
