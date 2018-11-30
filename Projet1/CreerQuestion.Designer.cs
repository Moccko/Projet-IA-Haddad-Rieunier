namespace ProjetIA
{
    partial class CreerQuestion
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
            this.ConsigneTB = new System.Windows.Forms.TextBox();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.ImageBtn = new System.Windows.Forms.Button();
            this.ReponsesCLB = new System.Windows.Forms.CheckedListBox();
            this.ReponseTB = new System.Windows.Forms.TextBox();
            this.AjouterReponseBtn = new System.Windows.Forms.Button();
            this.ValiderQuestionBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConsigneTB
            // 
            this.ConsigneTB.Location = new System.Drawing.Point(207, 33);
            this.ConsigneTB.Name = "ConsigneTB";
            this.ConsigneTB.Size = new System.Drawing.Size(416, 20);
            this.ConsigneTB.TabIndex = 0;
            // 
            // CodeTB
            // 
            this.CodeTB.Location = new System.Drawing.Point(207, 78);
            this.CodeTB.Multiline = true;
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(416, 102);
            this.CodeTB.TabIndex = 1;
            // 
            // ImageBtn
            // 
            this.ImageBtn.Location = new System.Drawing.Point(207, 206);
            this.ImageBtn.Name = "ImageBtn";
            this.ImageBtn.Size = new System.Drawing.Size(416, 23);
            this.ImageBtn.TabIndex = 2;
            this.ImageBtn.Text = "Choisir image";
            this.ImageBtn.UseVisualStyleBackColor = true;
            this.ImageBtn.Click += new System.EventHandler(this.ImageBtn_Click);
            // 
            // ReponsesCLB
            // 
            this.ReponsesCLB.CheckOnClick = true;
            this.ReponsesCLB.FormattingEnabled = true;
            this.ReponsesCLB.Location = new System.Drawing.Point(207, 309);
            this.ReponsesCLB.Name = "ReponsesCLB";
            this.ReponsesCLB.Size = new System.Drawing.Size(416, 139);
            this.ReponsesCLB.TabIndex = 3;
            // 
            // ReponseTB
            // 
            this.ReponseTB.Location = new System.Drawing.Point(207, 263);
            this.ReponseTB.Name = "ReponseTB";
            this.ReponseTB.Size = new System.Drawing.Size(311, 20);
            this.ReponseTB.TabIndex = 4;
            // 
            // AjouterReponseBtn
            // 
            this.AjouterReponseBtn.Location = new System.Drawing.Point(524, 260);
            this.AjouterReponseBtn.Name = "AjouterReponseBtn";
            this.AjouterReponseBtn.Size = new System.Drawing.Size(99, 23);
            this.AjouterReponseBtn.TabIndex = 5;
            this.AjouterReponseBtn.Text = "Ajouter réponse";
            this.AjouterReponseBtn.UseVisualStyleBackColor = true;
            this.AjouterReponseBtn.Click += new System.EventHandler(this.AjouterReponseBtn_Click);
            // 
            // ValiderQuestionBtn
            // 
            this.ValiderQuestionBtn.Location = new System.Drawing.Point(500, 472);
            this.ValiderQuestionBtn.Name = "ValiderQuestionBtn";
            this.ValiderQuestionBtn.Size = new System.Drawing.Size(122, 34);
            this.ValiderQuestionBtn.TabIndex = 6;
            this.ValiderQuestionBtn.Text = "Valider question";
            this.ValiderQuestionBtn.UseVisualStyleBackColor = true;
            this.ValiderQuestionBtn.Click += new System.EventHandler(this.ValiderQuestionBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consigne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Code annexe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Image annexe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Réponse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Réponses (cocher les solutions)";
            // 
            // CreerQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 552);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValiderQuestionBtn);
            this.Controls.Add(this.AjouterReponseBtn);
            this.Controls.Add(this.ReponseTB);
            this.Controls.Add(this.ReponsesCLB);
            this.Controls.Add(this.ImageBtn);
            this.Controls.Add(this.CodeTB);
            this.Controls.Add(this.ConsigneTB);
            this.Name = "CreerQuestion";
            this.Text = "CreerQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsigneTB;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.Button ImageBtn;
        private System.Windows.Forms.CheckedListBox ReponsesCLB;
        private System.Windows.Forms.TextBox ReponseTB;
        private System.Windows.Forms.Button AjouterReponseBtn;
        private System.Windows.Forms.Button ValiderQuestionBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}