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
                w / 1 = RM.Text;
            }

            else if (dCount == 2)
            {
                w / 0.95 = RM.Text;
            }

            else if (dCount == 3)
            {
                w / 0.93 = RM.Text;
            }

            else if (dCount == 4)
            {
                w / 0.9 = RM.Text;
            }

            else if (dCount == 5)
            {
                w / 0.87 = RM.Text;
            }

            else if (dCount == 6)
            {
                w / 0.85 = RM.Text;
            }

            else if (dCount == 7)
            {
                w / 0.87 = RM.Text;
            }

            else if (dCount == 8)
            {
                w / 0.8 = RM.Text;
            }

            else if (dCount == 9)
            {
                w / 0.77 = RM.Text;
            }

            else
            {
                w / 0.7 = RM.Text;
            }
        }
    }
}
