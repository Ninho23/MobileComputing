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

            button = new Button
            {
                Text = "Click Me!",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
        }
    }
}