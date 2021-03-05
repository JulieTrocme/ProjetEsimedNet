namespace formProjetNet.View
{
    partial class AjoutTache
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.libelle = new System.Windows.Forms.TextBox();
            this.descOpe = new System.Windows.Forms.TextBox();
            this.tachePrec = new System.Windows.Forms.ComboBox();
            this.tacheBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new formProjetNet.Database1DataSet();
            this.tacheBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tacheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nbJours = new System.Windows.Forms.NumericUpDown();
            this.dateDebutTheo = new System.Windows.Forms.DateTimePicker();
            this.user = new System.Windows.Forms.ComboBox();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projet = new System.Windows.Forms.ComboBox();
            this.projetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.utilisateurTableAdapter = new formProjetNet.Database1DataSetTableAdapters.utilisateurTableAdapter();
            this.tacheTableAdapter = new formProjetNet.Database1DataSetTableAdapters.tacheTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.listExigence = new System.Windows.Forms.CheckedListBox();
            this.projetTableAdapter = new formProjetNet.Database1DataSetTableAdapters.projetTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbJours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description des opérations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Charge en nombre de jours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de début théorique";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tâche précédente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Projet associé";
            // 
            // libelle
            // 
            this.libelle.Location = new System.Drawing.Point(76, 78);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(478, 20);
            this.libelle.TabIndex = 8;
            // 
            // descOpe
            // 
            this.descOpe.Location = new System.Drawing.Point(76, 135);
            this.descOpe.Multiline = true;
            this.descOpe.Name = "descOpe";
            this.descOpe.Size = new System.Drawing.Size(478, 115);
            this.descOpe.TabIndex = 9;
            // 
            // tachePrec
            // 
            this.tachePrec.FormattingEnabled = true;
            this.tachePrec.Location = new System.Drawing.Point(74, 513);
            this.tachePrec.Name = "tachePrec";
            this.tachePrec.Size = new System.Drawing.Size(478, 21);
            this.tachePrec.TabIndex = 10;
            // 
            // tacheBindingSource2
            // 
            this.tacheBindingSource2.DataMember = "tache";
            this.tacheBindingSource2.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tacheBindingSource1
            // 
            this.tacheBindingSource1.DataMember = "tache";
            this.tacheBindingSource1.DataSource = this.database1DataSet;
            // 
            // tacheBindingSource
            // 
            this.tacheBindingSource.DataMember = "tache";
            this.tacheBindingSource.DataSource = this.database1DataSet;
            // 
            // nbJours
            // 
            this.nbJours.Location = new System.Drawing.Point(74, 282);
            this.nbJours.Name = "nbJours";
            this.nbJours.Size = new System.Drawing.Size(478, 20);
            this.nbJours.TabIndex = 11;
            // 
            // dateDebutTheo
            // 
            this.dateDebutTheo.CustomFormat = "dd-MM-yyyy";
            this.dateDebutTheo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebutTheo.Location = new System.Drawing.Point(74, 343);
            this.dateDebutTheo.Name = "dateDebutTheo";
            this.dateDebutTheo.Size = new System.Drawing.Size(478, 20);
            this.dateDebutTheo.TabIndex = 12;
            // 
            // user
            // 
            this.user.DataSource = this.utilisateurBindingSource;
            this.user.DisplayMember = "nomUser";
            this.user.FormattingEnabled = true;
            this.user.Location = new System.Drawing.Point(74, 402);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(478, 21);
            this.user.TabIndex = 13;
            this.user.ValueMember = "IdUser";
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.database1DataSet;
            // 
            // projet
            // 
            this.projet.DataSource = this.projetBindingSource2;
            this.projet.DisplayMember = "nomProjet";
            this.projet.FormattingEnabled = true;
            this.projet.Location = new System.Drawing.Point(74, 457);
            this.projet.Name = "projet";
            this.projet.Size = new System.Drawing.Size(478, 21);
            this.projet.TabIndex = 14;
            this.projet.ValueMember = "IdProjet";
            this.projet.SelectedIndexChanged += new System.EventHandler(this.projet_SelectedIndexChanged);
            // 
            // projetBindingSource2
            // 
            this.projetBindingSource2.DataMember = "projet";
            this.projetBindingSource2.DataSource = this.database1DataSet;
            // 
            // projetBindingSource1
            // 
            this.projetBindingSource1.DataMember = "projet";
            this.projetBindingSource1.DataSource = this.database1DataSet;
            // 
            // projetBindingSource
            // 
            this.projetBindingSource.DataMember = "projet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(507, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ajouter Tâche";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(851, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Suivant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // tacheTableAdapter
            // 
            this.tacheTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 27);
            this.button2.TabIndex = 18;
            this.button2.Text = "Ajouter une nouvelle tâche";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listExigence
            // 
            this.listExigence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listExigence.FormattingEnabled = true;
            this.listExigence.Location = new System.Drawing.Point(588, 95);
            this.listExigence.Name = "listExigence";
            this.listExigence.Size = new System.Drawing.Size(476, 439);
            this.listExigence.TabIndex = 19;
            this.listExigence.SelectedIndexChanged += new System.EventHandler(this.listExigence_SelectedIndexChanged);
            // 
            // projetTableAdapter
            // 
            this.projetTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(585, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Selectionner les exigences que posséde la tâche";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 561);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 27);
            this.button3.TabIndex = 21;
            this.button3.Text = "Ajouter une exigence";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(339, 561);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 27);
            this.button4.TabIndex = 22;
            this.button4.Text = "Ajouter puis revenir a l\'accueil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AjoutTache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 633);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listExigence);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutTache";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AjoutTache_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbJours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox libelle;
        private System.Windows.Forms.TextBox descOpe;
        private System.Windows.Forms.ComboBox tachePrec;
        private System.Windows.Forms.NumericUpDown nbJours;
        private System.Windows.Forms.DateTimePicker dateDebutTheo;
        private System.Windows.Forms.ComboBox user;
        private System.Windows.Forms.ComboBox projet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        
        private System.Windows.Forms.BindingSource projetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private Database1DataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.BindingSource tacheBindingSource;
        private Database1DataSetTableAdapters.tacheTableAdapter tacheTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox listExigence;
        private System.Windows.Forms.BindingSource projetBindingSource1;
        private Database1DataSetTableAdapters.projetTableAdapter projetTableAdapter;
        private System.Windows.Forms.BindingSource tacheBindingSource1;
        private System.Windows.Forms.BindingSource tacheBindingSource2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource projetBindingSource2;
        private System.Windows.Forms.Button button4;
    }
}