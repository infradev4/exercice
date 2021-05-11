using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADDITIONNEUR
{
    public partial class Additionneur : Form
    {
        int total = 0;
        public Additionneur()
        {
            InitializeComponent();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            txbEcran.Text = txbEcran.Text + ((Button)sender).Text + "+";
            total += Convert.ToInt32(((Button)sender).Text);
            txbEcran.Text += " = " + total + "+";

        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            txbEcran.Clear();
        }
        private void btxChiffreZero_Click(object sender, EventArgs e)
        {
            txbEcran.Text = txbEcran.Text + btxChiffreZero.Text + "+";
            total += 0;
        }

        private void btxChiffreUn_Click(object sender, EventArgs e)
        {
            txbEcran.Text = txbEcran.Text + btxChiffreUn.Text + "+";
            total += 1;
        }

        private void btxChiffreDeux_Click(object sender, EventArgs e)
        {
            txbEcran.Text = txbEcran.Text + btxChiffreDeux.Text + "+";
            total += 2;
        }

        private void btxChiffreTrois_Click(object sender, EventArgs e)
        {
            txbEcran.Text = txbEcran.Text + btxChiffreTrois.Text + "+";
            total += 3;
        }

        private void btxChiffreQuattre_Click(object sender, EventArgs e)
        {
            txbEcran.Text = txbEcran.Text + btxChiffreQuattre.Text + "+";
            total += 4;
        }

        private void btxChiffreCinq_Click(object sender, EventArgs e)
        {
            txbEcran.Text = txbEcran.Text + btxChiffreCinq.Text + "+";
            total += 5;
        }

        private void btxChiffreSix_Click(object sender, EventArgs e)
        {
            txbEcran.Text = txbEcran.Text + btxChiffreSix.Text + "+";
            total += 6;
        }

        private void btxChiffreSept_Click(object sender, EventArgs e)
        {
            txbEcran.Text = txbEcran.Text + btxChiffreSept.Text + "+";
            total += 7;
        }

        private void btxChiffreHuit_Click(object sender, EventArgs e)
        {
            txbEcran.Text = txbEcran.Text + btxChiffreHuit.Text + "+";
            total += 8;
        }

        private void btxChiffreNeuf_Click(object sender, EventArgs e)
        {
            txbEcran.Text = txbEcran.Text + btxChiffreNeuf.Text + "+";
            total += 9;
        }

        private void txbEcran_TextChanged(object sender, EventArgs e)
        {
            /*
            this.btxChiffreZero.Click += new System.EventHandler(this.btnCalculer_Click);
            this.btxChiffreUn.Click += new System.EventHandler(this.btnCalculer_Click);
            this.btxChiffreDeux.Click += new System.EventHandler(this.btnCalculer_Click);
            this.btxChiffreTrois.Click += new System.EventHandler(this.btnCalculer_Click);
            this.btxChiffreQuattre.Click += new System.EventHandler(this.btnCalculer_Click);
            this.btxChiffreCinq.Click += new System.EventHandler(this.btnCalculer_Click);
            this.btxChiffreSix.Click += new System.EventHandler(this.btnCalculer_Click);
            this.btxChiffreSept.Click += new System.EventHandler(this.btnCalculer_Click);
            this.btxChiffreHuit.Click += new System.EventHandler(this.btnCalculer_Click);
            this.btxChiffreNeuf.Click += new System.EventHandler(this.btnCalculer_Click);
            */
        }
    }
}
