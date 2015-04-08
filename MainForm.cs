using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexHelper
{
    public partial class MainForm : Form
    {
        private Point _mousePosition;
        private Cursor _cursor;
        private String _hex;

        public MainForm()
        {
            InitializeComponent();

            _cursor = new Cursor(Cursor.Current.Handle);
            _mousePosition = new Point();
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                ImageBox.Image = Clipboard.GetImage();
            }
            else
            {
                MessageBox.Show("No image could be located. Please try pasting an image to your clipboard and then trying again.",
                    "Image Paste Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImageBox_MouseClick(object sender, MouseEventArgs e)
        {
            _mousePosition.X = e.X;
            _mousePosition.Y = e.Y;

            if (ImageBox.Image != null) // Prevents crashing if no image has been pasted yet.
            {
                Bitmap bmp = new Bitmap(ImageBox.Image);
                Color color = bmp.GetPixel(_mousePosition.X, _mousePosition.Y);

                RedLabel.Text = "R: " + color.R;
                GreenLabel.Text = "G: " + color.G;
                BlueLabel.Text = "B: " + color.B;
                _hex = ConvertToHex(color);
                HexLabel.Text = "Hex: #" + _hex;
            }
        }

        private void CopyHexButton_Click(object sender, EventArgs e)
        {
            if (ImageBox.Image != null) 
            {
                if (!HexLabel.Text.Equals("Hex: "))
                {
                    Clipboard.SetText(_hex);
                }
                else
                {
                    MessageBox.Show("No point has been selected. Please select a point and try again.", "No Point Selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("No image could be found. Please paste an image and try again.", "Image Paste Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String ConvertToHex(Color c)
        {
            return c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }


        // These need to be here because C# is being dumb, and I'm too tired to fight it.
        // You win this round, C# *shakes fist angrily.*
        private void Form1_Load(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

    }
}
