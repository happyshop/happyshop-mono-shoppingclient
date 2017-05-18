namespace HappyShop.ShoppingClient
{
  partial class StockSelectItemScreen
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
      this.labelTakeIt = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelTakeIt
      // 
      this.labelTakeIt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelTakeIt.BackColor = System.Drawing.Color.Transparent;
      this.labelTakeIt.Font = new System.Drawing.Font("Fantasque Sans Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTakeIt.Location = new System.Drawing.Point(22, 25);
      this.labelTakeIt.Name = "labelTakeIt";
      this.labelTakeIt.Size = new System.Drawing.Size(281, 190);
      this.labelTakeIt.TabIndex = 9;
      this.labelTakeIt.Text = "Scanne den Barcode des Artikels, der aufgefüllt werden soll.";
      this.labelTakeIt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // StockSelectItemScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.labelTakeIt);
      this.Name = "StockSelectItemScreen";
      this.Size = new System.Drawing.Size(320, 240);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label labelTakeIt;
  }
}
