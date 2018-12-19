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
	public partial class MoransBar : ContentPage
	{
		public MoransBar ()
		{
			InitializeComponent ();
            addImagesToPages7();
        }

        private void addImagesToPages7()
        {
            var assembly = typeof(Home);

            string strfilename = "CarnaMain.Images.Morans.jpg";

            Morans.Source = ImageSource.FromResource(strfilename, assembly);
        }
    }
}