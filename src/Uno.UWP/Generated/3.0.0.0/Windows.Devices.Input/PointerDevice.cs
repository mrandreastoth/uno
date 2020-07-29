#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Input
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class PointerDevice 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsIntegrated
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PointerDevice.IsIntegrated is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MaxContacts
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint PointerDevice.MaxContacts is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect PhysicalDeviceRect
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect PointerDevice.PhysicalDeviceRect is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property PointerDeviceType
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect ScreenRect
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect PointerDevice.ScreenRect is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Input.PointerDeviceUsage> SupportedUsages
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<PointerDeviceUsage> PointerDevice.SupportedUsages is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MaxPointersWithZDistance
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint PointerDevice.MaxPointersWithZDistance is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Input.PointerDevice.PointerDeviceType.get
		// Forced skipping of method Windows.Devices.Input.PointerDevice.IsIntegrated.get
		// Forced skipping of method Windows.Devices.Input.PointerDevice.MaxContacts.get
		// Forced skipping of method Windows.Devices.Input.PointerDevice.PhysicalDeviceRect.get
		// Forced skipping of method Windows.Devices.Input.PointerDevice.ScreenRect.get
		// Forced skipping of method Windows.Devices.Input.PointerDevice.SupportedUsages.get
		// Forced skipping of method Windows.Devices.Input.PointerDevice.MaxPointersWithZDistance.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Input.PointerDevice GetPointerDevice( uint pointerId)
		{
			throw new global::System.NotImplementedException("The member PointerDevice PointerDevice.GetPointerDevice(uint pointerId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Input.PointerDevice> GetPointerDevices()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<PointerDevice> PointerDevice.GetPointerDevices() is not implemented in Uno.");
		}
		#endif
	}
}
