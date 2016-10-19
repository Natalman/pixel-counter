using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int pixels = getPixels();
            PixelsLabel.Text = "This windows contains " + pixels + " pixels";
        }
        private int getPixels()
        {
            int height = this.Size.Height;
            int width = this.Size.Width;
            int pixels = height * width;
            return pixels;
        }
    }
}
