namespace ProjetIA
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DijkstraBtn = new System.Windows.Forms.Button();
            this.AEtoile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Démarrer le questionnaire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "Créer questions";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DijkstraBtn
            // 
            this.DijkstraBtn.Location = new System.Drawing.Point(188, 338);
            this.DijkstraBtn.Name = "DijkstraBtn";
            this.DijkstraBtn.Size = new System.Drawing.Size(75, 23);
            this.DijkstraBtn.TabIndex = 3;
            this.DijkstraBtn.Text = "Dijkstra";
            this.DijkstraBtn.UseVisualStyleBackColor = true;
            this.DijkstraBtn.Click += new System.EventHandler(this.DijkstraBtn_Click);
            // 
            // AEtoile
            // 
            this.AEtoile.Location = new System.Drawing.Point(316, 338);
            this.AEtoile.Name = "AEtoile";
            this.AEtoile.Size = new System.Drawing.Size(75, 23);
            this.AEtoile.TabIndex = 4;
            this.AEtoile.Text = "A*";
            this.AEtoile.UseVisualStyleBackColor = true;
            this.AEtoile.Click += new System.EventHandler(this.AEtoile_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 431);
            this.Controls.Add(this.AEtoile);
            this.Controls.Add(this.DijkstraBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DijkstraBtn;
        private System.Windows.Forms.Button AEtoile;
    }
}

