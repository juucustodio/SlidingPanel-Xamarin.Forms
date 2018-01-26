using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoSlidingPanel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PageDown.TranslationY = 600;
        }

        async void Up_Tapped(object sender, System.EventArgs e)
        {
            await PageDown.TranslateTo(0, 0, 500, Easing.SinIn);
        }

        async void Down_Tapped(object sender, System.EventArgs e)
        {
            await PageDown.TranslateTo(0, Page.Height, 500, Easing.SinIn);
        }
    }
}