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
            Double r = Double.Parse(RM.Text);
            String s = (String)count.SelectedItem;
            int dCount = int.Parse(s);


            if (dCount == 1)
            {
                r = w / 1;
            }

            else if (dCount == 2)
            {
                r = w / 0.95;
            }

            else if (dCount == 3)
            {
                r = w / 0.93;
            }

            else if (dCount == 4)
            {
                r = w / 0.9;
            }

            else if (dCount == 5)
            {
                r = w / 0.87;
            }

            else if (dCount == 6)
            {
                r = w / 0.85;
            }

            else if (dCount == 7)
            {
                r = w / 0.87;
            }

            else if (dCount == 8)
            {
                r = w / 0.8 ;
            }

            else if (dCount == 9)
            {
                r = w / 0.77;
            }

            else if(dCount == 10)
            {
                r = w / 0.7;
            }
        }
    }
}
