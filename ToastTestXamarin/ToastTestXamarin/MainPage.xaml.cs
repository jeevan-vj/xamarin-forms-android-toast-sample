using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToastTestXamarin
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void ShowToast(Object sender, EventArgs args)
	    {
	        DependencyService.Get<IToastMessageService>().ShowToastMessage("Test Toast Message");
	    }

    }
}
