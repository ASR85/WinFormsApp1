using System;
using System.Windows.Forms;

namespace CalculSalaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            try
            {
                // R�cup�rer les valeurs entr�es par l'utilisateur
                int joursFormation = int.Parse(txtJoursFormation.Text);
                int joursPresentiel = int.Parse(txtJoursPresentiel.Text);
                double montantFrais = double.Parse(txtMontantFrais.Text);

                // Calculer le nombre d'heures
                int heures = joursFormation * 8;

                // Calculer le salaire total
                double salaireHeures = heures * 2;
                double salaireTaxe = salaireHeures * 0.1009;
                double salaireTotal = salaireHeures - salaireTaxe;

                // Calculer les frais de d�placement
                double fraisDeplacement = joursPresentiel * montantFrais;

                // Calculer la somme totale
                double sommeTotale = salaireTotal + fraisDeplacement;

                // Afficher les r�sultats
                lblSalaireTotal.Text = $"Salaire Total: {salaireTotal:C}";
                lblFraisDeplacement.Text = $"Frais de D�placement: {fraisDeplacement:C}";
                lblSommeTotale.Text = $"Somme Totale: {sommeTotale:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }
    }
}