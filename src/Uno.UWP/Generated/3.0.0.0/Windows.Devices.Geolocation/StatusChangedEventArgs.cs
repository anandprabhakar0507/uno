#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Geolocation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class StatusChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Geolocation.PositionStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member PositionStatus StatusChangedEventArgs.Status is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Geolocation.StatusChangedEventArgs.Status.get
	}
}
