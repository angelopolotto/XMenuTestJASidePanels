using System;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace XMenuTest.Core
{
	public class LoginViewModel : BaseViewModel
	{

		public IMvxAsyncCommand LoginCommand { get; set; }

		public LoginViewModel() : base("Login")
		{
			LoginCommand = new MvxAsyncCommand(ExecuteLoginCommand);
		}

		private async Task ExecuteLoginCommand() => ShowViewModel<MainViewModel>();

		private string _email = "E-mail";
		public string Email
		{
			get { return _email; }
			set { SetProperty(ref _email, value); }
		}

		private string _password = "password";
		public string Password
		{
			get { return _password; }
			set { SetProperty(ref _password, value); }
		}
	}
}
