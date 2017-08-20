// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace SampleApp
{
	[Register ("RegistrationCell")]
	partial class RegistrationCell
	{
		[Outlet]
		UIKit.UIButton cancelBtn { get; set; }

		[Outlet]
		UIKit.UIButton NextBtn { get; set; }

		[Outlet]
		UIKit.UITextField passwordField { get; set; }

		[Outlet]
		UIKit.UITextField usernameField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (usernameField != null) {
				usernameField.Dispose ();
				usernameField = null;
			}

			if (passwordField != null) {
				passwordField.Dispose ();
				passwordField = null;
			}

			if (NextBtn != null) {
				NextBtn.Dispose ();
				NextBtn = null;
			}

			if (cancelBtn != null) {
				cancelBtn.Dispose ();
				cancelBtn = null;
			}
		}
	}
}
