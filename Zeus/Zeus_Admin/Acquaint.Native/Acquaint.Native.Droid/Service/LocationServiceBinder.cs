using System;
using Android.OS;

namespace Acquaint.Native.Droid
{
	//This is our Binder subclass, the LocationServiceBinder
	public class LocationServiceBinder : Binder
	{
		public LocationService Service
		{
			get { return this.service; }
		} protected LocationService service;

		public bool IsBound { get; set; }
			
		// constructor
		public LocationServiceBinder (LocationService service)
		{
			this.service = service;
		}
	}
}

