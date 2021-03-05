namespace formProjetNet.View
{
    partial class ModifTache
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
            this.label8 = new System.Windows.Forms.Label();
            this.listExigence = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.projet = new System.Windows.Forms.ComboBox();
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new formProjetNet.Database1DataSet();
            this.user = new System.Windows.Forms.ComboBox();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDebutTheo = new System.Windows.Forms.DateTimePicker();
            this.nbJours = new System.Windows.Forms.NumericUpDown();
            this.tachePrec = new System.Windows.Forms.ComboBox();
            this.descOpe = new System.Windows.Forms.TextBox();
            this.libelle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.projetTableAdapter = new formProjetNet.Database1DataSetTableAdapters.projetTableAdapter();
            this.jalon1 = new System.Windows.Forms.ComboBox();
            this.jalon2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.jalon2TableAdapter = new formProjetNet.Database1DataSetTableAdapters.Jalon2TableAdapter();
            this.utilisateurTableAdapter = new formProjetNet.Database1DataSetTableAdapters.utilisateurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbJours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jalon2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(565, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Selectionner les exigences que posséde la tâche";
            // 
            // listExigence
            // 
            this.listExigence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listExigence.FormattingEnabled = true;
            this.listExigence.Location = new System.Drawing.Point(568, 95);
            this.listExigence.Name = "listExigence";
            this.listExigence.Size = new System.Drawing.Size(476, 439);
            this.listExigence.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(831, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 27);
            this.button1.TabIndex = 36;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(459, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Modifier Tâche";
            // 
            // projet
            // 
            this.projet.DataSource = this.projetBindingSource;
            this.projet.DisplayMember = "nomProjet";
            this.projet.FormattingEnabled = true;
            this.projet.Location = new System.Drawing.Point(60, 421);
            this.projet.Name = "projet";
            this.projet.Size = new System.Drawing.Size(478, 21);
            this.projet.TabIndex = 34;
            this.projet.ValueMember = "IdProjet";
            this.projet.SelectedIndexChanged += new System.EventHandler(this.projet_SelectedIndexChanged);
            // 
            // projetBindingSource
            // 
            this.projetBindingSource.DataMember = "projet";
            this.projetBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user
            // 
            this.user.DataSource = this.utilisateurBindingSource;
            this.user.DisplayMember = "nomUser";
            this.user.FormattingEnabled = true;
            this.user.Location = new System.Drawing.Point(60, 381);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(478, 21);
            this.user.TabIndex = 33;
            this.user.ValueMember = "IdUser";
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.database1DataSet;
            // 
            // dateDebutTheo
            // 
            this.dateDebutTheo.CustomFormat = "dd-MM-yyyy";
            this.dateDebutTheo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebutTheo.Location = new System.Drawing.Point(62, 333);
            this.dateDebutTheo.Name = "dateDebutTheo";
            this.dateDebutTheo.Size = new System.Drawing.Size(478, 20);
            this.dateDebutTheo.TabIndex = 32;
            // 
            // nbJours
            // 
            this.nbJours.Location = new System.Drawing.Point(62, 283);
            this.nbJours.Name = "nbJours";
            this.nbJours.Size = new System.Drawing.Size(478, 20);
            this.nbJours.TabIndex = 31;
            // 
            // tachePrec
            // 
            this.tachePrec.DisplayMember = "libelle";
            this.tachePrec.FormattingEnabled = true;
            this.tachePrec.Location = new System.Drawing.Point(60, 472);
            this.tachePrec.Name = "tachePrec";
            this.tachePrec.Size = new System.Drawing.Size(478, 21);
            this.tachePrec.TabIndex = 30;
            this.tachePrec.ValueMember = "idTache";
            // 
            // descOpe
            // 
            this.descOpe.Location = new System.Drawing.Point(62, 143);
            this.descOpe.Multiline = true;
            this.descOpe.Name = "descOpe";
            this.descOpe.Size = new System.Drawing.Size(478, 115);
            this.descOpe.TabIndex = 29;
            // 
            // libelle
            // 
            this.libelle.Location = new System.Drawing.Point(62, 95);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(478, 20);
            this.libelle.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Projet associé";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tâche précédente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Date de début théorique";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Charge en nombre de jours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Description des opérations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Libelle";
            // 
            // projetTableAdapter
            // 
            this.projetTableAdapter.ClearBeforeFill = true;
            // 
            // jalon1
            // 
            this.jalon1.FormattingEnabled = true;
            this.jalon1.Location = new System.Drawing.Point(60, 518);
            this.jalon1.Name = "jalon1";
            this.jalon1.Size = new System.Drawing.Size(478, 21);
            this.jalon1.TabIndex = 42;
            // 
            // jalon2BindingSource
            // 
            this.jalon2BindingSource.DataMember = "Jalon2";
            this.jalon2BindingSource.DataSource = this.database1DataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Jalon associé";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "User";
            // 
            // jalon2TableAdapter
            // 
            this.jalon2TableAdapter.ClearBeforeFill = true;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // ModifTache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 637);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.jalon1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listExigence);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.projet);
            this.Controls.Add(this.user);
            this.Controls.Add(this.dateDebutTheo);
            this.Controls.Add(this.nbJours);
            this.Controls.Add(this.tachePrec);
            this.Controls.Add(this.descOpe);
            this.Controls.Add(this.libelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "ModifTache";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ModifTache_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbJours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jalon2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox listExigence;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox projet;
        private System.Windows.Forms.ComboBox user;
        private System.Windows.Forms.DateTimePicker dateDebutTheo;
        private System.Windows.Forms.NumericUpDown nbJours;
        private System.Windows.Forms.ComboBox tachePrec;
        private System.Windows.Forms.TextBox descOpe;
        private System.Windows.Forms.TextBox libelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource projetBindingSource;
        private Database1DataSetTableAdapters.projetTableAdapter projetTableAdapter;
        private System.Windows.Forms.ComboBox jalon1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource jalon2BindingSource;
        private Database1DataSetTableAdapters.Jalon2TableAdapter jalon2TableAdapter;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private Database1DataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
    }
}