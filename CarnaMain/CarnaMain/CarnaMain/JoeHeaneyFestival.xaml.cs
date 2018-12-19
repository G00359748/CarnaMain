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
	public partial class JoeHeaneyFestival : ContentPage
	{
		public JoeHeaneyFestival ()
		{
			InitializeComponent ();
            addImagesToPages5();
        }

        private void addImagesToPages5()
        {
            var assembly = typeof(Home);

            string strfilename = "CarnaMain.Images.JoeHeaney1.jpg";

            JoeHeaney1.Source = ImageSource.FromResource(strfilename, assembly);
        }
    }
}