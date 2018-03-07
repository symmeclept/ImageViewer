namespace ImageViewer
{
	partial class Form1
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
			this.dlgFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.pbxImage = new System.Windows.Forms.PictureBox();
			this.lblMessage = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// dlgFileDialog
			// 
			this.dlgFileDialog.Filter = "PNG|*.png";
			// 
			// pbxImage
			// 
			this.pbxImage.Location = new System.Drawing.Point(2, 2);
			this.pbxImage.Name = "pbxImage";
			this.pbxImage.Size = new System.Drawing.Size(410, 307);
			this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbxImage.TabIndex = 2;
			this.pbxImage.TabStop = false;
			this.pbxImage.DoubleClick += new System.EventHandler(this.pbxImage_DoubleClick);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessage.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblMessage.Location = new System.Drawing.Point(12, 9);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(118, 13);
			this.lblMessage.TabIndex = 3;
			this.lblMessage.Text = "Double-click to open.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(414, 311);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.pbxImage);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog dlgFileDialog;
		private System.Windows.Forms.PictureBox pbxImage;
		private System.Windows.Forms.Label lblMessage;
	}
}

