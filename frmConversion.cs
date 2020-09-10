/*
 * Zachary Gagné
 * 2020-09-03
 * Programme de conversion
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class frmConversion : Form
    {
        public frmConversion()
        {
            InitializeComponent();
        }

        private void btnBinaire_Click(object sender, EventArgs e)
        {
            string Entree;
            int Sortie = 0;

            Entree = txtEntree.Text;
            
            if (Entree[0] == '0' && Entree[1] == 'x') //Conversion en Hexa
            {

            }

            else if (Entree[0] == 'b') //Conversion en binaire
            {
                int reste;
                string binaire = "";
                Int32.TryParse(Entree, out Sortie);
                for (int i = 0; Sortie > 0; i++)
                {
                    reste = Sortie % 2;
                    Sortie = Sortie / 2;

                    binaire = reste.ToString() + binaire;
                }

                txtBinaire.Text = binaire.ToString();
            }
            else //conversion en décimal
            {

            }

        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHexa_Click(object sender, EventArgs e)
        {
            string Entree = txtEntree.Text;

            if (Entree[0] == 'b') //Conversion en binaire
            {

            }
            else if (Entree[0] == '0' && Entree[1] == 'x') //Conversion en Hexa
            {

            }
            else //Conversion en décimal
            {

            }
        }

        private void btnDecinal_Click(object sender, EventArgs e)
        {
            string Entree;
            int Sortie = 0;

            Entree = txtEntree.Text;
            
            if (Entree[0] == 'b') //Conversion en binaire
                {
                Entree = Entree.Remove(0, 1);
                Int32.TryParse(Entree, out Sortie);
                for (int i=0; Entree.Length > i ; i++)
                {
                    Sortie = Sortie + (int)Math.Pow(2,i)*Entree[Entree.Length-i-1];
                    
                }
                
                
                
                
                
                
                
                
                
                
                
                
                /*int reste;
                string binaire = "";
                Int32.TryParse(Entree, out Sortie);
                for (int i = 0; Sortie > 0; i++)
                {
                    reste = Sortie % 2;
                    Sortie = Sortie / 2;

                    binaire = reste.ToString() + binaire;
                }

                txtDecimal.Text = binaire.ToString();*/
            }
            else if (Entree[0] == '0' && Entree[1] == 'x') //Conversion en Hexa
            {

            }
                else //Conversion en décimal
                {
                txtDecimal.Text = Entree;
                }
        }
    }
}
