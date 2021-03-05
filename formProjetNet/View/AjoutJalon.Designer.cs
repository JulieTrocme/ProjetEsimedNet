namespace formProjetNet.View
{
    partial class AjoutJalon
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
            this.dateLivrPrevu = new System.Windows.Forms.DateTimePicker();
            this.responsable = new System.Windows.Forms.ComboBox();
            this.utilisateurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new formProjetNet.Database1DataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.utilisateurTableAdapter = new formProjetNet.Database1DataSetTableAdapters.utilisateurTableAdapter();
            this.listTache = new System.Windows.Forms.CheckedListBox();
            this.projet = new System.Windows.Forms.ComboBox();
            this.projetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.projetTableAdapter = new formProjetNet.Database1DataSetTableAdapters.projetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Responsable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de livraison prévue";
            // 
            // dateLivrPrevu
            // 
            this.dateLivrPrevu.CustomFormat = "dd-MM-yyyy";
            this.dateLivrPrevu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLivrPrevu.Location = new System.Drawing.Point(50, 219);
            this.dateLivrPrevu.Name = "dateLivrPrevu";
            this.dateLivrPrevu.Size = new System.Drawing.Size(390, 20);
            this.dateLivrPrevu.TabIndex = 4;
            // 
            // responsable
            // 
            this.responsable.DataSource = this.utilisateurBindingSource1;
            this.responsable.DisplayMember = "nomUser";
            this.responsable.FormattingEnabled = true;
            this.responsable.Location = new System.Drawing.Point(50, 155);
            this.responsable.Name = "responsable";
            this.responsable.Size = new System.Drawing.Size(390, 21);
            this.responsable.TabIndex = 8;
            this.responsable.ValueMember = "IdUser";
            // 
            // utilisateurBindingSource1
            // 
            this.utilisateurBindingSource1.DataMember = "utilisateur";
            this.utilisateurBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.database1DataSet;
            // 
            // libelle
            // 
            this.libelle.Location = new System.Drawing.Point(50, 100);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(390, 20);
            this.libelle.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ajouter Jalon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Selectionner les tâches que possède le jalon";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // listTache
            // 
            this.listTache.FormattingEnabled = true;
            this.listTache.Location = new System.Drawing.Point(478, 85);
            this.listTache.Name = "listTache";
            this.listTache.Size = new System.Drawing.Size(390, 259);
            this.listTache.TabIndex = 16;
            this.listTache.SelectedIndexChanged += new System.EventHandler(this.listTache_SelectedIndexChanged);
            // 
            // projet
            // 
            this.projet.DataSource = this.projetBindingSource1;
            this.projet.DisplayMember = "nomProjet";
            this.projet.FormattingEnabled = true;
            this.projet.Location = new System.Drawing.Point(50, 288);
            this.projet.Name = "projet";
            this.projet.Size = new System.Drawing.Size(390, 21);
            this.projet.TabIndex = 18;
            this.projet.ValueMember = "IdProjet";
            this.projet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // projetBindingSource1
            // 
            this.projetBindingSource1.DataMember = "projet";
            this.projetBindingSource1.DataSource = this.database1DataSet;
            // 
            // projetBindingSource
            // 
            this.projetBindingSource.DataMember = "projet";
            this.projetBindingSource.DataSource = this.database1DataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Projet associé";
            // 
            // projetTableAdapter
            // 
            this.projetTableAdapter.ClearBeforeFill = true;
            // 
            // AjoutJalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 413);
            this.Controls.Add(this.projet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listTache);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.libelle);
            this.Controls.Add(this.responsable);
            this.Controls.Add(this.dateLivrPrevu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutJalon";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AjoutJalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateLivrPrevu;
        private System.Windows.Forms.ComboBox responsable;
        private System.Windows.Forms.TextBox libelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private Database1DataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.CheckedListBox listTache;
        private System.Windows.Forms.ComboBox projet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource projetBindingSource;
        private Database1DataSetTableAdapters.projetTableAdapter projetTableAdapter;
        private System.Windows.Forms.BindingSource utilisateurBindingSource1;
        private System.Windows.Forms.BindingSource projetBindingSource1;
    }
}