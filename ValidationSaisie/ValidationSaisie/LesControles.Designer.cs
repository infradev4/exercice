
namespace ValidationSaisie
{
    partial class LesControles
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNom = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblMontant = new System.Windows.Forms.Label();
            this.LblFormat = new System.Windows.Forms.Label();
            this.LblCodePostal = new System.Windows.Forms.Label();
            this.TxbNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(61, 53);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(42, 20);
            this.LblNom.TabIndex = 0;
            this.LblNom.Text = "Nom";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(61, 94);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(41, 20);
            this.LblDate.TabIndex = 1;
            this.LblDate.Text = "Date";
            // 
            // LblMontant
            // 
            this.LblMontant.AutoSize = true;
            this.LblMontant.Location = new System.Drawing.Point(61, 136);
            this.LblMontant.Name = "LblMontant";
            this.LblMontant.Size = new System.Drawing.Size(65, 20);
            this.LblMontant.TabIndex = 2;
            this.LblMontant.Text = "Montant";
            // 
            // LblFormat
            // 
            this.LblFormat.AutoSize = true;
            this.LblFormat.Location = new System.Drawing.Point(283, 94);
            this.LblFormat.Name = "LblFormat";
            this.LblFormat.Size = new System.Drawing.Size(106, 20);
            this.LblFormat.TabIndex = 3;
            this.LblFormat.Text = "(JJ/MM/AAAA)";
            // 
            // LblCodePostal
            // 
            this.LblCodePostal.AutoSize = true;
            this.LblCodePostal.Location = new System.Drawing.Point(61, 177);
            this.LblCodePostal.Name = "LblCodePostal";
            this.LblCodePostal.Size = new System.Drawing.Size(87, 20);
            this.LblCodePostal.TabIndex = 4;
            this.LblCodePostal.Text = "Code Postal";
            // 
            // TxbNom
            // 
            this.TxbNom.Location = new System.Drawing.Point(137, 50);
            this.TxbNom.MaxLength = 30;
            this.TxbNom.Name = "TxbNom";
            this.TxbNom.Size = new System.Drawing.Size(125, 27);
            this.TxbNom.TabIndex = 5;
            // 
            // LesControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxbNom);
            this.Controls.Add(this.LblCodePostal);
            this.Controls.Add(this.LblFormat);
            this.Controls.Add(this.LblMontant);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblNom);
            this.Name = "LesControles";
            this.Text = "LesControles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblMontant;
        private System.Windows.Forms.Label LblFormat;
        private System.Windows.Forms.Label LblCodePostal;
        private System.Windows.Forms.TextBox TxbNom;
    }
}

