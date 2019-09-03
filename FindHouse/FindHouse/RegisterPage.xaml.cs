using FakeItEasy;
using FindHouse.Model;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindHouse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        public async void RegisterButton_Cliked(object sender, EventArgs e)
        {
            Users user = new Users()
            {
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                Email = Email.Text,
                Password = Password.Text
            };

            var errors = user.ValidateUser();
            var errorsPass = user.ValidatePassword(PasswordConfirm.Text);


            if (errors.Any()) await DisplayAlert("Error", String.Join(", ", errors), "Ok");
            else if (errorsPass.Any()) await DisplayAlert("Error", String.Join(", ", errorsPass), "Ok");
            
            else
            {
                Registrarse.IsEnabled = false;
                await App.mobileServer.GetTable<Users>().InsertAsync(user);
                await DisplayAlert("Alert", "Usuario Registrado Correctamente.", "Ok");
                await Navigation.PushAsync(new MainPage());
            }
        }
    }
}