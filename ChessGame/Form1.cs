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
    public partial class InitialForm : Form
    {
        private const int size = 30;
        public InitialForm()
        {
            InitializeComponent();

            //Construct the chess board
            InitializeBoard();
            
        }
        public void InitializeBoard()
        {
            int offset_y = 50;
            int y_pos = 200;
            for (int col = 0; col < 8; col++)
            {
                int offset_x = 50;
                int x_pos = 200;
                for (int row = 0; row < 8; row++)
                {
                    PictureBox temp = new PictureBox()
                    {
                        Location = new Point(x_pos, y_pos),
                        Size = new Size(50, 50),
                        BackColor = Color.Red
                    };
                    if ((row % 2 == 0 && col % 2 == 0) || (row % 2 == 1 && col % 2 == 1))
                    {
                        temp.BackColor = Color.Yellow;
                    }

                    temp.Click += pictureBox39_Click;
                    this.Controls.Add(temp);
                    x_pos += offset_x + 1;
                }
                y_pos += offset_y + 1;
            }
        }
        public void DrawRectangle(PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);

            Rectangle rect = new Rectangle(0, 0, 400,400);

            e.Graphics.DrawRectangle(blackPen, rect);
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            MessageBox.Show((temp.Location.X.ToString()) + " " + (temp.Location.Y.ToString()));
        }

        private void InitialForm_Load(object sender, EventArgs e)
        {

        }

        private void InitialForm_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);

            Rectangle rect = new Rectangle(197, 197, 410, 410);

            e.Graphics.DrawRectangle(blackPen, rect);
        }
    }
}
