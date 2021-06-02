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
using System.Globalization;



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
            Regex regexC = new Regex("^[0-9].?[0-9]?$");
            Regex regexD = new Regex("^[0-9]{5}$"); 


            if (txbNom.Text == "")
            {
                errorProvider1.SetError(txbNom, "veuillez remplir tous les champs");
            }
            else if (!regex.Match(txbNom.Text).Success) 
            {
                errorProvider1.SetError(txbNom, "veuillez utiliser des caractères alphabétiques (max 30)");
            }

            if (txbDate.Text == "")
            {
                errorProvider2.SetError(txbDate, "veuillez remplir tous les champs");
            }
            else if (!DateTime.TryParseExact(txbDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                errorProvider2.SetError(txbDate, "veuillez utiliser une date valide");
            }

            if (txbMontant.Text == "")
            {
                errorProvider3.SetError(txbMontant, "veuillez remplir tous les champs");
            }
            else if (!regexC.Match(txbMontant.Text).Success)
            {
                errorProvider3.SetError(txbMontant, "veuillez utiliser une Montant valide");
            }

            if (txbCodepostal.Text == "")
            {
                errorProvider4.SetError(txbCodepostal, "veuillez remplir tous les champs");
            }
            else if (!regexD.Match(txbCodepostal.Text).Success)
            {
                errorProvider4.SetError(txbCodepostal, "veuillez utiliser 5 caractères numériques");
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
