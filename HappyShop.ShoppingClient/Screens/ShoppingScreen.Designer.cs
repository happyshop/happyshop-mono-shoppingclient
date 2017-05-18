namespace HappyShop.ShoppingClient
{
  partial class ShoppingScreen
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
      this.labelUserName = new System.Windows.Forms.Label();
      this.labelTakeIt = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelUserName
      // 
      this.labelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelUserName.BackColor = System.Drawing.Color.Transparent;
      this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelUserName.Location = new System.Drawing.Point(26, 15);
      this.labelUserName.Name = "labelUserName";
      this.labelUserName.Size = new System.Drawing.Size(277, 24);
      this.labelUserName.TabIndex = 8;
      this.labelUserName.Text = "<User welcome>";
      this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // labelTakeIt
      // 
      this.labelTakeIt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelTakeIt.BackColor = System.Drawing.Color.Transparent;
      this.labelTakeIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTakeIt.Location = new System.Drawing.Point(22, 84);
      this.labelTakeIt.Name = "labelTakeIt";
      this.labelTakeIt.Size = new System.Drawing.Size(281, 107);
      this.labelTakeIt.TabIndex = 9;
      this.labelTakeIt.Text = "Such Dir was aus\r\nund scanne den Barcode";
      this.labelTakeIt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ShoppingScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.labelTakeIt);
      this.Controls.Add(this.labelUserName);
      this.Name = "ShoppingScreen";
      this.Size = new System.Drawing.Size(320, 240);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label labelUserName;
    private System.Windows.Forms.Label labelTakeIt;
  }
}
