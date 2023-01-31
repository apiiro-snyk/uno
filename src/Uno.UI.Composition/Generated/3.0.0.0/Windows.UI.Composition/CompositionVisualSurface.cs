#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionVisualSurface : global::Windows.UI.Composition.CompositionObject,global::Windows.UI.Composition.ICompositionSurface
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.Visual SourceVisual
		{
			get
			{
				throw new global::System.NotImplementedException("The member Visual CompositionVisualSurface.SourceVisual is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Visual%20CompositionVisualSurface.SourceVisual");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionVisualSurface", "Visual CompositionVisualSurface.SourceVisual");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector2 SourceSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionVisualSurface.SourceSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Vector2%20CompositionVisualSurface.SourceSize");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionVisualSurface", "Vector2 CompositionVisualSurface.SourceSize");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector2 SourceOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionVisualSurface.SourceOffset is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Vector2%20CompositionVisualSurface.SourceOffset");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionVisualSurface", "Vector2 CompositionVisualSurface.SourceOffset");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionVisualSurface.SourceVisual.get
		// Forced skipping of method Windows.UI.Composition.CompositionVisualSurface.SourceVisual.set
		// Forced skipping of method Windows.UI.Composition.CompositionVisualSurface.SourceOffset.get
		// Forced skipping of method Windows.UI.Composition.CompositionVisualSurface.SourceOffset.set
		// Forced skipping of method Windows.UI.Composition.CompositionVisualSurface.SourceSize.get
		// Forced skipping of method Windows.UI.Composition.CompositionVisualSurface.SourceSize.set
		// Processing: Windows.UI.Composition.ICompositionSurface
	}
}
