namespace formProjetNet.View
{
    partial class ModifExigence
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
            this.fonctRadio = new System.Windows.Forms.RadioButton();
            this.nonFonctRadio = new System.Windows.Forms.RadioButton();
            this.projetSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tacheExigenceTableAdapter1 = new formProjetNet.Database1DataSetTableAdapters.tacheExigenceTableAdapter();
            this.database1DataSet = new formProjetNet.Database1DataSet();
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetTableAdapter = new formProjetNet.Database1DataSetTableAdapters.projetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = " Besoin précis du client :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Spécificité de l\'exigence :";
            this.label3.Visible = false;
            // 
            // besoin
            // 
            this.besoin.Location = new System.Drawing.Point(114, 148);
            this.besoin.Name = "besoin";
            this.besoin.Size = new System.Drawing.Size(576, 20);
            this.besoin.TabIndex = 27;
            // 
            // specExigence
            // 
            this.specExigence.FormattingEnabled = true;
            this.specExigence.Location = new System.Drawing.Point(114, 301);
            this.specExigence.Name = "specExigence";
            this.specExigence.Size = new System.Drawing.Size(576, 21);
            this.specExigence.TabIndex = 28;
            this.specExigence.Visible = false;
            // 
            // fonctRadio
            // 
            this.fonctRadio.AutoSize = true;
            this.fonctRadio.Location = new System.Drawing.Point(114, 251);
            this.fonctRadio.Name = "fonctRadio";
            this.fonctRadio.Size = new System.Drawing.Size(80, 17);
            this.fonctRadio.TabIndex = 31;
            this.fonctRadio.TabStop = true;
            this.fonctRadio.Text = "Fonctionnel";
            this.fonctRadio.UseVisualStyleBackColor = true;
            this.fonctRadio.CheckedChanged += new System.EventHandler(this.fonctRadio_CheckedChanged);
            // 
            // nonFonctRadio
            // 
            this.nonFonctRadio.AutoSize = true;
            this.nonFonctRadio.Location = new System.Drawing.Point(275, 250);
            this.nonFonctRadio.Name = "nonFonctRadio";
            this.nonFonctRadio.Size = new System.Drawing.Size(102, 17);
            this.nonFonctRadio.TabIndex = 32;
            this.nonFonctRadio.TabStop = true;
            this.nonFonctRadio.Text = "Non fontionnelle";
            this.nonFonctRadio.UseVisualStyleBackColor = true;
            this.nonFonctRadio.CheckedChanged += new System.EventHandler(this.nonFonctRadio_CheckedChanged);
            // 
            // projetSelect
            // 
            this.projetSelect.DataSource = this.projetBindingSource;
            this.projetSelect.DisplayMember = "nomProjet";
            this.projetSelect.FormattingEnabled = true;
            this.projetSelect.Location = new System.Drawing.Point(114, 199);
            this.projetSelect.Name = "projetSelect";
            this.projetSelect.Size = new System.Drawing.Size(576, 21);
            this.projetSelect.TabIndex = 33;
            this.projetSelect.ValueMember = "IdProjet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Projet associé :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 26);
            this.button2.TabIndex = 35;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Modifier exigence";
            // 
            // tacheExigenceTableAdapter1
            // 
            this.tacheExigenceTableAdapter1.ClearBeforeFill = true;
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
            // projetTableAdapter
            // 
            this.projetTableAdapter.ClearBeforeFill = true;
            // 
            // ModifExigence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.projetSelect);
            this.Controls.Add(this.nonFonctRadio);
            this.Controls.Add(this.fonctRadio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specExigence);
            this.Controls.Add(this.besoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifExigence";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ModifExigence_Load);
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
        private System.Windows.Forms.RadioButton fonctRadio;
        private System.Windows.Forms.RadioButton nonFonctRadio;
        private System.Windows.Forms.ComboBox projetSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private Database1DataSetTableAdapters.tacheExigenceTableAdapter tacheExigenceTableAdapter1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource projetBindingSource;
        private Database1DataSetTableAdapters.projetTableAdapter projetTableAdapter;
    }
}