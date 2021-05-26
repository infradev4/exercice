
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
            this.components = new System.ComponentModel.Container();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblMontant = new System.Windows.Forms.Label();
            this.LblFormat = new System.Windows.Forms.Label();
            this.LblCodePostal = new System.Windows.Forms.Label();
            this.txbDate = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txbMontant = new System.Windows.Forms.TextBox();
            this.txbCodepostal = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
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
            this.LblFormat.Location = new System.Drawing.Point(331, 97);
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
            // txbDate
            // 
            this.txbDate.Location = new System.Drawing.Point(154, 94);
            this.txbDate.Name = "txbDate";
            this.txbDate.Size = new System.Drawing.Size(125, 27);
            this.txbDate.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txbMontant
            // 
            this.txbMontant.Location = new System.Drawing.Point(154, 136);
            this.txbMontant.Name = "txbMontant";
            this.txbMontant.Size = new System.Drawing.Size(125, 27);
            this.txbMontant.TabIndex = 7;
            // 
            // txbCodepostal
            // 
            this.txbCodepostal.Location = new System.Drawing.Point(154, 177);
            this.txbCodepostal.Name = "txbCodepostal";
            this.txbCodepostal.Size = new System.Drawing.Size(125, 27);
            this.txbCodepostal.TabIndex = 8;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(185, 266);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(94, 29);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(185, 330);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(94, 29);
            this.btnEffacer.TabIndex = 10;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(154, 53);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(125, 27);
            this.txbNom.TabIndex = 11;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // LesControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txbCodepostal);
            this.Controls.Add(this.txbMontant);
            this.Controls.Add(this.txbDate);
            this.Controls.Add(this.LblCodePostal);
            this.Controls.Add(this.LblFormat);
            this.Controls.Add(this.LblMontant);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblNom);
            this.Name = "LesControles";
            this.Text = "LesControles";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblMontant;
        private System.Windows.Forms.Label LblFormat;
        private System.Windows.Forms.Label LblCodePostal;
        private System.Windows.Forms.TextBox txbDate;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txbCodepostal;
        private System.Windows.Forms.TextBox txbMontant;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}

