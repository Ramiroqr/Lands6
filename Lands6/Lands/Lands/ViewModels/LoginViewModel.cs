using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lands.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        #region Attributes
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Properties
        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get { return password; }
            set { SetValue(ref password, value); }
        }

        public bool IsRunning
        {
            get { return isRunning; }
            set { SetValue(ref isRunning, value); }
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return isEnabled; }
            set { SetValue(ref isEnabled, value); }
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.IsEnabled = true;
        }

        #endregion
        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error", 
                    "You must enter an email" ,
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter a password",
                    "Accept");
                return;
            }

            if (this.Email != "ram@gmail.com" || this.Password != "1234")
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or password incorrect",
                    "Accept");
                this.Password = string.Empty;
                return;
            }

            await Application.Current.MainPage.DisplayAlert(
                    "Ok",
                    "Fuck yeahhhh!!!.",
                    "Accept");
            

        }
        #endregion

    }
}
