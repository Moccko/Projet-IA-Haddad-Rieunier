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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AEtoile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.init = new System.Windows.Forms.Button();
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.OuvertsLB = new System.Windows.Forms.ListBox();
            this.OuvertsLabel = new System.Windows.Forms.Label();
            this.FermesLB = new System.Windows.Forms.ListBox();
            this.FermesLabel = new System.Windows.Forms.Label();
            this.UserOuvertsLB = new System.Windows.Forms.ListBox();
            this.UserFermesLB = new System.Windows.Forms.ListBox();
            this.UserFLb = new System.Windows.Forms.Label();
            this.UserOLb = new System.Windows.Forms.Label();
            this.OuvertsFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.FermesFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.ValiderLigneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // init
            // 
            this.init.Location = new System.Drawing.Point(34, 38);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(75, 23);
            this.init.TabIndex = 8;
            this.init.Text = "Init";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.init_Click);
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
            this.OuvertsLB.Location = new System.Drawing.Point(575, 291);
            this.OuvertsLB.Name = "OuvertsLB";
            this.OuvertsLB.Size = new System.Drawing.Size(88, 147);
            this.OuvertsLB.TabIndex = 10;
            // 
            // OuvertsLabel
            // 
            this.OuvertsLabel.AutoSize = true;
            this.OuvertsLabel.Location = new System.Drawing.Point(572, 275);
            this.OuvertsLabel.Name = "OuvertsLabel";
            this.OuvertsLabel.Size = new System.Drawing.Size(44, 13);
            this.OuvertsLabel.TabIndex = 11;
            this.OuvertsLabel.Text = "Ouverts";
            // 
            // FermesLB
            // 
            this.FermesLB.FormattingEnabled = true;
            this.FermesLB.Location = new System.Drawing.Point(465, 291);
            this.FermesLB.Name = "FermesLB";
            this.FermesLB.Size = new System.Drawing.Size(89, 147);
            this.FermesLB.TabIndex = 12;
            // 
            // FermesLabel
            // 
            this.FermesLabel.AutoSize = true;
            this.FermesLabel.Location = new System.Drawing.Point(462, 275);
            this.FermesLabel.Name = "FermesLabel";
            this.FermesLabel.Size = new System.Drawing.Size(41, 13);
            this.FermesLabel.TabIndex = 13;
            this.FermesLabel.Text = "Fermés";
            // 
            // UserOuvertsLB
            // 
            this.UserOuvertsLB.FormattingEnabled = true;
            this.UserOuvertsLB.Location = new System.Drawing.Point(362, 291);
            this.UserOuvertsLB.Name = "UserOuvertsLB";
            this.UserOuvertsLB.Size = new System.Drawing.Size(97, 147);
            this.UserOuvertsLB.TabIndex = 14;
            // 
            // UserFermesLB
            // 
            this.UserFermesLB.FormattingEnabled = true;
            this.UserFermesLB.Location = new System.Drawing.Point(12, 291);
            this.UserFermesLB.Name = "UserFermesLB";
            this.UserFermesLB.Size = new System.Drawing.Size(97, 147);
            this.UserFermesLB.TabIndex = 15;
            // 
            // UserFLb
            // 
            this.UserFLb.AutoSize = true;
            this.UserFLb.Location = new System.Drawing.Point(13, 274);
            this.UserFLb.Name = "UserFLb";
            this.UserFLb.Size = new System.Drawing.Size(41, 13);
            this.UserFLb.TabIndex = 16;
            this.UserFLb.Text = "Fermés";
            // 
            // UserOLb
            // 
            this.UserOLb.AutoSize = true;
            this.UserOLb.Location = new System.Drawing.Point(362, 273);
            this.UserOLb.Name = "UserOLb";
            this.UserOLb.Size = new System.Drawing.Size(44, 13);
            this.UserOLb.TabIndex = 17;
            this.UserOLb.Text = "Ouverts";
            // 
            // OuvertsFLP
            // 
            this.OuvertsFLP.Location = new System.Drawing.Point(286, 291);
            this.OuvertsFLP.Name = "OuvertsFLP";
            this.OuvertsFLP.Size = new System.Drawing.Size(70, 147);
            this.OuvertsFLP.TabIndex = 33;
            // 
            // FermesFLP
            // 
            this.FermesFLP.Location = new System.Drawing.Point(116, 291);
            this.FermesFLP.Name = "FermesFLP";
            this.FermesFLP.Size = new System.Drawing.Size(68, 147);
            this.FermesFLP.TabIndex = 34;
            // 
            // ValiderLigneBtn
            // 
            this.ValiderLigneBtn.Location = new System.Drawing.Point(191, 414);
            this.ValiderLigneBtn.Name = "ValiderLigneBtn";
            this.ValiderLigneBtn.Size = new System.Drawing.Size(89, 23);
            this.ValiderLigneBtn.TabIndex = 35;
            this.ValiderLigneBtn.Text = "Valider ligne";
            this.ValiderLigneBtn.UseVisualStyleBackColor = true;
            this.ValiderLigneBtn.Click += new System.EventHandler(this.ValiderLigneBtn_Click);
            // 
            // AEtoileSalotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.ValiderLigneBtn);
            this.Controls.Add(this.FermesFLP);
            this.Controls.Add(this.OuvertsFLP);
            this.Controls.Add(this.UserOLb);
            this.Controls.Add(this.UserFLb);
            this.Controls.Add(this.UserFermesLB);
            this.Controls.Add(this.UserOuvertsLB);
            this.Controls.Add(this.FermesLabel);
            this.Controls.Add(this.FermesLB);
            this.Controls.Add(this.OuvertsLabel);
            this.Controls.Add(this.OuvertsLB);
            this.Controls.Add(this.listBoxgraphe);
            this.Controls.Add(this.init);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AEtoile);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AEtoileSalotti";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AEtoile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button init;
        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.ListBox OuvertsLB;
        private System.Windows.Forms.Label OuvertsLabel;
        private System.Windows.Forms.ListBox FermesLB;
        private System.Windows.Forms.Label FermesLabel;
        private System.Windows.Forms.ListBox UserOuvertsLB;
        private System.Windows.Forms.ListBox UserFermesLB;
        private System.Windows.Forms.Label UserFLb;
        private System.Windows.Forms.Label UserOLb;
        private System.Windows.Forms.FlowLayoutPanel OuvertsFLP;
        private System.Windows.Forms.FlowLayoutPanel FermesFLP;
        private System.Windows.Forms.Button ValiderLigneBtn;
    }
}

