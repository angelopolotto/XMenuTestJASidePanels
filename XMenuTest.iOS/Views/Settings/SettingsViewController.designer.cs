// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace XMenuTest.iOS
{
	[Register ("SettingsViewController")]
	partial class SettingsViewController
	{
		[Outlet]
		UIKit.UILabel SettingsLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SettingsLabel != null) {
				SettingsLabel.Dispose ();
				SettingsLabel = null;
			}
		}
	}
}
