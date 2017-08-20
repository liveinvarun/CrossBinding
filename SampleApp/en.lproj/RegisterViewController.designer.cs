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
	[Register ("RegisterViewController")]
	partial class RegisterViewController
	{
		[Outlet]
		UIKit.UIButton CancelBtn { get; set; }

		[Outlet]
		UIKit.UIButton Discardbtn { get; set; }

		[Outlet]
		UIKit.UITextField EmailTextField { get; set; }

		[Outlet]
		UIKit.UIButton NextBtn { get; set; }

		[Outlet]
		UIKit.UITextField PasswordTextField { get; set; }

		[Outlet]
		UIKit.UIButton SubmitBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (EmailTextField != null) {
				EmailTextField.Dispose ();
				EmailTextField = null;
			}

			if (PasswordTextField != null) {
				PasswordTextField.Dispose ();
				PasswordTextField = null;
			}

			if (NextBtn != null) {
				NextBtn.Dispose ();
				NextBtn = null;
			}

			if (CancelBtn != null) {
				CancelBtn.Dispose ();
				CancelBtn = null;
			}

			if (SubmitBtn != null) {
				SubmitBtn.Dispose ();
				SubmitBtn = null;
			}

			if (Discardbtn != null) {
				Discardbtn.Dispose ();
				Discardbtn = null;
			}
		}
	}
}
