namespace HappyShop.ShoppingClient
{
  partial class UninitializedScreen
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
      this.labelWelcomeMessage.AutoSize = true;
      this.labelWelcomeMessage.BackColor = System.Drawing.Color.Transparent;
      this.labelWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelWelcomeMessage.Location = new System.Drawing.Point(17, 82);
      this.labelWelcomeMessage.Name = "labelWelcomeMessage";
      this.labelWelcomeMessage.Size = new System.Drawing.Size(136, 24);
      this.labelWelcomeMessage.TabIndex = 0;
      this.labelWelcomeMessage.Text = "Bitte warten...";
      this.labelWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // UninitializedScreen
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
      this.Controls.Add(this.labelWelcomeMessage);
      this.Name = "UninitializedScreen";
      this.Size = new System.Drawing.Size(300, 240);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelWelcomeMessage;


  }
}
