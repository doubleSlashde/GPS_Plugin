namespace GPS_Plugin.WinPhone
{
   using Xamarin.Forms;

   public partial class MainPage : Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
   {
      // Constructor
      public MainPage()
      {
         this.InitializeComponent();
         Forms.Init();
         this.LoadApplication(new GPS_Plugin.App());
      }
   }
}