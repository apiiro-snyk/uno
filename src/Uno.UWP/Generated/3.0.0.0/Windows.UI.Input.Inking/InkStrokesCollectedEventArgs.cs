#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Inking
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkStrokesCollectedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.InkStroke> Strokes
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<InkStroke> InkStrokesCollectedEventArgs.Strokes is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CInkStroke%3E%20InkStrokesCollectedEventArgs.Strokes");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Input.Inking.InkStrokesCollectedEventArgs.Strokes.get
	}
}
