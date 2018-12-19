using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarnaMain
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
            addImagesToPages1();
        }

        private void addImagesToPages1()
        {
            var assembly = typeof(MainPage);

            string strfilename = "Carna.Images.Carna1.jpg";

            Carna1.Source = ImageSource.FromResource(strfilename, assembly);
        }
    }
}