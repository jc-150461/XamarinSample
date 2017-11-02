using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            Double h = Double.Parse(Height.Text);
            Double w = Double.Parse(Weight.Text);

            Double bmi = 0.0;

            DisplayAlert("身長", h.ToString(), "OK");
            DisplayAlert("体重", w.ToString(), "OK");
            if( h >= 3)
            {
                h /= 100;
            }
             bmi = w / (h * h);
            
            DisplayAlert("BMI",bmi.ToString() , "OK");
           
        }
    }
}
