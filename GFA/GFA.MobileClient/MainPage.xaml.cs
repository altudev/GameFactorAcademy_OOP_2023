
using GFA.MobileClient.Models;

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
            double yusufsFavouriteNumber = 10.77d;
            int cemsFavouriteNumber = 8;
            decimal sezginsFavouriteNumber = 4.51M;
            DuzIks duzIks = new DuzIks(yusufsFavouriteNumber);

            duzIks = yusufsFavouriteNumber;

            duzIks = cemsFavouriteNumber;

            duzIks = (DuzIks)sezginsFavouriteNumber;

            cemsFavouriteNumber = (int)yusufsFavouriteNumber;


            string name=string.Empty;
            int? age=null;
            bool isDoorOpen;

            int myFavouriteNumber = 666;

            decimal myBalance = myFavouriteNumber;


            if (string.IsNullOrEmpty(txtName.Text))
            {
                Shell.Current.DisplayAlert("Uyarı!", "Ad alanı boş bırakılamaz.", "Tamam");
                return;
            }
            else
            {
                name = txtName.Text;
            }
                

            if (!string.IsNullOrEmpty(txtAge.Text))
                age = Convert.ToInt32(txtAge.Text);


            Shell.Current.DisplayAlert("Başarılı!", "Kaydınız başarıyla alınmıştır. GFA Gençlik Kolları", "Tamam");

            //string textFile = "asdasfasdqwe";
            //int? age = null;

            //if (age.HasValue)
            //{
            //    lblHelloWorld.Text = age.Value.ToString();
            //}
            //else
            //{
            //    lblHelloWorld.Text = "Tanımsız";
            //}

            //try
            //{
            //    if (sender is Button)
            //    {
            //        var btn = sender as Button;

            //        if (btn.ClassId == "myFirstButton")
            //        {
            //            count += 2;

            //        }
            //        else if(btn.ClassId == "mySecondButton")
            //        {
            //            count += 5;
            //        }

            //        lblCounter.Text = count.ToString();
            //    }else if (sender is Label)
            //    {
            //        var label = sender as Label;

            //        label.Text = count.ToString();
            //    }

            //    //lblHelloWorld.Text = count.ToString();
            //}
            //catch (System.Exception exception)
            //{
            //    Shell.Current.DisplayAlert("Hata!", "Beklenmedik bir hata oluştu.", "Tamam", "İptal");
            //}
        }
    }
}