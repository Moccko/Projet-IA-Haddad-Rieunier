namespace ProjetIA
{
    partial class AEtoileSalotti
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
            this.init1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AEtoile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.init2 = new System.Windows.Forms.Button();
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.OuvertsLB = new System.Windows.Forms.ListBox();
            this.OuvertsLabel = new System.Windows.Forms.Label();
            this.FermesLB = new System.Windows.Forms.ListBox();
            this.FermesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // init1
            // 
            this.init1.Location = new System.Drawing.Point(35, 22);
            this.init1.Name = "init1";
            this.init1.Size = new System.Drawing.Size(75, 23);
            this.init1.TabIndex = 0;
            this.init1.Text = "Init1";
            this.init1.UseVisualStyleBackColor = true;
            this.init1.Click += new System.EventHandler(this.init1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(311, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "6";
            // 
            // AEtoile
            // 
            this.AEtoile.Location = new System.Drawing.Point(479, 22);
            this.AEtoile.Name = "AEtoile";
            this.AEtoile.Size = new System.Drawing.Size(75, 23);
            this.AEtoile.TabIndex = 3;
            this.AEtoile.Text = "A*";
            this.AEtoile.UseVisualStyleBackColor = true;
            this.AEtoile.Click += new System.EventHandler(this.AEtoile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Noeud initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Noeud final";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(336, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 121);
            this.listBox1.TabIndex = 6;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(479, 77);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 180);
            this.treeView1.TabIndex = 7;
            // 
            // init2
            // 
            this.init2.Location = new System.Drawing.Point(35, 67);
            this.init2.Name = "init2";
            this.init2.Size = new System.Drawing.Size(75, 23);
            this.init2.TabIndex = 8;
            this.init2.Text = "Init2";
            this.init2.UseVisualStyleBackColor = true;
            this.init2.Click += new System.EventHandler(this.init2_Click);
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(171, 93);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(100, 121);
            this.listBoxgraphe.TabIndex = 9;
            // 
            // OuvertsLB
            // 
            this.OuvertsLB.FormattingEnabled = true;
            this.OuvertsLB.Location = new System.Drawing.Point(336, 296);
            this.OuvertsLB.Name = "OuvertsLB";
            this.OuvertsLB.Size = new System.Drawing.Size(127, 147);
            this.OuvertsLB.TabIndex = 10;
            // 
            // OuvertsLabel
            // 
            this.OuvertsLabel.AutoSize = true;
            this.OuvertsLabel.Location = new System.Drawing.Point(333, 280);
            this.OuvertsLabel.Name = "OuvertsLabel";
            this.OuvertsLabel.Size = new System.Drawing.Size(44, 13);
            this.OuvertsLabel.TabIndex = 11;
            this.OuvertsLabel.Text = "Ouverts";
            // 
            // FermesLB
            // 
            this.FermesLB.FormattingEnabled = true;
            this.FermesLB.Location = new System.Drawing.Point(171, 296);
            this.FermesLB.Name = "FermesLB";
            this.FermesLB.Size = new System.Drawing.Size(128, 147);
            this.FermesLB.TabIndex = 12;
            // 
            // FermesLabel
            // 
            this.FermesLabel.AutoSize = true;
            this.FermesLabel.Location = new System.Drawing.Point(168, 280);
            this.FermesLabel.Name = "FermesLabel";
            this.FermesLabel.Size = new System.Drawing.Size(41, 13);
            this.FermesLabel.TabIndex = 13;
            this.FermesLabel.Text = "Fermés";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.FermesLabel);
            this.Controls.Add(this.FermesLB);
            this.Controls.Add(this.OuvertsLabel);
            this.Controls.Add(this.OuvertsLB);
            this.Controls.Add(this.listBoxgraphe);
            this.Controls.Add(this.init2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AEtoile);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.init1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button init1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AEtoile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button init2;
        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.ListBox OuvertsLB;
        private System.Windows.Forms.Label OuvertsLabel;
        private System.Windows.Forms.ListBox FermesLB;
        private System.Windows.Forms.Label FermesLabel;
    }
}

