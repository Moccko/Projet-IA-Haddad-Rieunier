namespace Projet1
{
    partial class ExoDijkstra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExoDijkstra));
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("A");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("B");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("F");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("E", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("C", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("D");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("A", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12,
            treeNode13});
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DijkstraTV = new System.Windows.Forms.TreeView();
            this.ABtn = new System.Windows.Forms.Button();
            this.BBtn = new System.Windows.Forms.Button();
            this.CBtn = new System.Windows.Forms.Button();
            this.DBtn = new System.Windows.Forms.Button();
            this.ConsigneLb = new System.Windows.Forms.Label();
            this.CompareTV = new System.Windows.Forms.TreeView();
            this.CompareBtn = new System.Windows.Forms.Button();
            this.EBtn = new System.Windows.Forms.Button();
            this.FBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DijkstraTV
            // 
            this.DijkstraTV.Location = new System.Drawing.Point(42, 275);
            this.DijkstraTV.Name = "DijkstraTV";
            treeNode8.Name = "A";
            treeNode8.Text = "A";
            this.DijkstraTV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.DijkstraTV.Size = new System.Drawing.Size(217, 257);
            this.DijkstraTV.TabIndex = 1;
            // 
            // ABtn
            // 
            this.ABtn.Location = new System.Drawing.Point(265, 275);
            this.ABtn.Name = "ABtn";
            this.ABtn.Size = new System.Drawing.Size(75, 23);
            this.ABtn.TabIndex = 2;
            this.ABtn.Text = "A";
            this.ABtn.UseVisualStyleBackColor = true;
            this.ABtn.Click += new System.EventHandler(this.ABtn_Click);
            // 
            // BBtn
            // 
            this.BBtn.Location = new System.Drawing.Point(346, 275);
            this.BBtn.Name = "BBtn";
            this.BBtn.Size = new System.Drawing.Size(75, 23);
            this.BBtn.TabIndex = 3;
            this.BBtn.Text = "B";
            this.BBtn.UseVisualStyleBackColor = true;
            this.BBtn.Click += new System.EventHandler(this.BBtn_Click);
            // 
            // CBtn
            // 
            this.CBtn.Location = new System.Drawing.Point(265, 304);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(75, 23);
            this.CBtn.TabIndex = 4;
            this.CBtn.Text = "C";
            this.CBtn.UseVisualStyleBackColor = true;
            this.CBtn.Click += new System.EventHandler(this.CBtn_Click);
            // 
            // DBtn
            // 
            this.DBtn.Location = new System.Drawing.Point(346, 304);
            this.DBtn.Name = "DBtn";
            this.DBtn.Size = new System.Drawing.Size(75, 23);
            this.DBtn.TabIndex = 5;
            this.DBtn.Text = "D";
            this.DBtn.UseVisualStyleBackColor = true;
            this.DBtn.Click += new System.EventHandler(this.DBtn_Click);
            // 
            // ConsigneLb
            // 
            this.ConsigneLb.AutoSize = true;
            this.ConsigneLb.Location = new System.Drawing.Point(396, 56);
            this.ConsigneLb.Name = "ConsigneLb";
            this.ConsigneLb.Size = new System.Drawing.Size(211, 13);
            this.ConsigneLb.TabIndex = 6;
            this.ConsigneLb.Text = "Effectuez la trace de Dijkstra sur ce graphe";
            // 
            // CompareTV
            // 
            this.CompareTV.Location = new System.Drawing.Point(427, 274);
            this.CompareTV.Name = "CompareTV";
            treeNode9.Name = "Nœud2";
            treeNode9.Text = "B";
            treeNode10.Name = "Nœud7";
            treeNode10.Text = "F";
            treeNode11.Name = "Nœud5";
            treeNode11.Text = "E";
            treeNode12.Name = "Nœud4";
            treeNode12.Text = "C";
            treeNode13.Name = "Nœud6";
            treeNode13.Text = "D";
            treeNode14.Name = "Nœud0";
            treeNode14.Text = "A";
            this.CompareTV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.CompareTV.Size = new System.Drawing.Size(214, 257);
            this.CompareTV.TabIndex = 7;
            // 
            // CompareBtn
            // 
            this.CompareBtn.Location = new System.Drawing.Point(265, 508);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(156, 23);
            this.CompareBtn.TabIndex = 8;
            this.CompareBtn.Text = "Comparer";
            this.CompareBtn.UseVisualStyleBackColor = true;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // EBtn
            // 
            this.EBtn.Location = new System.Drawing.Point(265, 333);
            this.EBtn.Name = "EBtn";
            this.EBtn.Size = new System.Drawing.Size(75, 23);
            this.EBtn.TabIndex = 9;
            this.EBtn.Text = "E";
            this.EBtn.UseVisualStyleBackColor = true;
            this.EBtn.Click += new System.EventHandler(this.EBtn_Click);
            // 
            // FBtn
            // 
            this.FBtn.Location = new System.Drawing.Point(346, 333);
            this.FBtn.Name = "FBtn";
            this.FBtn.Size = new System.Drawing.Size(75, 23);
            this.FBtn.TabIndex = 10;
            this.FBtn.Text = "F";
            this.FBtn.UseVisualStyleBackColor = true;
            this.FBtn.Click += new System.EventHandler(this.FBtn_Click);
            // 
            // ExoDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 596);
            this.Controls.Add(this.FBtn);
            this.Controls.Add(this.EBtn);
            this.Controls.Add(this.CompareBtn);
            this.Controls.Add(this.CompareTV);
            this.Controls.Add(this.ConsigneLb);
            this.Controls.Add(this.DBtn);
            this.Controls.Add(this.CBtn);
            this.Controls.Add(this.BBtn);
            this.Controls.Add(this.ABtn);
            this.Controls.Add(this.DijkstraTV);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ExoDijkstra";
            this.Text = "ExoDijkstra";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView DijkstraTV;
        private System.Windows.Forms.Button ABtn;
        private System.Windows.Forms.Button BBtn;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.Button DBtn;
        private System.Windows.Forms.Label ConsigneLb;
        private System.Windows.Forms.TreeView CompareTV;
        private System.Windows.Forms.Button CompareBtn;
        private System.Windows.Forms.Button EBtn;
        private System.Windows.Forms.Button FBtn;
    }
}