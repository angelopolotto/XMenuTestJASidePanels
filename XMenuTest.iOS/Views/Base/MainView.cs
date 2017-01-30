using System;
using Foundation;
using MvvmCross.iOS.Support.SidePanels;
using XMenuTest.Core;

namespace XMenuTest.iOS
{
	[Register("MainView")]
	[MvxPanelPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, true)]
	public class MainView : BaseViewControllerWithoutNib<MainViewModel>
	{
		public MainView()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			ViewModel.ShowMenu();
		}
	}
}
