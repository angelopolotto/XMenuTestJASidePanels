using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Support.SidePanels;
using UIKit;
using XMenuTest.Core;

namespace XMenuTest.iOS
{
	[MvxPanelPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, false)]
	public partial class LoginViewController : BaseViewController<LoginViewModel>
	{
		public LoginViewController() : base("LoginViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			SetupNavigationBar(false, false);

			var set = this.CreateBindingSet<LoginViewController, LoginViewModel>();
			set.Bind(LoginField).To(vm => vm.Email);
			set.Bind(PasswordField).To(vm => vm.Password);
			set.Bind(LoginButton).To(vm => vm.LoginCommand);
			set.Apply();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

