package md5586b1744755cba23858f4bee2928231a;


public class TintedImageRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.ImageRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Plugin.CrossPlatformTintedImage.Android.TintedImageRenderer, Plugin.CrossPlatformTintedImage.Android", TintedImageRenderer.class, __md_methods);
	}


	public TintedImageRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == TintedImageRenderer.class)
			mono.android.TypeManager.Activate ("Plugin.CrossPlatformTintedImage.Android.TintedImageRenderer, Plugin.CrossPlatformTintedImage.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public TintedImageRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == TintedImageRenderer.class)
			mono.android.TypeManager.Activate ("Plugin.CrossPlatformTintedImage.Android.TintedImageRenderer, Plugin.CrossPlatformTintedImage.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public TintedImageRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == TintedImageRenderer.class)
			mono.android.TypeManager.Activate ("Plugin.CrossPlatformTintedImage.Android.TintedImageRenderer, Plugin.CrossPlatformTintedImage.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
