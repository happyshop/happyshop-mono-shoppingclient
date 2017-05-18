namespace HappyShop.ShoppingClient
{
  partial class PriceInfoScreen
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
      this.label1 = new System.Windows.Forms.Label();
      this.labelItemDescription = new System.Windows.Forms.Label();
      this.pictureBoxItemImage = new System.Windows.Forms.PictureBox();
      this.labelItemPrice = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemImage)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(320, 22);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ausgewähltes Produkt:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // labelItemDescription
      // 
      this.labelItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
      this.labelItemDescription.Location = new System.Drawing.Point(3, 22);
      this.labelItemDescription.Name = "labelItemDescription";
      this.labelItemDescription.Size = new System.Drawing.Size(317, 22);
      this.labelItemDescription.TabIndex = 1;
      this.labelItemDescription.Text = "{0}";
      this.labelItemDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pictureBoxItemImage
      // 
      this.pictureBoxItemImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBoxItemImage.Location = new System.Drawing.Point(3, 47);
      this.pictureBoxItemImage.Name = "pictureBoxItemImage";
      this.pictureBoxItemImage.Size = new System.Drawing.Size(314, 168);
      this.pictureBoxItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBoxItemImage.TabIndex = 3;
      this.pictureBoxItemImage.TabStop = false;
      // 
      // labelItemPrice
      // 
      this.labelItemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
      this.labelItemPrice.Location = new System.Drawing.Point(0, 218);
      this.labelItemPrice.Name = "labelItemPrice";
      this.labelItemPrice.Size = new System.Drawing.Size(320, 22);
      this.labelItemPrice.TabIndex = 4;
      this.labelItemPrice.Text = "für {0} €";
      this.labelItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // PriceInfoScreen
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.labelItemPrice);
      this.Controls.Add(this.pictureBoxItemImage);
      this.Controls.Add(this.labelItemDescription);
      this.Controls.Add(this.label1);
      this.Name = "PriceInfoScreen";
      this.Size = new System.Drawing.Size(320, 240);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemImage)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelItemDescription;
    private System.Windows.Forms.PictureBox pictureBoxItemImage;
    private System.Windows.Forms.Label labelItemPrice;
  }
}
