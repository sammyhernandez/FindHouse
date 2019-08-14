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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

      
        public void RegisterButton_Cliked(object sender, EventArgs e)
        {
            bool isFirstNameEmpty = string.IsNullOrEmpty(FirstName.Text);
            bool isLastNameEmpty = string.IsNullOrEmpty(LastName.Text);
            bool isEmailEmpty = string.IsNullOrEmpty(Email.Text);
            bool isPasswordNameEmpty = string.IsNullOrEmpty(Password.Text);


            if (isFirstNameEmpty || isLastNameEmpty || isEmailEmpty || isPasswordNameEmpty)
            {
                DisplayAlert("Alert", "Todos los campos son obligatorios", "OK");
            }
            else
            {
                Navigation.PushAsync(new MainPage());
            }
            

        }
    }
}