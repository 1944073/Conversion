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
            this.txtAffiche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAffiche
            // 
            this.txtAffiche.Location = new System.Drawing.Point(267, 186);
            this.txtAffiche.Name = "txtAffiche";
            this.txtAffiche.Size = new System.Drawing.Size(114, 51);
            this.txtAffiche.TabIndex = 0;
            this.txtAffiche.Text = "Affiche";
            this.txtAffiche.UseVisualStyleBackColor = true;
            this.txtAffiche.Click += new System.EventHandler(this.txtAffiche_Click);
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAffiche);
            this.Name = "frmConversion";
            this.Text = "Conversion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtAffiche;
    }
}

