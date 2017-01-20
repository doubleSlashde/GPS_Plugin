namespace GPS_Plugin.WinPhone
{
   using GPS_Plugin.WinPhone.Resources;

   /// <summary>
   /// Bietet Zugriff auf Zeichenfolgenressourcen.
   /// </summary>
   public class LocalizedStrings
   {
      private static AppResources _localizedResources = new AppResources();

      public AppResources LocalizedResources
      {
         get
         {
            return _localizedResources;
         }
      }
   }
}