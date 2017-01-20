namespace GPS_Plugin
{
   using System;

   using Plugin.Geolocator;
   using Plugin.Geolocator.Abstractions;

   using Xamarin.Forms;

   public partial class MainPage : ContentPage
   {
      private IGeolocator locator;

      private Position position;

      public MainPage()
      {
         this.InitializeComponent();
         this.locator = CrossGeolocator.Current;
      }

      private async void GetGeolocation()
      {
         this.locator.DesiredAccuracy = 50;
         await this.locator.StartListeningAsync(1000, 0);

         this.position = await this.locator.GetPositionAsync(timeoutMilliseconds: 10000);

         this.locator.PositionChanged += (sender, e) =>
            {
               this.position = e.Position;

               this.TimeEntry.Text = string.Empty + this.position.Timestamp.LocalDateTime;
               this.LatEntry.Text = string.Empty + this.position.Latitude;
               this.LongEntry.Text = string.Empty + this.position.Longitude;
               this.SpeedEntry.Text = string.Empty + this.position.Speed;
            };
      }

      private void Go_OnClicked(object sender, EventArgs e)
      {
         if (!this.locator.IsListening)
         {
            this.GetGeolocation();
         }
      }

      private void Stop_OnClicked(object sender, EventArgs e)
      {
         if (this.locator.IsListening)
         {
            this.locator.StopListeningAsync();
         }
      }
   }
}