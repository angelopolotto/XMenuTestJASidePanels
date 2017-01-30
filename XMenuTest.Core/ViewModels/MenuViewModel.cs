using System;
using MvvmCross.Core.ViewModels;

namespace XMenuTest.Core
{
	public class MenuViewModel : BaseViewModel
	{
		public MenuViewModel() : base("Menu")
		{

		}

		#region Cross Platform Commands & Handlers

		public IMvxCommand ShowHomeCommand
		{
			get { return new MvxCommand(ShowHomeExecuted); }
		}

		private void ShowHomeExecuted()
		{
			ShowViewModel<HomeViewModel>();
		}

		public IMvxCommand ShowSettingCommand
		{
			get { return new MvxCommand(ShowSettingsExecuted); }
		}

		private void ShowSettingsExecuted()
		{
			ShowViewModel<SettingsViewModel>();
		}

		public IMvxCommand ShowHelpCommand
		{
			get { return new MvxCommand(ShowHelpExecuted); }
		}

		private void ShowHelpExecuted()
		{
			ShowViewModel<HelpAndFeedbackViewModel>();
		}

		public IMvxCommand ShowLoginCommand
		{
			get { return new MvxCommand(ShowLoginViewModel); }
		}

		private void ShowLoginViewModel()
		{
			Close(this);
			ShowViewModel<LoginViewModel>();
		}

		#endregion
	}
}
