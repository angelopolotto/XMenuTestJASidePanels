using System;
using MvvmCross.iOS.Support.SidePanels;
using UIKit;
using XMenuTest.Core;

namespace XMenuTest.iOS
{
	[MvxPanelPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, true)]
	public partial class SettingsViewController : BaseViewController<SettingsViewModel>
	{
		public SettingsViewController() : base("SettingsViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			SetupNavigationBar(true, false);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

