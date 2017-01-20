namespace GPS_Plugin
{
   using Xamarin.Forms;

   public partial class App : Application
   {
      public App()
      {
         this.InitializeComponent();

         this.MainPage = new MainPage();
      }

      protected override void OnResume()
      {
         // Handle when your app resumes
      }

      protected override void OnSleep()
      {
         // Handle when your app sleeps
      }

      protected override void OnStart()
      {
         // Handle when your app starts
      }
   }
}