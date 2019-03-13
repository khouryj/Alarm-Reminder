using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReminderApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SetPage : ContentPage
	{
		public SetPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}