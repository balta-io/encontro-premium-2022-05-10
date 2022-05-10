namespace EncontroPremium.Mobile
{
    public partial class MainPage : ContentPage
    {
        string count = string.Empty;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count = Core.PasswordGenerator.Generate();
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}