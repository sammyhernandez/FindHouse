using FindHouse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindHouse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PasswordRecovery : ContentPage
    {
        public PasswordRecovery()
        {
            InitializeComponent();
        }

   

        public async void Enviar_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(EmailRecovery.Text);

            if (isEmailEmpty)
            {
                await DisplayAlert("Alert", "El campo Correo Electrónico es obligatorio", "ok");
            }
            else
            {
                var user = (await App.mobileServer.GetTable<Users>().Where(u => u.Email == EmailRecovery.Text).ToListAsync()).FirstOrDefault();
                if (user != null)
                {
                    if (user.Email == EmailRecovery.Text)
                    {
                        Enviar.IsEnabled = false;
                        await Navigation.PushAsync(new ChangePassword());
                        EmailRecovery = null;                
                    }
                    else
                    {
                        await DisplayAlert("Alert", "El correo Digitado no se encuentra Registrado", "Ok");
                    }
                   
                }
                else
                {
                    await DisplayAlert("Alert", "El correo Digitado no se encuentra Registrado o no es valido", "Ok");
                }

            }

        }
    }
}