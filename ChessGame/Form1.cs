using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int offset = 50;
            int x = 0;
            for (int i = 0; i < 8; i++)
            {
                PictureBox temp = new PictureBox()
                {
                    Location = new Point(x, 0),
                    Size = new Size(50, 50),
                    BackColor = Color.Red
                };

                temp.Click += pictureBox39_Click;
                this.Controls.Add(temp);
                x += offset+1;
            }
        }



        private void pictureBox39_Click(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            MessageBox.Show(temp.Location.X.ToString());
        }
    }
}
