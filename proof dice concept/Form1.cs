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
        Image[] imgList;
        PictureBox[] myChosendice;
        bool useFirst;

        public Form1()
        {
            InitializeComponent();
            useFirst = true;

            btnList = new Button[5];
            imgList = new Image[5];
            myChosendice = new PictureBox[2];

            for (int i = 0; i < 5; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(15, 15 + i * 30);
                btn.Text = "btn " + i;
                btnList[i] = btn;
                btn.Click += new EventHandler(this.Button_Click);
                btn.Name = i.ToString();
                this.Controls.Add(btn);

                string imageName = "pic" + (i+1) + ".png";
                Image image = Image.FromFile(imageName);
                imgList[i] = image;
            }

            for (int i = 0; i < 2; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(60, 60);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Location = new Point(120 + i *70, 15);
                pb.Visible = false;
                myChosendice[i] = pb;
                this.Controls.Add(pb);
            }

        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            int a = useFirst ? 0 : 1;
            Button btn = (Button) sender;
            int b = Convert.ToInt16(btn.Name);
            myChosendice[a].Image = imgList[b];
            myChosendice[a].Visible = true;
            useFirst = !useFirst;
        }
    }
}
