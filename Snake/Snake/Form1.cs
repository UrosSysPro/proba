using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        int[] x;
        int[] y;
        Panel[] paneli;
        int n;
        int w, h, velicinaPolja;
        int smerX, smerY;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pomeri();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n = 0;
            x = new int[200];
            y = new int[200];
            w = 50;
            h = 50;
            velicinaPolja = 10;
            paneli = new Panel[200];
            Size = new Size(500, 500);
            smerX = -1;
            smerY = 0;
            dodaj(w / 2, h / 2);
            dodaj(w / 2+1, h / 2);
            dodaj(w / 2+2, h / 2);
            dodaj(w / 2+3, h / 2);
            dodaj(w / 2+4, h / 2);
            timer1.Enabled = true;
        }
        public void dodaj(int novoX,int novoY)
        {
            x[n] = novoX;
            y[n] = novoY;
            paneli[n] = new Panel();
            paneli[n].Size = new Size(velicinaPolja, velicinaPolja);
            paneli[n].Location = new Point(novoX * velicinaPolja, novoY * velicinaPolja);
            paneli[n].BackColor = Color.Lime;
            Controls.Add(paneli[n]);
            n++;
        }

        public void pomeri()
        {
            x[0] += smerX;
            y[0] += smerY;
            paneli[0].Location = new Point(x[0] * velicinaPolja, y[0] * velicinaPolja);

        }

    }
}
