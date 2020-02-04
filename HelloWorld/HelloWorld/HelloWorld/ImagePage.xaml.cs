using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("HelloWorld.Images.background.jpg");

            //Downloaded Images:

            //var imageSource = new UriImageSource { Uri = new Uri("https://i.ytimg.com/vi/2jIZ3H9k2rA/maxresdefault.jpg") };
            //imageSource.CachingEnabled = false;
            //image.Source = imageSource;

            //Embedded Images


        }
    }
}