namespace Layout
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void VerticalButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.VerticalPage());
        }

        private void HorizontalButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.HorizontalPage());
        }

        private void GridButton_Clicked(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.GridPage());
        }

        private void AbsoluteButton_Clicked(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.AbsolutePage());
        }

        private void FlexButton_Clicked(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.FlexPage());
        }
    }
}
