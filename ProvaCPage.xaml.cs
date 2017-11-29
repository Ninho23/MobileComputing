using Xamarin.Forms;

namespace ProvaC
{
    public partial class ProvaCPage : ContentPage
    {
        public ProvaCPage()
        {
            InitializeComponent();

            image.Source = "app.jpg";
            image.Aspect = Aspect.Fill;
        }
    }
}
