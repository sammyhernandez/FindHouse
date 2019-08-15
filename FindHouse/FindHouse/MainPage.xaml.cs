using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FindHouse
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            
            InitializeComponent();
            
        }

    
        public void LoginButton_Cliked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(Email.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(Password.Text);
            string EmailText = Email.Text;
            string PasswordText = Password.Text;

           

            if (isEmailEmpty || isPasswordEmpty)
            {
                DisplayAlert("Alert", "Email o Contraseña incorrectos", "OK");
            }
            else
            {
                Navigation.PushAsync(new HomePage());
                Email.Text = string.Empty;
                Password.Text =  string.Empty;
            }
                
        }

        public void RecoverButton_Cliked(object sender, EventArgs e)
        {

        }

        public void RegisterButton_Cliked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
