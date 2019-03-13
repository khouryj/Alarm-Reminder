using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReminderApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //https://youtu.be/789LHEL2lO4 Navigation Page tutorial
            NavigationPage page = new NavigationPage();
            if (btn.Text == setBtn.Text)
            {
                
            }
            else if (btn.Text == editBtn.Text)
            {

            }
        }
    }
}
