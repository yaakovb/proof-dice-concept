using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proof_dice_concept
{
    public partial class Form1 : Form
    {
        Button[] btnList;
        PictureBox[] myChosendice;

        public Form1()
        {
            InitializeComponent();

            btnList = new Button[5];
            myChosendice = new PictureBox[2];

            for (int i = 0; i < 5; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(15, 15 + i * 30);
                btn.Text = "btn " + i;
                btnList[i] = btn;
                this.Controls.Add(btn);
            }

            for (int i = 0; i < 2; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(60, 60);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ImageLocation = "wooden-helmet.png";
                pb.Location = new Point(120 + i *70, 15);
                this.Controls.Add(pb);
            }

        }
    }
}
