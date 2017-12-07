using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Double w = Double.Parse(Weight.Text);
            String s = (String)count.SelectedItem;
            Double dCount = Double.Parse(s);


            if (dCount == 1)
            {
                Double.Parse(RM.Text) = w / 1;
            }

            else if (dCount == 2)
            {
                Double.Parse(RM.Text) = w / 0.95;
            }

            else if (dCount == 3)
            {
                Double.Parse(RM.Text) = w / 0.93;
            }

            else if (dCount == 4)
            {
                Double.Parse(RM.Text) = w / 0.9;
            }

            else if (dCount == 5)
            {
                Double.Parse(RM.Text) = w / 0.87;
            }

            else if (dCount == 6)
            {
                Double.Parse(RM.Text) = w / 0.85;
            }

            else if (dCount == 7)
            {
                Double.Parse(RM.Text) = w / 0.87;
            }

            else if (dCount == 8)
            {
                Double.Parse(RM.Text) = w / 0.8 ;
            }

            else if (dCount == 9)
            {
                Double.Parse(RM.Text) = w / 0.77;
            }

            else if(dCount == 10)
            {
                Double.Parse(RM.Text) = w / 0.7;
            }
        }
    }
}
