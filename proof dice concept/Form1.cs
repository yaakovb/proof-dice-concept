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
        Button spinButton;
        Button switchButton;
        Button fightButton;
        Image[] imgList;
        PictureBox[] myChosenDice;
        PictureBox[] enemyChosenDice;
        bool useFirst;
        Round round;
        bool isForcedFight;

        public Form1()
        {
            InitializeComponent();
            useFirst = true;
            btnList = new Button[5];
            imgList = new Image[5];
            myChosenDice = new PictureBox[2];
            enemyChosenDice = new PictureBox[2];
            round = new Round();
            isForcedFight  = true;

            spinButton = new Button();
            spinButton.Location = new Point(150, 85);
            spinButton.Text = "SPIN";
            spinButton.Click += new EventHandler(this.Spin_Click);
            this.Controls.Add(spinButton);

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
                pb.BackColor = Color.Azure;
                myChosenDice[i] = pb;
                this.Controls.Add(pb);

                pb = new PictureBox();
                pb.Size = new Size(60, 60);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Location = new Point(120 + i * 70, 115);
                pb.Image = imgList[i];
                pb.BackColor = Color.LightPink;
                enemyChosenDice[i] = pb;
                this.Controls.Add(pb);
                round.SetDice(false, i, i);
            }

        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            int a = useFirst ? 0 : 1;
            Button btn = (Button) sender;
            int b = Convert.ToInt16(btn.Name);
            myChosenDice[a].Image = imgList[b];
            myChosenDice[a].Visible = true;
            useFirst = !useFirst;
            round.SetDice(true, a, b);
        }

        private void Spin_Click(object sender, System.EventArgs e)
        {
            round.Spin();
            isForcedFight = round.IsCrossedForcedOutCome() ||  IsStraightForcedOutCome();
            switchButton.Visible = !isForcedFight;
            fightButton.Visible = true;
            
        }
    }
}
