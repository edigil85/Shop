using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Shop.UIForms.ViewModels
{
    internal class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(Login);

        public LoginViewModel()
        {
            this.Email = "edigil85@hotmail.com";
            this.Password = "123456";
        }
        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter and email.",
                    "Accept"
                    );
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter and password.",
                    "Accept"
                    );
                return;
            }
            if (!this.Email.Equals("edigil85@hotmail.com")|| !this.Password.Equals("123456"))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "User or password wrong.",
                    "Accept"
                    );
            }
            await Application.Current.MainPage.DisplayAlert(
                    "OK",
                    "Fuck Yeah!!!--..",
                    "Accept"
                    );
            return;
        }
    }
}
