using System;
using Foundation;
using MvvmCross.iOS.Views;
using UIKit;
using XMenuTest.Core;

namespace XMenuTest.iOS
{
	public class BaseViewController<TViewModel> : MvxViewController where TViewModel : BaseViewModel
	{
		public BaseViewController(string nibName, NSBundle bundle)
			: base(nibName, bundle) { }

		#region Fields

		protected bool NavigationBarEnabled = false;

		public new TViewModel ViewModel
		{
			get { return (TViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		#endregion

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			//NavigationController.SetNavigationBarHidden(true, false);

			if (ViewModel == null) return;

			Title = ViewModel.Title;
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}


		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();
		}

		public void SetupNavigationBar(bool showStatusBar, bool showBackButton, bool showMenuButton = false)
		{
			NavigationController.NavigationBarHidden = !showStatusBar;
			this.NavigationController.ToolbarHidden = true;

			var navigationBar = NavigationController.NavigationBar;

			//navigationBar.BarStyle = ToolbarContentColor == UIColor.White ? UIBarStyle.Black : UIBarStyle.Default;
			//navigationBar.TintColor = ToolbarContentColor;
			//navigationBar.BarTintColor = ToolbarTintColor;

			if (!showStatusBar) return;
			var animated = true;

			StyleNavigationBar(navigationBar);

			navigationBar.ClipsToBounds = false;

			navigationBar.SetBackgroundImage(new UIImage(), UIBarPosition.Any, UIBarMetrics.Default);
			navigationBar.ShadowImage = new UIImage();

			if (!showStatusBar) return;

			if (showBackButton)
			{
				var backImage = UIImage.FromBundle("ic_keyboard_arrow_left_white.png");
				NavigationItem.SetLeftBarButtonItem(
					new UIBarButtonItem(backImage, UIBarButtonItemStyle.Bordered, (sender, args) => ViewModel.ToolbarBackCommand.Execute()), animated);
			}
			else
			{
				NavigationItem.SetHidesBackButton(true, animated);
			}

			//if (showMenuButton)
			//{
			//	var backImage = UIImage.FromBundle("ic_menu_white.png");
			//	NavigationItem.SetLeftBarButtonItem(
			//		new UIBarButtonItem(backImage, UIBarButtonItemStyle.Bordered, (sender, args) => ViewModel.ToolbarBackCommand.Execute()), animated);
			//}
		}

		public void StyleNavigationBar(UINavigationBar navigationBar)
		{
			navigationBar.BackgroundColor = Colors.Color1;
			navigationBar.TintColor = Colors.White;
			navigationBar.BarTintColor = Colors.Color1;
			navigationBar.BarStyle = UIBarStyle.Default;// ToolbarContentColor == UIColor.White ? UIBarStyle.Black : UIBarStyle.Default;
			UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes { TextColor = UIColor.White });
			navigationBar.TitleTextAttributes = new UIStringAttributes()
			{
				ForegroundColor = Colors.White
			};
		}
	}
}
