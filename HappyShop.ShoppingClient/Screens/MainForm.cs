using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using HappyShop.ServiceConnector;
using HappyShop.ShoppingClient.ImageCaching;
using HappyShop.SystemTools;

namespace HappyShop.ShoppingClient
{
  public partial class MainForm : Form
  {
    private readonly BarcodeScanner _scanner = new BarcodeScanner();
    private readonly StateMachine _stateMachine;
    private readonly ActivationGuard _activationGuard;
    private readonly WatterottDisplay _display = new WatterottDisplay();
    private readonly ErrorProvider _errorProvider;
    private ImageCache _imageCache;

    protected override bool ProcessDialogChar(char charCode)
    {
      _activationGuard.ActivityDetected();

      // close application when escape is pressed
      if (charCode == 27)
      {
        Close();
      }

      // process barcode input
      _scanner.InputReceived(charCode);

      return true;
    }

    public MainForm()
    {
      InitializeComponent();
      _errorProvider = new ErrorProvider();
      _stateMachine = new StateMachine(StateProvider, new KioskConnector(), _scanner, _errorProvider);
      _errorProvider
        .WithContinuationAction(ex => new ErrorBox(this, _activationGuard, _stateMachine).WithMessage(ErrorTranslator.Translate(ex)))
        .WithContinuationAction(_ => _stateMachine.Reset());
      _activationGuard = new ActivationGuard(TimeSpan.Parse((string)Configuration.Static.Merged.InactivityTimeout), _errorProvider)
        .OnActivate(_display.On)
        .OnActivate(_stateMachine.Reset)
        .OnDeactivate(_display.Off)
        .OnDeactivate(_stateMachine.Reset);
      _activationGuard.Start();

      _imageCache = new ImageCache(new LocalFileImageCache(new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "ImageCache")), new KioskConnector()));
      _imageCache.Synchronize();

      _finishedScreen.ImageCache = _imageCache;
      _priceInfoScreen.ImageCache = _imageCache;
    }

    private IState StateProvider(States state)
    {
      switch (state)
      {
        case States.Welcome:
          return _welcomeScreen;
        case States.Shopping:
          return _shoppingScreen;
        case States.Finished:
          return _finishedScreen;
        case States.PriceInfo:
          return _priceInfoScreen;
        case States.DebugInfo:
          return _debugInfoScreen;
        case States.StockItems:
          return _stockSelectItemScreen;
        default:
          return _welcomeScreen;
      }
    }
  }
}
