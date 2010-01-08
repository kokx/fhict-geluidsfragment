namespace Hilversum
{
    partial class GeluidsfragmentForm
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
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbBestandsnaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpeel = new System.Windows.Forms.Button();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.tbNr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btBrowse = new System.Windows.Forms.Button();
            this.btnMaakaan = new System.Windows.Forms.Button();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.tbFragmentNr = new System.Windows.Forms.TextBox();
            this.lbAfspeelInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelCreate.SuspendLayout();
            this.panelPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(98, 41);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(287, 20);
            this.tbTitel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titel:";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(98, 67);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(40, 20);
            this.tbMin.TabIndex = 1;
            // 
            // tbBestandsnaam
            // 
            this.tbBestandsnaam.Location = new System.Drawing.Point(98, 93);
            this.tbBestandsnaam.Name = "tbBestandsnaam";
            this.tbBestandsnaam.Size = new System.Drawing.Size(287, 20);
            this.tbBestandsnaam.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tijdsduur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bestandsnaam:";
            // 
            // tbSec
            // 
            this.tbSec.Location = new System.Drawing.Point(172, 67);
            this.tbSec.Name = "tbSec";
            this.tbSec.Size = new System.Drawing.Size(40, 20);
            this.tbSec.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "sec";
            // 
            // btnSpeel
            // 
            this.btnSpeel.Location = new System.Drawing.Point(15, 12);
            this.btnSpeel.Name = "btnSpeel";
            this.btnSpeel.Size = new System.Drawing.Size(75, 22);
            this.btnSpeel.TabIndex = 9;
            this.btnSpeel.Text = "Speel af";
            this.btnSpeel.UseVisualStyleBackColor = true;
            this.btnSpeel.Click += new System.EventHandler(this.bntSpeel_Click);
            // 
            // panelCreate
            // 
            this.panelCreate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCreate.Controls.Add(this.tbNr);
            this.panelCreate.Controls.Add(this.label7);
            this.panelCreate.Controls.Add(this.btBrowse);
            this.panelCreate.Controls.Add(this.label1);
            this.panelCreate.Controls.Add(this.tbTitel);
            this.panelCreate.Controls.Add(this.tbMin);
            this.panelCreate.Controls.Add(this.tbBestandsnaam);
            this.panelCreate.Controls.Add(this.tbSec);
            this.panelCreate.Controls.Add(this.label2);
            this.panelCreate.Controls.Add(this.label5);
            this.panelCreate.Controls.Add(this.label6);
            this.panelCreate.Controls.Add(this.btnMaakaan);
            this.panelCreate.Controls.Add(this.label3);
            this.panelCreate.Location = new System.Drawing.Point(12, 12);
            this.panelCreate.Name = "panelCreate";
            this.panelCreate.Size = new System.Drawing.Size(485, 161);
            this.panelCreate.TabIndex = 14;
            // 
            // tbNr
            // 
            this.tbNr.Location = new System.Drawing.Point(98, 15);
            this.tbNr.Name = "tbNr";
            this.tbNr.Size = new System.Drawing.Size(57, 20);
            this.tbNr.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nr:";
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(391, 90);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 7;
            this.btBrowse.Text = "Browse...";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btnMaakaan
            // 
            this.btnMaakaan.Location = new System.Drawing.Point(15, 122);
            this.btnMaakaan.Name = "btnMaakaan";
            this.btnMaakaan.Size = new System.Drawing.Size(75, 22);
            this.btnMaakaan.TabIndex = 6;
            this.btnMaakaan.Text = "Maak aan";
            this.btnMaakaan.UseVisualStyleBackColor = true;
            this.btnMaakaan.Click += new System.EventHandler(this.btMaakAan_Click);
            // 
            // panelPlay
            // 
            this.panelPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPlay.Controls.Add(this.tbFragmentNr);
            this.panelPlay.Controls.Add(this.lbAfspeelInfo);
            this.panelPlay.Controls.Add(this.btnSpeel);
            this.panelPlay.Controls.Add(this.label4);
            this.panelPlay.Location = new System.Drawing.Point(12, 179);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(485, 75);
            this.panelPlay.TabIndex = 16;
            // 
            // tbFragmentNr
            // 
            this.tbFragmentNr.Location = new System.Drawing.Point(186, 14);
            this.tbFragmentNr.Name = "tbFragmentNr";
            this.tbFragmentNr.Size = new System.Drawing.Size(26, 20);
            this.tbFragmentNr.TabIndex = 13;
            // 
            // lbAfspeelInfo
            // 
            this.lbAfspeelInfo.AutoSize = true;
            this.lbAfspeelInfo.Location = new System.Drawing.Point(12, 46);
            this.lbAfspeelInfo.Name = "lbAfspeelInfo";
            this.lbAfspeelInfo.Size = new System.Drawing.Size(36, 13);
            this.lbAfspeelInfo.TabIndex = 12;
            this.lbAfspeelInfo.Text = "<info>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "fragment met nr:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GeluidsfragmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 265);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.panelCreate);
            this.Name = "GeluidsfragmentForm";
            this.Text = "Geluidsfragment";
            this.panelCreate.ResumeLayout(false);
            this.panelCreate.PerformLayout();
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbBestandsnaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpeel;
        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Label lbAfspeelInfo;
        private System.Windows.Forms.Button btnMaakaan;
        private System.Windows.Forms.TextBox tbFragmentNr;
        private System.Windows.Forms.Label label4;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.Button btBrowse;
      private System.Windows.Forms.TextBox tbNr;
      private System.Windows.Forms.Label label7;
    }
}

