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
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Users>();
                var users = conn.Table<Users>().ToList();
                UsersListView.ItemsSource = users;
            }
            
        }

        void Handle_selected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (UsersListView.SelectedItem is Users selectedUsers)
            {
                Navigation.PushAsync(new UsersDetailPage(selectedUsers));
            }

        }

       
    }
}