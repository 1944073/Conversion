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
            this.SuspendLayout();
            // 
            // btnBinaire
            // 
            this.btnBinaire.Location = new System.Drawing.Point(40, 370);
            this.btnBinaire.Name = "btnBinaire";
            this.btnBinaire.Size = new System.Drawing.Size(114, 51);
            this.btnBinaire.TabIndex = 0;
            this.btnBinaire.Text = "Binaire";
            this.btnBinaire.UseVisualStyleBackColor = true;
            this.btnBinaire.Click += new System.EventHandler(this.txtAffiche_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversion";
            // 
            // btnHexa
            // 
            this.btnHexa.Location = new System.Drawing.Point(317, 370);
            this.btnHexa.Name = "btnHexa";
            this.btnHexa.Size = new System.Drawing.Size(114, 51);
            this.btnHexa.TabIndex = 2;
            this.btnHexa.Text = "Hexadecimal";
            this.btnHexa.UseVisualStyleBackColor = true;
            // 
            // btnDecinal
            // 
            this.btnDecinal.Location = new System.Drawing.Point(542, 370);
            this.btnDecinal.Name = "btnDecinal";
            this.btnDecinal.Size = new System.Drawing.Size(114, 51);
            this.btnDecinal.TabIndex = 3;
            this.btnDecinal.Text = "Decimal";
            this.btnDecinal.UseVisualStyleBackColor = true;
            // 
            // txtEntree
            // 
            this.txtEntree.Location = new System.Drawing.Point(317, 205);
            this.txtEntree.Name = "txtEntree";
            this.txtEntree.Size = new System.Drawing.Size(100, 20);
            this.txtEntree.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Conversion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Conversion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Conversion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Entrée";
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEntree);
            this.Controls.Add(this.btnDecinal);
            this.Controls.Add(this.btnHexa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBinaire);
            this.Name = "frmConversion";
            this.Text = "Conversion";
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
    }
}

