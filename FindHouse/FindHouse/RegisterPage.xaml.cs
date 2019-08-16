using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FindHouse.Model;
using SQLite;

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
            var isFirstNameEmpty = string.IsNullOrEmpty(FirstName.Text);
            bool isLastNameEmpty = string.IsNullOrEmpty(LastName.Text);
            bool isEmailEmpty = string.IsNullOrEmpty(Email.Text);
            bool isPasswordNameEmpty = string.IsNullOrEmpty(Password.Text);
            bool isPasswordConfirmNameEmpty = string.IsNullOrEmpty(PasswordConfirm.Text);

           

            Users user = new Users()
                {
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Email = Email.Text,
                    Password = Password.Text,
                    PasswordConfirm = PasswordConfirm.Text
               


                };


            string pass = isPasswordNameEmpty.ToString();
            string passconfirm = isPasswordConfirmNameEmpty.ToString();
            //if (isPasswordNameEmpty == isPasswordConfirmNameEmpty) {



            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    conn.CreateTable<Users>();
                    int rows = conn.Insert(user);


                    if (rows > 0)
                    {
                        DisplayAlert("Success", "Usuario Registrado Exitosamente", "Ok");
                    }
                    else
                    {
                        DisplayAlert("Failure", "Error al registrar al usuaerio", "Ok");
                    }

                    if (isFirstNameEmpty || isLastNameEmpty || isEmailEmpty || isPasswordNameEmpty || isPasswordConfirmNameEmpty)
                    {
                        DisplayAlert("Alert", "Todos los campos son obligatorios", "OK");
                    }
                    else
                    {
                        Navigation.PushAsync(new MainPage());
                    }
                }
            //}else
            //{
                

            //    DisplayAlert("Alert", "Las contraseñas no son iguales", "Ok");
            //}
        }
    }
}