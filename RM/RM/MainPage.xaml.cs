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

            var countList = new List<string>();
            countList.Add(1);
            countList.Add(2);
            countList.Add(3);
            countList.Add(4);
            countList.Add(5);
            countList.Add(6);
            countList.Add(7);
            countList.Add(8);
            countList.Add(9);
            countList.Add(10);

            var picker = new Picker { Title = "数字を入力してください" };
            picker.ItemsSource = countList;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Double w = Double.Parse(Weight.Text);
            Double rm = Double.Parse(RM.Text);

            if (countList == 1)
            {
                w / 1 = rm;
            }

            else if (countList == 2)
            {
                w / 0.95 = rm;
            }

            else if (countList == 3)
            {
                w / 0.93 = rm;
            }

            else if (countList == 4)
            {
                w / 0.9 = rm;
            }

            else if (countList == 5)
            {
                w / 0.87 = rm;
            }

            else if (countList == 6)
            {
                w / 0.85 = rm;
            }

            else if (countList == 7)
            {
                w / 0.87 = rm;
            }

            else if (countList == 8)
            {
                w / 0.8 = rm;
            }

            else if (countList == 9)
            {
                w / 0.77 = rm;
            }

            else
            {
                w / 0.70 = rm;
            }
        }
        
    }
}
