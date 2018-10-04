using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearnSmarter
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            change.Clicked += Change_Clicked;
		}

        private void Change_Clicked(object sender, EventArgs e)
        {
            label.Text = GenerateRandomText(7);
        }

        public string GenerateRandomText(int lettersAmount)
        {
            Random random = new Random();
            string result = "";

            for (int i = 0; i < lettersAmount; i++)
            {
                result += (char)random.Next(65, 91);
            }

            return result;
        }
    }
}
