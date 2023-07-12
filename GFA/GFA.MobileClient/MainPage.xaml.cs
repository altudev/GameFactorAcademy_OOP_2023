

using GFA.MobileClient.Components;

namespace GFA.MobileClient
{

    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

            if (sender is KadirButton)
            {
                var btn = sender as KadirButton;

                btn.Text = "Alper Tunga";

                btn.BackgroundColor = Colors.Black;
                btn.TextColor = Colors.Green;
            }

            count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}