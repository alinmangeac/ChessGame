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
        private int size = 0;
        private int initial_pos_x = 0;
        private int initial_pos_y = 0;
        public InitialForm()
        {
            InitializeComponent();

            //Construct the chess board
            InitializeBoard();
            
        }
        public void InitializeBoard()
        {
            const int chess_square_size = 50;
            int y_pos = 150;
            initial_pos_y = y_pos - 1;
            for (int col = 0; col < 8; col++)
            {
                int x_pos = 150;
                initial_pos_x = x_pos - 1;
                for (int row = 0; row < 8; row++)
                {
                    PictureBox chess_square = new PictureBox()
                    {
                        Location = new Point(x_pos, y_pos),
                        Size = new Size(chess_square_size, chess_square_size),
                        BackColor = Color.Red
                    };
                    if ((row % 2 == 0 && col % 2 == 0) || (row % 2 == 1 && col % 2 == 1))
                    {
                        chess_square.BackColor = Color.Yellow;
                    }

                    chess_square.Click += pictureBox_Click;
                    this.Controls.Add(chess_square);
                    x_pos += chess_square_size + 1;
                }
                y_pos += chess_square_size + 1;
                size += chess_square_size + 1;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
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

            Rectangle rect = new Rectangle(initial_pos_x, initial_pos_y, size, size);

            e.Graphics.DrawRectangle(blackPen, rect);
        }
    }
}
