using FindHouse.Model;
using SQLite;
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
    public partial class UsersDetailPage : ContentPage
    {
       public Users selectedUsuarios;

        public UsersDetailPage(Users selectedUsuarios)
        {
            InitializeComponent();

            this.selectedUsuarios = selectedUsuarios;

            nombretext.Text = selectedUsuarios.FirstName;

        }

        void UpdateButton_Clicked(object sender, EventArgs e)
        {
            selectedUsuarios.FirstName = nombretext.Text;


            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Users>();
                int rows = conn.Update(selectedUsuarios);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Usuario Actualizado Exitosamente", "Ok");
                }
                else
                {
                    DisplayAlert("Failure", "Error al Actualizar al usuaerio", "Ok");
                }
            }
        }
        void DeleteButton_Clicked(object sender, EventArgs e)
        {
            
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Users>();
                int rows = conn.Delete(selectedUsuarios);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Usuario Eliminado Exitosamente", "Ok");
                }
                else
                {
                    DisplayAlert("Failure", "Error al Eliminar al usuaerio", "Ok");
                }

            }
        }
    }
    
}   