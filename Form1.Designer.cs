namespace CalculSalaire
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtJoursFormation = new System.Windows.Forms.TextBox();
            this.txtJoursPresentiel = new System.Windows.Forms.TextBox();
            this.txtMontantFrais = new System.Windows.Forms.TextBox();
            this.lblJoursFormation = new System.Windows.Forms.Label();
            this.lblJoursPresentiel = new System.Windows.Forms.Label();
            this.lblMontantFrais = new System.Windows.Forms.Label();
            this.lblSalaireTotal = new System.Windows.Forms.Label();
            this.lblFraisDeplacement = new System.Windows.Forms.Label();
            this.lblSommeTotale = new System.Windows.Forms.Label();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJoursFormation
            // 
            this.txtJoursFormation.Location = new System.Drawing.Point(180, 12);
            this.txtJoursFormation.Name = "txtJoursFormation";
            this.txtJoursFormation.Size = new System.Drawing.Size(100, 20);
            this.txtJoursFormation.TabIndex = 0;
            // 
            // txtJoursPresentiel
            // 
            this.txtJoursPresentiel.Location = new System.Drawing.Point(180, 38);
            this.txtJoursPresentiel.Name = "txtJoursPresentiel";
            this.txtJoursPresentiel.Size = new System.Drawing.Size(100, 20);
            this.txtJoursPresentiel.TabIndex = 1;
            // 
            // txtMontantFrais
            // 
            this.txtMontantFrais.Location = new System.Drawing.Point(180, 64);
            this.txtMontantFrais.Name = "txtMontantFrais";
            this.txtMontantFrais.Size = new System.Drawing.Size(100, 20);
            this.txtMontantFrais.TabIndex = 2;
            // 
            // lblJoursFormation
            // 
            this.lblJoursFormation.AutoSize = true;
            this.lblJoursFormation.Location = new System.Drawing.Point(12, 15);
            this.lblJoursFormation.Name = "lblJoursFormation";
            this.lblJoursFormation.Size = new System.Drawing.Size(162, 13);
            this.lblJoursFormation.TabIndex = 5;
            this.lblJoursFormation.Text = "Nombre de jours de formation :";
            // 
            // lblJoursPresentiel
            // 
            this.lblJoursPresentiel.AutoSize = true;
            this.lblJoursPresentiel.Location = new System.Drawing.Point(12, 41);
            this.lblJoursPresentiel.Name = "lblJoursPresentiel";
            this.lblJoursPresentiel.Size = new System.Drawing.Size(162, 13);
            this.lblJoursPresentiel.TabIndex = 6;
            this.lblJoursPresentiel.Text = "Nombre de jours présentiel :";
            // 
            // lblMontantFrais
            // 
            this.lblMontantFrais.AutoSize = true;
            this.lblMontantFrais.Location = new System.Drawing.Point(12, 67);
            this.lblMontantFrais.Name = "lblMontantFrais";
            this.lblMontantFrais.Size = new System.Drawing.Size(162, 13);
            this.lblMontantFrais.TabIndex = 7;
            this.lblMontantFrais.Text = "Frais déplacement / jour :";
            // 
            // lblSalaireTotal
            // 
            this.lblSalaireTotal.AutoSize = true;
            this.lblSalaireTotal.Location = new System.Drawing.Point(12, 90);
            this.lblSalaireTotal.Name = "lblSalaireTotal";
            this.lblSalaireTotal.Size = new System.Drawing.Size(70, 13);
            this.lblSalaireTotal.TabIndex = 2;
            this.lblSalaireTotal.Text = "Montant après taxes :";
            // 
            // lblFraisDeplacement
            // 
            this.lblFraisDeplacement.AutoSize = true;
            this.lblFraisDeplacement.Location = new System.Drawing.Point(12, 113);
            this.lblFraisDeplacement.Name = "lblFraisDeplacement";
            this.lblFraisDeplacement.Size = new System.Drawing.Size(103, 13);
            this.lblFraisDeplacement.TabIndex = 3;
            this.lblFraisDeplacement.Text = "Frais de Déplacement :";
            // 
            // lblSommeTotale
            // 
            this.lblSommeTotale.AutoSize = true;
            this.lblSommeTotale.Location = new System.Drawing.Point(12, 136);
            this.lblSommeTotale.Name = "lblSommeTotale";
            this.lblSommeTotale.Size = new System.Drawing.Size(79, 13);
            this.lblSommeTotale.TabIndex = 8;
            this.lblSommeTotale.Text = "Montant final :";
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(12, 162);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(75, 23);
            this.btnCalculer.TabIndex = 4;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 201);
            this.Controls.Add(this.lblSommeTotale);
            this.Controls.Add(this.lblMontantFrais);
            this.Controls.Add(this.lblJoursPresentiel);
            this.Controls.Add(this.lblJoursFormation);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.lblFraisDeplacement);
            this.Controls.Add(this.lblSalaireTotal);
            this.Controls.Add(this.txtMontantFrais);
            this.Controls.Add(this.txtJoursPresentiel);
            this.Controls.Add(this.txtJoursFormation);
            this.Name = "Form1";
            this.Text = "Calcul Salaire";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtJoursFormation;
        private System.Windows.Forms.TextBox txtJoursPresentiel;
        private System.Windows.Forms.TextBox txtMontantFrais;
        private System.Windows.Forms.Label lblJoursFormation;
        private System.Windows.Forms.Label lblJoursPresentiel;
        private System.Windows.Forms.Label lblMontantFrais;
        private System.Windows.Forms.Label lblSalaireTotal;
        private System.Windows.Forms.Label lblFraisDeplacement;
        private System.Windows.Forms.Label lblSommeTotale;
        private System.Windows.Forms.Button btnCalculer;
    }
}