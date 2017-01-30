using System;
using MvvmCross.iOS.Views;
using XMenuTest.Core;

namespace XMenuTest.iOS
{
	public class BaseViewControllerWithoutNib<TViewModel> : MvxViewController where TViewModel : BaseViewModel
	{
		#region Fields

		protected bool NavigationBarEnabled = false;

		public new TViewModel ViewModel
		{
			get { return (TViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		#endregion

		#region Public Methods

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		#endregion
	}
}
