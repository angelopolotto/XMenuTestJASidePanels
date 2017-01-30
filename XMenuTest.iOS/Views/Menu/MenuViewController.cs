using System;
using Foundation;
using MvvmCross.iOS.Support.SidePanels;
using UIKit;
using XMenuTest.Core;

namespace XMenuTest.iOS
{
	[Register("MenuView")]
	[MvxPanelPresentation(MvxPanelEnum.Left, MvxPanelHintType.ActivePanel, false)]
	public class MenuView : BaseViewControllerWithoutNib<MenuViewModel>
	{
		private UITableView _tableView;

		public MenuView()
		{ 
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			Add(CreateMenu());
		}

		public override void ViewWillAppear(bool animated)
		{
			Title = "Left Menu View";
			base.ViewWillAppear(animated);
			NavigationController.NavigationBarHidden = true;
		}

		private UITableView CreateMenu()
		{
			var frame = View.Frame;
			frame.Width = frame.Width - 75;
			_tableView = new UITableView(frame)
			{
				ShowsHorizontalScrollIndicator = false,
				AutoresizingMask = UIViewAutoresizing.FlexibleHeight
			};
			_tableView.SetTableStyle(Colors.Color2, true);
			var source = new MenuTableSource(_tableView, ViewModel);
			_tableView.Source = source;
			source.ItemsSource = StringsResources.MenuFields();

			return _tableView;
		}
	}
}