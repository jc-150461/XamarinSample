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

            //DisplayAlert("身長", h.ToString(), "OK");
            //DisplayAlert("体重", w.ToString(), "OK");
            if (h >= 3)
            {
                h /= 100;
            }
             bmi = w / (h * h);

            DisplayAlert("BMI", bmi.ToString(), "OK");
            if ( bmi < 16)
            {
                DisplayAlert("BMI", "痩せすぎ", "OK");
            }
            else if (bmi <= 16.99)
            {
                DisplayAlert("BMI", "痩せ", "OK");
            }
            else if (bmi <= 18.49)
            {
                DisplayAlert("BMI", "痩せぎみ", "OK");
            }
            else if (bmi >= 25.0)
            {
                DisplayAlert("BMI", "太りすぎ", "OK");
            }
            else
            {
                DisplayAlert("BMI", "普通", "OK");
            }
            
        }
    }
}

