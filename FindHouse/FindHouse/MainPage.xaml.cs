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

            if (isEmailEmpty || isPasswordEmpty)
            {

            }
            else
            {

            }
                
        }
    }
}
