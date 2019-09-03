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
    public partial class ChangePassword : ContentPage
    {
        public ChangePassword()
        {
            InitializeComponent();
            this.BindingContext = new Users();
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var user = (await App.mobileServer.GetTable<Users>().ToListAsync());
            usListView.ItemsSource = user;

        }
    }
}