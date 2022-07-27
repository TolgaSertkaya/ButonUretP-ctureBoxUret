using ButonUretPıctureBoxUret.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButonUretPıctureBoxUret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 1;
        private void btnUret_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Width = 60;
            btn.Height = 30;

            Random rnd = new Random();

            int x = rnd.Next(0, this.ClientSize.Width - btn.Width);
            int y = rnd.Next(0, this.ClientSize.Height - btn.Height);

            btn.Left = x;
            btn.Top = y;

            btn.Text = sayac.ToString();
            sayac++;
            btn.Click += btnYeni_Click;
            this.Controls.Add(btn);

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Button tiklananButon = (Button)sender;
            //tiklananButon.Enabled = false;
            //tiklananButon.SendToBack();
            tiklananButon.BringToFront();
            MessageBox.Show(tiklananButon.Text);
        }

        private void btnAtAt_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            PictureBox pictureBox = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Resources.horse2,
            };
            pictureBox.Width = 75;
            pictureBox.Height = 55;
            pictureBox.Top = rnd.Next(0, this.ClientSize.Height - pictureBox.Height);
            pictureBox.Left = rnd.Next(0, this.ClientSize.Width - pictureBox.Width);
            pictureBox.Click += PictureBox_Click;
            this.Controls.Add(pictureBox);
        }

        private void PictureBox_Click(object sender, EventArgs e)  //bastıgında kaldırıyor
        {
            PictureBox pictureBox = (PictureBox)sender;
            this.Controls.Remove(pictureBox);
        }



        //Butona basıldığında başka bir buton üretsin random..
        //üretilen butonun üstünde butonun sayısı yazsın(2. üretilen buton için=>2 gibi.)
        //eklenen butonların click eventine method atayın.
        //atadığınız methodda tıkladıgınız butonun sıra numarasını mbox ıle gosterınız
        //(ARASTIRMA) tıklanan buton ekranda öne ya da arkaya gelsin(bring)

    }
}
