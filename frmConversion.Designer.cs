namespace Conversion
{
    partial class frmConversion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBinaire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHexa = new System.Windows.Forms.Button();
            this.btnDecinal = new System.Windows.Forms.Button();
            this.txtEntree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBinaire = new System.Windows.Forms.TextBox();
            this.txtHexa = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSortie = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBinaire
            // 
            this.btnBinaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinaire.Location = new System.Drawing.Point(61, 193);
            this.btnBinaire.Name = "btnBinaire";
            this.btnBinaire.Size = new System.Drawing.Size(100, 39);
            this.btnBinaire.TabIndex = 0;
            this.btnBinaire.Text = "Binaire";
            this.btnBinaire.UseVisualStyleBackColor = true;
            this.btnBinaire.Click += new System.EventHandler(this.btnBinaire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversion";
            // 
            // btnHexa
            // 
            this.btnHexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHexa.Location = new System.Drawing.Point(297, 193);
            this.btnHexa.Name = "btnHexa";
            this.btnHexa.Size = new System.Drawing.Size(121, 39);
            this.btnHexa.TabIndex = 2;
            this.btnHexa.Text = "Hexadecimal";
            this.btnHexa.UseVisualStyleBackColor = true;
            // 
            // btnDecinal
            // 
            this.btnDecinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecinal.Location = new System.Drawing.Point(522, 193);
            this.btnDecinal.Name = "btnDecinal";
            this.btnDecinal.Size = new System.Drawing.Size(100, 39);
            this.btnDecinal.TabIndex = 3;
            this.btnDecinal.Text = "Decimal";
            this.btnDecinal.UseVisualStyleBackColor = true;
            // 
            // txtEntree
            // 
            this.txtEntree.Location = new System.Drawing.Point(297, 40);
            this.txtEntree.Name = "txtEntree";
            this.txtEntree.Size = new System.Drawing.Size(100, 20);
            this.txtEntree.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Binaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hexa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(574, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Decimal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Entrée";
            // 
            // txtBinaire
            // 
            this.txtBinaire.Location = new System.Drawing.Point(95, 107);
            this.txtBinaire.Name = "txtBinaire";
            this.txtBinaire.ReadOnly = true;
            this.txtBinaire.Size = new System.Drawing.Size(100, 20);
            this.txtBinaire.TabIndex = 9;
            // 
            // txtHexa
            // 
            this.txtHexa.Location = new System.Drawing.Point(331, 107);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.ReadOnly = true;
            this.txtHexa.Size = new System.Drawing.Size(100, 20);
            this.txtHexa.TabIndex = 10;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(556, 107);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.ReadOnly = true;
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnBinaire);
            this.groupBox1.Controls.Add(this.btnHexa);
            this.groupBox1.Controls.Add(this.btnDecinal);
            this.groupBox1.Controls.Add(this.txtEntree);
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 270);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valeur à Convertir";
            // 
            // btnSortie
            // 
            this.btnSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortie.Location = new System.Drawing.Point(684, 396);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.Size = new System.Drawing.Size(104, 39);
            this.btnSortie.TabIndex = 13;
            this.btnSortie.Text = "Sortie";
            this.btnSortie.UseVisualStyleBackColor = true;
            this.btnSortie.Click += new System.EventHandler(this.btnSortie_Click);
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 485);
            this.Controls.Add(this.btnSortie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtHexa);
            this.Controls.Add(this.txtBinaire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConversion";
            this.Text = "Conversion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBinaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHexa;
        private System.Windows.Forms.Button btnDecinal;
        private System.Windows.Forms.TextBox txtEntree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBinaire;
        private System.Windows.Forms.TextBox txtHexa;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSortie;
    }
}

