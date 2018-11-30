namespace ProjetIA
{
    partial class Questionnaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questionnaire));
            this.ConsigneLb = new System.Windows.Forms.Label();
            this.ReponsesCLB = new System.Windows.Forms.CheckedListBox();
            this.ImagePB = new System.Windows.Forms.PictureBox();
            this.CodeLb = new System.Windows.Forms.Label();
            this.ValiderBtn = new System.Windows.Forms.Button();
            this.BonnesReponsesLb = new System.Windows.Forms.Label();
            this.StatutLb = new System.Windows.Forms.Label();
            this.NoQuestionLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsigneLb
            // 
            this.ConsigneLb.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsigneLb.Location = new System.Drawing.Point(63, 92);
            this.ConsigneLb.Name = "ConsigneLb";
            this.ConsigneLb.Size = new System.Drawing.Size(344, 209);
            this.ConsigneLb.TabIndex = 1;
            this.ConsigneLb.Text = "uzebfueqbueqrueqruuzebfueqbueqrueqruuzebfueqbueqrueqruuzebfueqbueqrueqruuzebfueqb" +
    "ueqrueqruuzebfueq";
            // 
            // ReponsesCLB
            // 
            this.ReponsesCLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReponsesCLB.CheckOnClick = true;
            this.ReponsesCLB.FormattingEnabled = true;
            this.ReponsesCLB.HorizontalScrollbar = true;
            this.ReponsesCLB.Location = new System.Drawing.Point(63, 323);
            this.ReponsesCLB.MinimumSize = new System.Drawing.Size(344, 184);
            this.ReponsesCLB.Name = "ReponsesCLB";
            this.ReponsesCLB.Size = new System.Drawing.Size(344, 184);
            this.ReponsesCLB.TabIndex = 1;
            // 
            // ImagePB
            // 
            this.ImagePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePB.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImagePB.InitialImage")));
            this.ImagePB.Location = new System.Drawing.Point(433, 92);
            this.ImagePB.Name = "ImagePB";
            this.ImagePB.Size = new System.Drawing.Size(320, 460);
            this.ImagePB.TabIndex = 0;
            this.ImagePB.TabStop = false;
            // 
            // CodeLb
            // 
            this.CodeLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeLb.AutoSize = true;
            this.CodeLb.Font = new System.Drawing.Font("Source Code Pro Semibold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeLb.Location = new System.Drawing.Point(430, 92);
            this.CodeLb.Name = "CodeLb";
            this.CodeLb.Size = new System.Drawing.Size(56, 17);
            this.CodeLb.TabIndex = 0;
            this.CodeLb.Text = "label1";
            // 
            // ValiderBtn
            // 
            this.ValiderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValiderBtn.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderBtn.Location = new System.Drawing.Point(63, 513);
            this.ValiderBtn.MinimumSize = new System.Drawing.Size(344, 39);
            this.ValiderBtn.Name = "ValiderBtn";
            this.ValiderBtn.Size = new System.Drawing.Size(344, 39);
            this.ValiderBtn.TabIndex = 1;
            this.ValiderBtn.Text = "Valider ►";
            this.ValiderBtn.UseVisualStyleBackColor = true;
            this.ValiderBtn.Click += new System.EventHandler(this.ValiderBtn_Click);
            // 
            // BonnesReponsesLb
            // 
            this.BonnesReponsesLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BonnesReponsesLb.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonnesReponsesLb.Location = new System.Drawing.Point(497, 47);
            this.BonnesReponsesLb.Name = "BonnesReponsesLb";
            this.BonnesReponsesLb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BonnesReponsesLb.Size = new System.Drawing.Size(256, 24);
            this.BonnesReponsesLb.TabIndex = 0;
            this.BonnesReponsesLb.Text = "0 bonne réponse";
            this.BonnesReponsesLb.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StatutLb
            // 
            this.StatutLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatutLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatutLb.Location = new System.Drawing.Point(63, 301);
            this.StatutLb.MinimumSize = new System.Drawing.Size(344, 19);
            this.StatutLb.Name = "StatutLb";
            this.StatutLb.Size = new System.Drawing.Size(344, 19);
            this.StatutLb.TabIndex = 1;
            this.StatutLb.Text = "Correction";
            this.StatutLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NoQuestionLb
            // 
            this.NoQuestionLb.AutoSize = true;
            this.NoQuestionLb.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoQuestionLb.Location = new System.Drawing.Point(61, 40);
            this.NoQuestionLb.Name = "NoQuestionLb";
            this.NoQuestionLb.Size = new System.Drawing.Size(251, 31);
            this.NoQuestionLb.TabIndex = 1;
            this.NoQuestionLb.Text = "Question 0 sur 10";
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 596);
            this.Controls.Add(this.ValiderBtn);
            this.Controls.Add(this.ReponsesCLB);
            this.Controls.Add(this.StatutLb);
            this.Controls.Add(this.ConsigneLb);
            this.Controls.Add(this.NoQuestionLb);
            this.Controls.Add(this.BonnesReponsesLb);
            this.Controls.Add(this.CodeLb);
            this.Controls.Add(this.ImagePB);
            this.Name = "Questionnaire";
            this.Text = "Questionnaire";
            ((System.ComponentModel.ISupportInitialize)(this.ImagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConsigneLb;
        private System.Windows.Forms.CheckedListBox ReponsesCLB;
        private System.Windows.Forms.PictureBox ImagePB;
        private System.Windows.Forms.Label CodeLb;
        private System.Windows.Forms.Button ValiderBtn;
        private System.Windows.Forms.Label BonnesReponsesLb;
        private System.Windows.Forms.Label StatutLb;
        private System.Windows.Forms.Label NoQuestionLb;
    }
}