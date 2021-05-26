using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationSaisie
{
    public partial class LesControles : Form
    {
        public LesControles()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[AZa-z]{1,30}$");
            Regex regexB = new Regex("^[0-9][0-9]+/[0-9][0-9]+/[0-9][0-9][0-9][0-9]+$");

            if (txbNom.Text == "" & txbDate.Text == "" & txbMontant.Text == "" & txbCodepostal.Text == "")
            {
                errorProvider1.SetError(txbNom, "veuillez remplir tous les champs");
                errorProvider2.SetError(txbDate, "veuillez remplir tous les champs");
                errorProvider3.SetError(txbMontant, "veuillez remplir tous les champs");
                errorProvider4.SetError(txbCodepostal, "veuillez remplir tous les champs");
            }
            else if ((!regex.Match(txbNom.Text).Success) & (!regexB.Match(txbDate.Text).Success))
            {
                errorProvider1.SetError(txbNom, "veuillez utiliser des caractères alphabétiques (max 30)");
                errorProvider2.SetError(txbDate, "veuillez utiliser une date valide");
            }
            else
            {
                MessageBox.Show
                    (
                    "Nom : " + txbNom.Text + Environment.NewLine + 
                    "Date : " + txbDate.Text + Environment.NewLine + 
                    "Montant : " + txbMontant.Text + Environment.NewLine + 
                    "Code Postal : " + txbCodepostal.Text, 
                    "Validation Effectuée", MessageBoxButtons.OK
                    );

                DialogResult dialogresult = MessageBox.Show
                    (
                    "Fin de l’application ?", "FIN",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                    );
                
                if (dialogresult == DialogResult.Yes)
                Application.Exit();
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txbNom.Clear();
            txbDate.Clear();
            txbMontant.Clear();
            txbCodepostal.Clear();
        }
    }
}
