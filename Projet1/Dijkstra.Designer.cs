namespace ProjetIA
{
    partial class Dijkstra
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("A");
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
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
            this.DijkstraTV = new System.Windows.Forms.TreeView();
            this.DijkstraFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.DijkstraLb = new System.Windows.Forms.Label();
            this.ValiderArbreBtn = new System.Windows.Forms.Button();
            this.ValiderBtn = new System.Windows.Forms.Button();
            this.GraphePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GraphePB)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(633, 558);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(21, 17);
            this.listBox1.TabIndex = 6;
            this.listBox1.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(801, 347);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(10, 173);
            this.treeView1.TabIndex = 7;
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(607, 558);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(21, 17);
            this.listBoxgraphe.TabIndex = 9;
            this.listBoxgraphe.Visible = false;
            // 
            // OuvertsLB
            // 
            this.OuvertsLB.FormattingEnabled = true;
            this.OuvertsLB.Location = new System.Drawing.Point(683, 558);
            this.OuvertsLB.Name = "OuvertsLB";
            this.OuvertsLB.Size = new System.Drawing.Size(19, 17);
            this.OuvertsLB.TabIndex = 10;
            this.OuvertsLB.Visible = false;
            // 
            // OuvertsLabel
            // 
            this.OuvertsLabel.AutoSize = true;
            this.OuvertsLabel.Location = new System.Drawing.Point(748, 560);
            this.OuvertsLabel.Name = "OuvertsLabel";
            this.OuvertsLabel.Size = new System.Drawing.Size(44, 13);
            this.OuvertsLabel.TabIndex = 11;
            this.OuvertsLabel.Text = "Ouverts";
            this.OuvertsLabel.Visible = false;
            // 
            // FermesLB
            // 
            this.FermesLB.FormattingEnabled = true;
            this.FermesLB.Location = new System.Drawing.Point(660, 558);
            this.FermesLB.Name = "FermesLB";
            this.FermesLB.Size = new System.Drawing.Size(17, 17);
            this.FermesLB.TabIndex = 12;
            this.FermesLB.Visible = false;
            // 
            // FermesLabel
            // 
            this.FermesLabel.AutoSize = true;
            this.FermesLabel.Location = new System.Drawing.Point(701, 560);
            this.FermesLabel.Name = "FermesLabel";
            this.FermesLabel.Size = new System.Drawing.Size(41, 13);
            this.FermesLabel.TabIndex = 13;
            this.FermesLabel.Text = "Fermés";
            this.FermesLabel.Visible = false;
            // 
            // UserOuvertsLB
            // 
            this.UserOuvertsLB.FormattingEnabled = true;
            this.UserOuvertsLB.Location = new System.Drawing.Point(324, 347);
            this.UserOuvertsLB.Name = "UserOuvertsLB";
            this.UserOuvertsLB.Size = new System.Drawing.Size(133, 173);
            this.UserOuvertsLB.TabIndex = 14;
            // 
            // UserFermesLB
            // 
            this.UserFermesLB.FormattingEnabled = true;
            this.UserFermesLB.Location = new System.Drawing.Point(13, 347);
            this.UserFermesLB.Name = "UserFermesLB";
            this.UserFermesLB.Size = new System.Drawing.Size(133, 173);
            this.UserFermesLB.TabIndex = 15;
            // 
            // UserFLb
            // 
            this.UserFLb.AutoSize = true;
            this.UserFLb.Location = new System.Drawing.Point(10, 331);
            this.UserFLb.Name = "UserFLb";
            this.UserFLb.Size = new System.Drawing.Size(41, 13);
            this.UserFLb.TabIndex = 16;
            this.UserFLb.Text = "Fermés";
            // 
            // UserOLb
            // 
            this.UserOLb.AutoSize = true;
            this.UserOLb.Location = new System.Drawing.Point(321, 331);
            this.UserOLb.Name = "UserOLb";
            this.UserOLb.Size = new System.Drawing.Size(44, 13);
            this.UserOLb.TabIndex = 17;
            this.UserOLb.Text = "Ouverts";
            // 
            // OuvertsFLP
            // 
            this.OuvertsFLP.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.OuvertsFLP.Location = new System.Drawing.Point(238, 347);
            this.OuvertsFLP.Name = "OuvertsFLP";
            this.OuvertsFLP.Size = new System.Drawing.Size(80, 144);
            this.OuvertsFLP.TabIndex = 33;
            // 
            // FermesFLP
            // 
            this.FermesFLP.Location = new System.Drawing.Point(152, 347);
            this.FermesFLP.Name = "FermesFLP";
            this.FermesFLP.Size = new System.Drawing.Size(80, 144);
            this.FermesFLP.TabIndex = 34;
            // 
            // ValiderLigneBtn
            // 
            this.ValiderLigneBtn.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderLigneBtn.Location = new System.Drawing.Point(152, 497);
            this.ValiderLigneBtn.Name = "ValiderLigneBtn";
            this.ValiderLigneBtn.Size = new System.Drawing.Size(166, 23);
            this.ValiderLigneBtn.TabIndex = 35;
            this.ValiderLigneBtn.Text = "Valider ligne";
            this.ValiderLigneBtn.UseVisualStyleBackColor = true;
            this.ValiderLigneBtn.EnabledChanged += new System.EventHandler(this.ValiderLigneBtn_EnabledChanged);
            this.ValiderLigneBtn.Click += new System.EventHandler(this.ValiderLigneBtn_Click);
            // 
            // DijkstraTV
            // 
            this.DijkstraTV.Location = new System.Drawing.Point(666, 347);
            this.DijkstraTV.Name = "DijkstraTV";
            treeNode2.Name = "A";
            treeNode2.Text = "A";
            this.DijkstraTV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.DijkstraTV.Size = new System.Drawing.Size(146, 173);
            this.DijkstraTV.TabIndex = 36;
            // 
            // DijkstraFLP
            // 
            this.DijkstraFLP.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.DijkstraFLP.Location = new System.Drawing.Point(580, 347);
            this.DijkstraFLP.Name = "DijkstraFLP";
            this.DijkstraFLP.Size = new System.Drawing.Size(80, 144);
            this.DijkstraFLP.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(653, 31);
            this.label3.TabIndex = 37;
            this.label3.Text = "Appliquez l\'algorithme de Dijkstra à ce graphe";
            // 
            // DijkstraLb
            // 
            this.DijkstraLb.AutoSize = true;
            this.DijkstraLb.Location = new System.Drawing.Point(666, 331);
            this.DijkstraLb.Name = "DijkstraLb";
            this.DijkstraLb.Size = new System.Drawing.Size(54, 13);
            this.DijkstraLb.TabIndex = 38;
            this.DijkstraLb.Text = "Arbre final";
            // 
            // ValiderArbreBtn
            // 
            this.ValiderArbreBtn.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderArbreBtn.Location = new System.Drawing.Point(580, 497);
            this.ValiderArbreBtn.Name = "ValiderArbreBtn";
            this.ValiderArbreBtn.Size = new System.Drawing.Size(80, 23);
            this.ValiderArbreBtn.TabIndex = 39;
            this.ValiderArbreBtn.Text = "Valider arbre";
            this.ValiderArbreBtn.UseVisualStyleBackColor = true;
            this.ValiderArbreBtn.EnabledChanged += new System.EventHandler(this.ValiderArbreBtn_EnabledChanged);
            this.ValiderArbreBtn.Click += new System.EventHandler(this.ValiderArbreBtn_Click);
            // 
            // ValiderBtn
            // 
            this.ValiderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValiderBtn.Enabled = false;
            this.ValiderBtn.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderBtn.Location = new System.Drawing.Point(237, 545);
            this.ValiderBtn.MinimumSize = new System.Drawing.Size(344, 39);
            this.ValiderBtn.Name = "ValiderBtn";
            this.ValiderBtn.Size = new System.Drawing.Size(344, 39);
            this.ValiderBtn.TabIndex = 41;
            this.ValiderBtn.Text = "Valider ►";
            this.ValiderBtn.UseVisualStyleBackColor = true;
            this.ValiderBtn.Click += new System.EventHandler(this.ValiderBtn_Click);
            // 
            // GraphePB
            // 
            this.GraphePB.Location = new System.Drawing.Point(-8, 75);
            this.GraphePB.Name = "GraphePB";
            this.GraphePB.Size = new System.Drawing.Size(838, 243);
            this.GraphePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GraphePB.TabIndex = 42;
            this.GraphePB.TabStop = false;
            // 
            // AEtoileSalotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 596);
            this.Controls.Add(this.GraphePB);
            this.Controls.Add(this.ValiderBtn);
            this.Controls.Add(this.ValiderArbreBtn);
            this.Controls.Add(this.DijkstraLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DijkstraFLP);
            this.Controls.Add(this.DijkstraTV);
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
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Name = "AEtoileSalotti";
            this.Text = "Algorithme Dijkstra";
            ((System.ComponentModel.ISupportInitialize)(this.GraphePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
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
        private System.Windows.Forms.TreeView DijkstraTV;
        private System.Windows.Forms.FlowLayoutPanel DijkstraFLP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DijkstraLb;
        private System.Windows.Forms.Button ValiderArbreBtn;
        private System.Windows.Forms.Button ValiderBtn;
        private System.Windows.Forms.PictureBox GraphePB;
    }
}

