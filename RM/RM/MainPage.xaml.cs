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
            Double k = 0.0;
            String s = (String)count.SelectedItem;
            Double dCount = Double.Parse(s);


            if (dCount == 1)
            {
                k = w / 1;
                RM.Text = k.ToString();
            }

            else if (dCount == 2)
            {
                k = w / 0.95;
                RM.Text = k.ToString();
            }

            else if (dCount == 3)
            {
                k = w / 0.93;
                RM.Text = k.ToString();
            }

            else if (dCount == 4)
            {
                k = w / 0.9;
                RM.Text = k.ToString();
            }

            else if (dCount == 5)
            {
                k = w / 0.87;
                RM.Text = k.ToString();
            }

            else if (dCount == 6)
            {
                k = w / 0.85;
                RM.Text = k.ToString();
            }

            else if (dCount == 7)
            {
                k = w / 0.87;
                RM.Text = k.ToString();
            }

            else if (dCount == 8)
            {
                k = w / 0.8;
                RM.Text = k.ToString();
            }

            else if (dCount == 9)
            {
                k = w / 0.77;
                RM.Text = k.ToString();
            }

            else if(dCount == 10)
            {
                k = w / 0.7;
                RM.Text = k.ToString();
            }
        }
    }
}
