namespace HappyShop.ShoppingClient
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this._finishedScreen = new HappyShop.ShoppingClient.FinishedScreen();
      this._welcomeScreen = new HappyShop.ShoppingClient.WelcomeScreen();
      this._shoppingScreen = new HappyShop.ShoppingClient.ShoppingScreen();
      this._priceInfoScreen = new HappyShop.ShoppingClient.PriceInfoScreen();
      this._debugInfoScreen = new HappyShop.ShoppingClient.DebugInfoScreen();
      this._stockSelectItemScreen = new HappyShop.ShoppingClient.StockSelectItemScreen();
      this.SuspendLayout();
      // 
      // _finishedScreen
      // 
      this._finishedScreen.BackColor = System.Drawing.Color.Transparent;
      this._finishedScreen.Dock = System.Windows.Forms.DockStyle.Fill;
      this._finishedScreen.Enabled = false;
      this._finishedScreen.ImageCache = null;
      this._finishedScreen.Location = new System.Drawing.Point(0, 0);
      this._finishedScreen.Margin = new System.Windows.Forms.Padding(0);
      this._finishedScreen.Name = "_finishedScreen";
      this._finishedScreen.Size = new System.Drawing.Size(320, 240);
      this._finishedScreen.TabIndex = 2;
      this._finishedScreen.Visible = false;
      // 
      // _welcomeScreen
      // 
      this._welcomeScreen.BackColor = System.Drawing.Color.Transparent;
      this._welcomeScreen.Dock = System.Windows.Forms.DockStyle.Fill;
      this._welcomeScreen.Enabled = false;
      this._welcomeScreen.Location = new System.Drawing.Point(0, 0);
      this._welcomeScreen.Margin = new System.Windows.Forms.Padding(0);
      this._welcomeScreen.Name = "_welcomeScreen";
      this._welcomeScreen.Size = new System.Drawing.Size(320, 240);
      this._welcomeScreen.TabIndex = 1;
      this._welcomeScreen.Visible = false;
      // 
      // _shoppingScreen
      // 
      this._shoppingScreen.AutoSize = true;
      this._shoppingScreen.BackColor = System.Drawing.Color.Transparent;
      this._shoppingScreen.Dock = System.Windows.Forms.DockStyle.Fill;
      this._shoppingScreen.Enabled = false;
      this._shoppingScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._shoppingScreen.Location = new System.Drawing.Point(0, 0);
      this._shoppingScreen.Margin = new System.Windows.Forms.Padding(0);
      this._shoppingScreen.Name = "_shoppingScreen";
      this._shoppingScreen.Size = new System.Drawing.Size(320, 240);
      this._shoppingScreen.TabIndex = 0;
      this._shoppingScreen.Visible = false;
      // 
      // _priceInfoScreen
      // 
      this._priceInfoScreen.BackColor = System.Drawing.Color.Transparent;
      this._priceInfoScreen.Dock = System.Windows.Forms.DockStyle.Fill;
      this._priceInfoScreen.Enabled = false;
      this._priceInfoScreen.ImageCache = null;
      this._priceInfoScreen.Location = new System.Drawing.Point(0, 0);
      this._priceInfoScreen.Margin = new System.Windows.Forms.Padding(0);
      this._priceInfoScreen.Name = "_priceInfoScreen";
      this._priceInfoScreen.Size = new System.Drawing.Size(320, 240);
      this._priceInfoScreen.TabIndex = 2;
      this._priceInfoScreen.Visible = false;
      // 
      // _debugInfoScreen
      // 
      this._debugInfoScreen.BackColor = System.Drawing.Color.Transparent;
      this._debugInfoScreen.Dock = System.Windows.Forms.DockStyle.Fill;
      this._debugInfoScreen.Enabled = false;
      this._debugInfoScreen.Location = new System.Drawing.Point(0, 0);
      this._debugInfoScreen.Margin = new System.Windows.Forms.Padding(0);
      this._debugInfoScreen.Name = "_debugInfoScreen";
      this._debugInfoScreen.Size = new System.Drawing.Size(320, 240);
      this._debugInfoScreen.TabIndex = 2;
      this._debugInfoScreen.Visible = false;
      // 
      // _stockSelectItemScreen
      // 
      this._stockSelectItemScreen.BackColor = System.Drawing.Color.Transparent;
      this._stockSelectItemScreen.Dock = System.Windows.Forms.DockStyle.Fill;
      this._stockSelectItemScreen.Enabled = false;
      this._stockSelectItemScreen.Location = new System.Drawing.Point(0, 0);
      this._stockSelectItemScreen.Margin = new System.Windows.Forms.Padding(0);
      this._stockSelectItemScreen.Name = "_stockSelectItemScreen";
      this._stockSelectItemScreen.Size = new System.Drawing.Size(320, 240);
      this._stockSelectItemScreen.TabIndex = 2;
      this._stockSelectItemScreen.Visible = false;
      // 
      // MainForm
      // 
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(320, 240);
      this.Controls.Add(this._finishedScreen);
      this.Controls.Add(this._welcomeScreen);
      this.Controls.Add(this._shoppingScreen);
      this.Controls.Add(this._priceInfoScreen);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Fantasque Sans Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Kiosk";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ShoppingScreen _shoppingScreen;
    private WelcomeScreen _welcomeScreen;
    private FinishedScreen _finishedScreen;
    private PriceInfoScreen _priceInfoScreen;
    private DebugInfoScreen _debugInfoScreen;
    private StockSelectItemScreen _stockSelectItemScreen;
  }
}

