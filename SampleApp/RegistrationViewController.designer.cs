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
	[Register ("RegistrationViewController")]
	partial class RegistrationViewController
	{
		[Outlet]
		UIKit.UITableView regtableView { get; set; }

		[Outlet]
		UIKit.UIButton submitButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (regtableView != null) {
				regtableView.Dispose ();
				regtableView = null;
			}

			if (submitButton != null) {
				submitButton.Dispose ();
				submitButton = null;
			}
		}
	}
}
