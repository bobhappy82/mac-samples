// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace NeHeLesson7 {
	
	
	// Should subclass AppKit.NSWindow
	[Foundation.Register("MainWindow")]
	public partial class MainWindow {
	}
	
	// Should subclass AppKit.NSWindowController
	[Foundation.Register("MainWindowController")]
	public partial class MainWindowController {
		
		private MyOpenGLView __mt_openGLView;
		
		#pragma warning disable 0169
		[Foundation.Export("goFullScreen:")]
		partial void goFullScreen (Foundation.NSObject sender);

		[Foundation.Connect("openGLView")]
		private MyOpenGLView openGLView {
			get {
				this.__mt_openGLView = ((MyOpenGLView)(this.GetNativeField("openGLView")));
				return this.__mt_openGLView;
			}
			set {
				this.__mt_openGLView = value;
				this.SetNativeField("openGLView", value);
			}
		}
	}
	
	// Should subclass AppKit.NSView
	[Foundation.Register("MyOpenGLView")]
	public partial class MyOpenGLView {
	}
}
