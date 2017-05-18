namespace HappyShop.ShoppingClient
{
  partial class DebugInfoScreen
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelWelcomeMessage = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelWelcomeMessage
      // 
      this.labelWelcomeMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelWelcomeMessage.BackColor = System.Drawing.Color.Transparent;
      this.labelWelcomeMessage.Font = new System.Drawing.Font("Fantasque Sans Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelWelcomeMessage.Location = new System.Drawing.Point(3, 0);
      this.labelWelcomeMessage.Name = "labelWelcomeMessage";
      this.labelWelcomeMessage.Size = new System.Drawing.Size(314, 240);
      this.labelWelcomeMessage.TabIndex = 0;
      this.labelWelcomeMessage.Text = "Version: {0}";
      this.labelWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // DebugInfoScreen
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.labelWelcomeMessage);
      this.Name = "DebugInfoScreen";
      this.Size = new System.Drawing.Size(320, 240);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label labelWelcomeMessage;


  }
}
