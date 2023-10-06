using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorGuesser
{
    public partial class Form1 : Form
    {
        int GuessR, GuessG, GuessB;
        int R, G, B;
        bool cheatShown = false;

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        public void Reset()
        {
            pbInside.BackColor = Color.FromArgb(0, 0, 0);
            LosujKolor();
            tbR.Value = 0;
            tbG.Value = 0;
            tbB.Value = 0;
            lblR.Text = "R: 0";
            lblG.Text = "G: 0";
            lblB.Text = "B: 0";
            lblOdp.Visible = false;
        }

        private void btnSecretButton_DoubleClick(object sender, EventArgs e)
        {
            cheatShown = !cheatShown;
            if (cheatShown == false)
            {
                lblOdp.Visible = false;
            }
            else
            {
                lblOdp.Visible = true;
            }
        }

        public void LosujKolor()
        {
            Random losoweRGB = new Random();

            int r = losoweRGB.Next(0, 255);
            int g = losoweRGB.Next(0, 255);
            int b = losoweRGB.Next(0, 255);

            R = r; G = g; B = b;

            pbOutline.BackColor = Color.FromArgb(r, g, b);
            lblOdp.Text = ($"R:{r} G:{g} B:{b}");

        }

        private void tbR_Scroll(object sender, EventArgs e)
        {
            int Value = tbR.Value;
            GuessR = tbR.Value;
            lblR.Text = ($"R: {Value}");
            pbInside.BackColor = Color.FromArgb(GuessR, GuessG, GuessB);
        }

       

        private void tbG_Scroll(object sender, EventArgs e)
        {
            int Value = tbG.Value;
            GuessG = tbG.Value;
            lblG.Text = ($"G: {Value}");
            pbInside.BackColor = Color.FromArgb(GuessR, GuessG, GuessB);
        }

        private void tbB_Scroll(object sender, EventArgs e)
        {
            int Value = tbB.Value;
            GuessB = tbB.Value;
            lblB.Text = ($"B: {Value}");
            pbInside.BackColor = Color.FromArgb(GuessR, GuessG, GuessB);
        }
        

        //This method works for every slider 
        private void tbR_ValueChanged(object sender, EventArgs e)
        {
            if(GuessR == R && GuessG == G && GuessB == B)
            {
                DialogResult odp = MessageBox.Show("Yow won! Continue?", "Congrats", MessageBoxButtons.YesNo);
                if(odp == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
