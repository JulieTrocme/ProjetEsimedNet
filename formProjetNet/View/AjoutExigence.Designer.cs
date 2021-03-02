namespace formProjetNet.View
{
    partial class AjoutExigence
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.besoinCl = new System.Windows.Forms.TextBox();
            this.specExigence = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fonctRadio = new System.Windows.Forms.RadioButton();
            this.nonFonctRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Besoin précis du client :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spécificité de l\'exigence :";
            this.label3.Visible = false;
            // 
            // besoinCl
            // 
            this.besoinCl.Location = new System.Drawing.Point(47, 106);
            this.besoinCl.Name = "besoinCl";
            this.besoinCl.Size = new System.Drawing.Size(264, 20);
            this.besoinCl.TabIndex = 5;
            // 
            // specExigence
            // 
            this.specExigence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specExigence.FormattingEnabled = true;
            this.specExigence.Location = new System.Drawing.Point(47, 209);
            this.specExigence.Name = "specExigence";
            this.specExigence.Size = new System.Drawing.Size(264, 21);
            this.specExigence.TabIndex = 6;
            this.specExigence.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exigence";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fonctRadio
            // 
            this.fonctRadio.AutoSize = true;
            this.fonctRadio.Location = new System.Drawing.Point(47, 154);
            this.fonctRadio.Name = "fonctRadio";
            this.fonctRadio.Size = new System.Drawing.Size(80, 17);
            this.fonctRadio.TabIndex = 9;
            this.fonctRadio.TabStop = true;
            this.fonctRadio.Text = "Fonctionnel";
            this.fonctRadio.UseVisualStyleBackColor = true;
            this.fonctRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // nonFonctRadio
            // 
            this.nonFonctRadio.AutoSize = true;
            this.nonFonctRadio.Location = new System.Drawing.Point(209, 153);
            this.nonFonctRadio.Name = "nonFonctRadio";
            this.nonFonctRadio.Size = new System.Drawing.Size(102, 17);
            this.nonFonctRadio.TabIndex = 10;
            this.nonFonctRadio.TabStop = true;
            this.nonFonctRadio.Text = "Non fontionnelle";
            this.nonFonctRadio.UseVisualStyleBackColor = true;
            this.nonFonctRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // AjoutExigence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 298);
            this.Controls.Add(this.nonFonctRadio);
            this.Controls.Add(this.fonctRadio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specExigence);
            this.Controls.Add(this.besoinCl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutExigence";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AjoutExigence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox besoinCl;
        private System.Windows.Forms.ComboBox specExigence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton fonctRadio;
        private System.Windows.Forms.RadioButton nonFonctRadio;
    }
}