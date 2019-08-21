using FindHouse.Model;
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

    
        public async void LoginButton_Cliked(object sender, EventArgs e)
        {
           

            bool isEmailEmpty = string.IsNullOrEmpty(Email.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(Password.Text);
            string EmailText = Email.Text;
            string PasswordText = Password.Text;

           

            if (isEmailEmpty || isPasswordEmpty)
            {
                await DisplayAlert("Error", "Todos los campos son obligatorios.", " Ok");
            }
            else
            {
                var user = (await App.mobileServer.GetTable<Users>().Where(u => u.Email == Email.Text).ToListAsync()).FirstOrDefault();

                if (user != null)
                {
                    if (user.Password == Password.Text)
                    {
                        await Navigation.PushAsync(new HomePage());
                        Email.Text = null;
                        Password.Text = null;
                    }
                    else
                    {
                        await DisplayAlert("Error", "Correo Electrónico / Contraseña incorrectos", " Ok");
                    }
                }
                else
                {
                    await DisplayAlert("Error", "Usuario Invalido...", " Ok");
                }
                
                
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
