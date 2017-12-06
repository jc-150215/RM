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
            int dCount = int.Parse(s);


            if (dCount == 1)
            {
                RM.Text = w / 1;
            }

            else if (dCount == 2)
            {
                RM.Text = w / 0.95;
            }

            else if (dCount == 3)
            {
                RM.Text = w / 0.93;
            }

            else if (dCount == 4)
            {
                RM.Text = w / 0.9;
            }

            else if (dCount == 5)
            {
                RM.Text = w / 0.87;
            }

            else if (dCount == 6)
            {
                RM.Text = w / 0.85;
            }

            else if (dCount == 7)
            {
                RM.Text = w / 0.87;
            }

            else if (dCount == 8)
            {
                RM.Text = w / 0.8 ;
            }

            else if (dCount == 9)
            {
                RM.Text = w / 0.77;
            }

            else if(dCount == 10)
            {
                RM.Text = w / 0.7;
            }
        }
    }
}
