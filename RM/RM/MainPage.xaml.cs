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
            Double rm = Double.Parse(RM.Text);
            
            if(Count.SelectedItem == 1)
            {
                w / 1 = rm;
            }
            
            else if(Count.SelectedItem == 2)
            {
                w / 0.95 = rm;
            }

            else if (Count.SelectedItem == 3)
            {
                w / 0.93 = rm;
            }

            else if (Count.SelectedItem == 4)
            {
                w / 0.9 = rm;
            }

            else if (Count.SelectedItem == 5)
            {
                w / 0.87 = rm;
            }

            else if (Count.SelectedItem == 6)
            {
                w / 0.85 = rm;
            }

            else if (c == 7)
            {
                w / 0.87 = rm;
            }

            else if (Count.SelectedItem == 8)
            {
                w / 0.8 = rm;
            }

            else if (Count.SelectedItem == 9)
            {
                w / 0.77 = rm;
            }

            else if (Count.SelectedItem == 10)
            {
                w / 0.70 = rm;
            }
        }
    }
}
