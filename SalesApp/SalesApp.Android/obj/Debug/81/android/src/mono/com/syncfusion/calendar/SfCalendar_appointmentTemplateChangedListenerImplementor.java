package mono.com.syncfusion.calendar;


public class SfCalendar_appointmentTemplateChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.syncfusion.calendar.SfCalendar.appointmentTemplateChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAppointmentTemplateChanged:(Lcom/syncfusion/calendar/AppointmentItem;)V:GetOnAppointmentTemplateChanged_Lcom_syncfusion_calendar_AppointmentItem_Handler:Com.Syncfusion.Calendar.SfCalendar/IAppointmentTemplateChangedListenerInvoker, Syncfusion.SfCalendar.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Calendar.SfCalendar+IAppointmentTemplateChangedListenerImplementor, Syncfusion.SfCalendar.Android", SfCalendar_appointmentTemplateChangedListenerImplementor.class, __md_methods);
	}


	public SfCalendar_appointmentTemplateChangedListenerImplementor ()
	{
		super ();
		if (getClass () == SfCalendar_appointmentTemplateChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Calendar.SfCalendar+IAppointmentTemplateChangedListenerImplementor, Syncfusion.SfCalendar.Android", "", this, new java.lang.Object[] {  });
	}


	public void onAppointmentTemplateChanged (com.syncfusion.calendar.AppointmentItem p0)
	{
		n_onAppointmentTemplateChanged (p0);
	}

	private native void n_onAppointmentTemplateChanged (com.syncfusion.calendar.AppointmentItem p0);

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
