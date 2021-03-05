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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.besoin = new System.Windows.Forms.TextBox();
            this.specExigence = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fonctRadio = new System.Windows.Forms.RadioButton();
            this.nonFonctRadio = new System.Windows.Forms.RadioButton();
            this.exigenceTableAdapter1 = new formProjetNet.Database1DataSetTableAdapters.exigenceTableAdapter();
            this.projetSelect = new System.Windows.Forms.ComboBox();
            this.projetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new formProjetNet.Database1DataSet();
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.projetTableAdapter = new formProjetNet.Database1DataSetTableAdapters.projetTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(44, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spécificité de l\'exigence :";
            this.label3.Visible = false;
            // 
            // besoin
            // 
            this.besoin.Location = new System.Drawing.Point(47, 106);
            this.besoin.Name = "besoin";
            this.besoin.Size = new System.Drawing.Size(576, 20);
            this.besoin.TabIndex = 5;
            // 
            // specExigence
            // 
            this.specExigence.FormattingEnabled = true;
            this.specExigence.Location = new System.Drawing.Point(47, 259);
            this.specExigence.Name = "specExigence";
            this.specExigence.Size = new System.Drawing.Size(576, 21);
            this.specExigence.TabIndex = 6;
            this.specExigence.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ajouter Exigence";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Suivant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fonctRadio
            // 
            this.fonctRadio.AutoSize = true;
            this.fonctRadio.Location = new System.Drawing.Point(47, 209);
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
            this.nonFonctRadio.Location = new System.Drawing.Point(209, 208);
            this.nonFonctRadio.Name = "nonFonctRadio";
            this.nonFonctRadio.Size = new System.Drawing.Size(102, 17);
            this.nonFonctRadio.TabIndex = 10;
            this.nonFonctRadio.TabStop = true;
            this.nonFonctRadio.Text = "Non fontionnelle";
            this.nonFonctRadio.UseVisualStyleBackColor = true;
            this.nonFonctRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // exigenceTableAdapter1
            // 
            this.exigenceTableAdapter1.ClearBeforeFill = true;
            // 
            // projetSelect
            // 
            this.projetSelect.DataSource = this.projetBindingSource1;
            this.projetSelect.DisplayMember = "nomProjet";
            this.projetSelect.FormattingEnabled = true;
            this.projetSelect.Location = new System.Drawing.Point(47, 157);
            this.projetSelect.Name = "projetSelect";
            this.projetSelect.Size = new System.Drawing.Size(576, 21);
            this.projetSelect.TabIndex = 12;
            this.projetSelect.ValueMember = "IdProjet";
            // 
            // projetBindingSource1
            // 
            this.projetBindingSource1.DataMember = "projet";
            this.projetBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetBindingSource
            // 
            this.projetBindingSource.DataMember = "projet";
            this.projetBindingSource.DataSource = this.database1DataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Projet associé :";
            // 
            // projetTableAdapter
            // 
            this.projetTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 26);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ajouter une nouvelle exigence ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(132, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 27);
            this.button4.TabIndex = 23;
            this.button4.Text = "Ajouter puis revenir a l\'accueil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 27);
            this.button3.TabIndex = 50;
            this.button3.Text = "Retour";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AjoutExigence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 377);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.projetSelect);
            this.Controls.Add(this.nonFonctRadio);
            this.Controls.Add(this.fonctRadio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specExigence);
            this.Controls.Add(this.besoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutExigence";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AjoutExigence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox besoin;
        private System.Windows.Forms.ComboBox specExigence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton fonctRadio;
        private System.Windows.Forms.RadioButton nonFonctRadio;
        private Database1DataSetTableAdapters.exigenceTableAdapter exigenceTableAdapter1;
        private System.Windows.Forms.ComboBox projetSelect;
        private System.Windows.Forms.Label label5;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource projetBindingSource;
        private Database1DataSetTableAdapters.projetTableAdapter projetTableAdapter;
        private System.Windows.Forms.BindingSource projetBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}