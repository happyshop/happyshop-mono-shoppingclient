using System;
using System.Globalization;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;
using log4net;

namespace HappyShop.ShoppingClient
{
  static class Program
  {
    private static readonly ILog Log =
      LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
      Configuration.Logger.Setup();

      ServicePointManager.ServerCertificateValidationCallback =
        ValidateServerCertficate;

      Log.Info("Setting culture to de-DE");
      Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de-DE");
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Log.Info("Loading main form.");
      Application.Run(new MainForm());
      Log.Info("End of code.");
    }

    private static bool ValidateServerCertficate(
      object sender,
      X509Certificate cert,
      X509Chain chain,
      SslPolicyErrors sslPolicyErrors)
    {
      return true;
    }
  }
}
