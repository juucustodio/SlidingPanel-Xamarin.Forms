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

            PageDown.TranslationY = 1000;
            PageRight.TranslationX = 1000;
            PageLeft.TranslationX = -1000;
            PageUp.TranslationY = -1000;
        }

      
       
        async void UpBlue_Tapped(object sender, System.EventArgs e)
        {
            await PageDown.TranslateTo(0, 0, 500, Easing.SinIn);
        }

        async void DownWhite_Tapped(object sender, System.EventArgs e)
        {
            await PageDown.TranslateTo(0, Page.Height, 500, Easing.SinIn);
        }



        async void LeftBlue_Tapped(object sender, System.EventArgs e)
        {
            await PageRight.TranslateTo(0, 0, 500, Easing.SinIn);
        }

        async void RightWhite_Tapped(object sender, System.EventArgs e)
        {
            await PageRight.TranslateTo(Page.Width, 0, 500, Easing.SinIn);
        }



        async void LeftWhite_Tapped(object sender, System.EventArgs e)
        {
            await PageLeft.TranslateTo(-Page.Width, 0, 500, Easing.SinIn);
        }
        
        async void RightBlue_Tapped(object sender, System.EventArgs e)
        {
            await PageLeft.TranslateTo(0, 0, 500, Easing.SinIn);
        }




        async void UpWhite_Tapped(object sender, System.EventArgs e)
        {
            await PageUp.TranslateTo(0, -Page.Height, 500, Easing.SinIn);
        }

        async void DownBlue_Tapped(object sender, System.EventArgs e)
        {
            await PageUp.TranslateTo(0, 0, 500, Easing.SinIn);
        }
        

    }
}