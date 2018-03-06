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
			this.btnLoadImage = new System.Windows.Forms.Button();
			this.dlgFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.txtImagePath = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLoadImage
			// 
			this.btnLoadImage.Location = new System.Drawing.Point(350, 326);
			this.btnLoadImage.Name = "btnLoadImage";
			this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
			this.btnLoadImage.TabIndex = 0;
			this.btnLoadImage.Text = "Load";
			this.btnLoadImage.UseVisualStyleBackColor = true;
			// 
			// dlgFileDialog
			// 
			this.dlgFileDialog.FileName = "openFileDialog1";
			this.dlgFileDialog.Filter = "PNG|*.png";
			// 
			// txtImagePath
			// 
			this.txtImagePath.Location = new System.Drawing.Point(13, 326);
			this.txtImagePath.Name = "txtImagePath";
			this.txtImagePath.Size = new System.Drawing.Size(331, 20);
			this.txtImagePath.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(13, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(410, 307);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 367);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtImagePath);
			this.Controls.Add(this.btnLoadImage);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLoadImage;
		private System.Windows.Forms.OpenFileDialog dlgFileDialog;
		private System.Windows.Forms.TextBox txtImagePath;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

