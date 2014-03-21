using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Labo1
{
    public partial class Form1 : Form
    {
        private List<Rectangle> points = new List<Rectangle>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Fermer la fenêtre","Alert",MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Dispose();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Form2 nouvelleFenetre = new Form2();
         //   nouvelleFenetre.ShowDialog();
            nouvelleFenetre.Show();
        }

        private void panelDessin_Click(object sender, EventArgs e)
        {
            MouseEventArgs souris = (MouseEventArgs)e;
            Rectangle contEllipse = new Rectangle();
            Point position = new Point();
            Size taille = new Size(10,10);
            position.X = souris.X - taille.Width/2;
            position.Y = souris.Y - taille.Height/2;
            contEllipse.Location = position;
            contEllipse.Size = taille;
            points.Add(contEllipse);
            panelDessin.CreateGraphics().FillEllipse(new SolidBrush(Color.Blue), contEllipse);
        }

        private void panelDessin_Paint(object sender, PaintEventArgs e)
        {
            foreach (Rectangle rect in points)
            {
                panelDessin.CreateGraphics().FillEllipse(new SolidBrush(Color.Blue), rect);
            }
        }

        private void panelDessin_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs souris = (MouseEventArgs)e;
            if (souris.Button == MouseButtons.Left)
            {
                Rectangle contEllipse = new Rectangle();
                Point position = new Point();
                Size taille = new Size(10, 10);
                position.X = souris.X - taille.Width / 2;
                position.Y = souris.Y - taille.Height / 2;
                contEllipse.Location = position;
                contEllipse.Size = taille;
                points.Add(contEllipse);
                panelDessin.CreateGraphics().FillEllipse(new SolidBrush(Color.Blue), contEllipse);
            }
        }
    }
}