using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace XMenuTest.Core
{
	public class BaseViewModel : MvxViewModel
	{
		public BaseViewModel(string title = "")
		{
			Title = title;
			ToolbarBackCommand = new MvxCommand(BackCommandExecute);
		}

		private string _title;
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		protected void ShowViewModel<TViewModel>()
			where TViewModel : BaseViewModel => base.ShowViewModel<TViewModel>();

		protected void ShowViewModelAndEmptyBackstack<TViewModel>(object parametersValue = null)
			where TViewModel : BaseViewModel
		{
			var presentationBundle = new MvxBundle(new Dictionary<string, string> { { ConstantsHelper.ClearBackstack, "" } });
			ShowViewModel<TViewModel>(parametersValue, presentationBundle);
		}

		public IMvxCommand ToolbarBackCommand { get; }

		protected virtual void BackCommandExecute() => Close(this);
	}
}
