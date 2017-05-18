namespace HappyShop.ShoppingClient
{
  partial class ErrorBox
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
      this.labelHeader = new System.Windows.Forms.Label();
      this.labelMessage = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // labelHeader
      // 
      this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelHeader.Font = new System.Drawing.Font("Fantasque Sans Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelHeader.Location = new System.Drawing.Point(0, 9);
      this.labelHeader.Name = "labelHeader";
      this.labelHeader.Size = new System.Drawing.Size(320, 22);
      this.labelHeader.TabIndex = 3;
      this.labelHeader.Text = "Fehler";
      this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // labelMessage
      // 
      this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelMessage.BackColor = System.Drawing.Color.Red;
      this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.labelMessage.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.labelMessage.Font = new System.Drawing.Font("Fantasque Sans Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelMessage.ForeColor = System.Drawing.Color.Black;
      this.labelMessage.Location = new System.Drawing.Point(13, 35);
      this.labelMessage.Multiline = true;
      this.labelMessage.Name = "labelMessage";
      this.labelMessage.ReadOnly = true;
      this.labelMessage.Size = new System.Drawing.Size(295, 196);
      this.labelMessage.TabIndex = 4;
      this.labelMessage.Text = "<message>";
      this.labelMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // ErrorBox
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.Red;
      this.Controls.Add(this.labelMessage);
      this.Controls.Add(this.labelHeader);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Fantasque Sans Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "ErrorBox";
      this.Size = new System.Drawing.Size(320, 240);
      this.Load += new System.EventHandler(this.ErrorBox_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelHeader;
    private System.Windows.Forms.TextBox labelMessage;

  }
}