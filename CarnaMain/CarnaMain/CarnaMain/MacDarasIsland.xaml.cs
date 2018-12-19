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
	public partial class MacDarasIsland : ContentPage
	{
		public MacDarasIsland ()
		{
			InitializeComponent ();
            addImagesToPages6();
        }

        private void addImagesToPages6()
        {
            var assembly = typeof(Home);

            string strfilename = "CarnaMain.Images.McDara.jpg";

            McDara.Source = ImageSource.FromResource(strfilename, assembly);
        }
    }
}