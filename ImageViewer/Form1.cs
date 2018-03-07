using System;
using System.Windows.Forms;
using System.Drawing;

namespace ImageViewer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public bool openImageFile()
		{
			bool bSuccess = true;
			try
			{
				if (dlgFileDialog.ShowDialog() == DialogResult.OK)
				{
					pbxImage.Image = new Bitmap(dlgFileDialog.OpenFile());
					lblMessage.Text = "";
				}
				else
				{
					lblMessage.Text = "Image load failed(1).";
					bSuccess = false;
				}

				dlgFileDialog.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("ERROR: " + ex.Message);
				lblMessage.Text = "Image load failed.(2)";
			}
			return bSuccess;
		}

		private void pbxImage_DoubleClick(object sender, EventArgs e)
		{
			if (openImageFile()) {

			}
		}
	}
}
