namespace formProjetNet
{
    partial class Accueil
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
            this.projet = new System.Windows.Forms.ComboBox();
            this.projetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new formProjetNet.Database1DataSet();
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetTableAdapter = new formProjetNet.Database1DataSetTableAdapters.projetTableAdapter();
            this.buttonJalon = new System.Windows.Forms.Button();
            this.buttonTache = new System.Windows.Forms.Button();
            this.buttonExigence = new System.Windows.Forms.Button();
            this.buttonProjet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonModifProjet = new System.Windows.Forms.Button();
            this.contenuProjet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listExigence = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listTache = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listJalon = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listTacheExigence = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nomProjet = new System.Windows.Forms.Label();
            this.dateDebutProjet = new System.Windows.Forms.Label();
            this.ChefProjet = new System.Windows.Forms.Label();
            this.dateFinProjet = new System.Windows.Forms.Label();
            this.deleteJalon = new System.Windows.Forms.Button();
            this.deleteTache = new System.Windows.Forms.Button();
            this.deleteExig = new System.Windows.Forms.Button();
            this.deleteProjet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
            this.contenuProjet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listExigence)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listTache)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listJalon)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listTacheExigence)).BeginInit();
            this.SuspendLayout();
            // 
            // projet
            // 
            this.projet.DataSource = this.projetBindingSource1;
            this.projet.DisplayMember = "nomProjet";
            this.projet.FormattingEnabled = true;
            this.projet.Location = new System.Drawing.Point(33, 119);
            this.projet.Name = "projet";
            this.projet.Size = new System.Drawing.Size(587, 21);
            this.projet.TabIndex = 0;
            this.projet.ValueMember = "IdProjet";
            this.projet.SelectedIndexChanged += new System.EventHandler(this.projet_SelectedIndexChanged);
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
            // projetTableAdapter
            // 
            this.projetTableAdapter.ClearBeforeFill = true;
            // 
            // buttonJalon
            // 
            this.buttonJalon.Location = new System.Drawing.Point(669, 28);
            this.buttonJalon.Name = "buttonJalon";
            this.buttonJalon.Size = new System.Drawing.Size(164, 29);
            this.buttonJalon.TabIndex = 18;
            this.buttonJalon.Text = "Ajouter un jalon";
            this.buttonJalon.UseVisualStyleBackColor = true;
            this.buttonJalon.Click += new System.EventHandler(this.buttonJalon_Click);
            // 
            // buttonTache
            // 
            this.buttonTache.Location = new System.Drawing.Point(456, 28);
            this.buttonTache.Name = "buttonTache";
            this.buttonTache.Size = new System.Drawing.Size(164, 29);
            this.buttonTache.TabIndex = 17;
            this.buttonTache.Text = "Ajouter une tâche";
            this.buttonTache.UseVisualStyleBackColor = true;
            this.buttonTache.Click += new System.EventHandler(this.buttonTache_Click);
            // 
            // buttonExigence
            // 
            this.buttonExigence.Location = new System.Drawing.Point(239, 28);
            this.buttonExigence.Name = "buttonExigence";
            this.buttonExigence.Size = new System.Drawing.Size(164, 29);
            this.buttonExigence.TabIndex = 16;
            this.buttonExigence.Text = "Ajouter une exigence";
            this.buttonExigence.UseVisualStyleBackColor = true;
            this.buttonExigence.Click += new System.EventHandler(this.buttonExigence_Click);
            // 
            // buttonProjet
            // 
            this.buttonProjet.Location = new System.Drawing.Point(33, 28);
            this.buttonProjet.Name = "buttonProjet";
            this.buttonProjet.Size = new System.Drawing.Size(164, 29);
            this.buttonProjet.TabIndex = 15;
            this.buttonProjet.Text = "Ajouter un projet";
            this.buttonProjet.UseVisualStyleBackColor = true;
            this.buttonProjet.Click += new System.EventHandler(this.buttonProjet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nom du projet";
            // 
            // buttonModifProjet
            // 
            this.buttonModifProjet.Location = new System.Drawing.Point(669, 114);
            this.buttonModifProjet.Name = "buttonModifProjet";
            this.buttonModifProjet.Size = new System.Drawing.Size(164, 29);
            this.buttonModifProjet.TabIndex = 20;
            this.buttonModifProjet.Text = "Modifier un projet";
            this.buttonModifProjet.UseVisualStyleBackColor = true;
            this.buttonModifProjet.Click += new System.EventHandler(this.buttonModifProjet_Click);
            // 
            // contenuProjet
            // 
            this.contenuProjet.Controls.Add(this.tabPage1);
            this.contenuProjet.Controls.Add(this.tabPage2);
            this.contenuProjet.Controls.Add(this.tabPage3);
            this.contenuProjet.Controls.Add(this.tabPage4);
            this.contenuProjet.Location = new System.Drawing.Point(25, 270);
            this.contenuProjet.Name = "contenuProjet";
            this.contenuProjet.SelectedIndex = 0;
            this.contenuProjet.Size = new System.Drawing.Size(1238, 349);
            this.contenuProjet.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.listExigence);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1230, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Exigences";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listExigence
            // 
            this.listExigence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listExigence.Location = new System.Drawing.Point(4, 4);
            this.listExigence.Name = "listExigence";
            this.listExigence.Size = new System.Drawing.Size(1223, 313);
            this.listExigence.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listTache);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1230, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tâches";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listTache
            // 
            this.listTache.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTache.Location = new System.Drawing.Point(7, 7);
            this.listTache.Name = "listTache";
            this.listTache.Size = new System.Drawing.Size(1217, 310);
            this.listTache.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listJalon);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1230, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Jalon";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listJalon
            // 
            this.listJalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listJalon.Location = new System.Drawing.Point(7, 6);
            this.listJalon.Name = "listJalon";
            this.listJalon.Size = new System.Drawing.Size(1217, 311);
            this.listJalon.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listTacheExigence);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1230, 323);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Taches-Exigences";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listTacheExigence
            // 
            this.listTacheExigence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTacheExigence.Location = new System.Drawing.Point(6, 6);
            this.listTacheExigence.Name = "listTacheExigence";
            this.listTacheExigence.Size = new System.Drawing.Size(1218, 311);
            this.listTacheExigence.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nom du projet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date de fin du projet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Date de début du projet : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Chef de projet :";
            // 
            // nomProjet
            // 
            this.nomProjet.AutoSize = true;
            this.nomProjet.Location = new System.Drawing.Point(182, 174);
            this.nomProjet.Name = "nomProjet";
            this.nomProjet.Size = new System.Drawing.Size(108, 13);
            this.nomProjet.TabIndex = 26;
            this.nomProjet.Text = "selectionner un projet";
            // 
            // dateDebutProjet
            // 
            this.dateDebutProjet.AutoSize = true;
            this.dateDebutProjet.Location = new System.Drawing.Point(182, 226);
            this.dateDebutProjet.Name = "dateDebutProjet";
            this.dateDebutProjet.Size = new System.Drawing.Size(108, 13);
            this.dateDebutProjet.TabIndex = 27;
            this.dateDebutProjet.Text = "selectionner un projet";
            // 
            // ChefProjet
            // 
            this.ChefProjet.AutoSize = true;
            this.ChefProjet.Location = new System.Drawing.Point(571, 174);
            this.ChefProjet.Name = "ChefProjet";
            this.ChefProjet.Size = new System.Drawing.Size(108, 13);
            this.ChefProjet.TabIndex = 28;
            this.ChefProjet.Text = "selectionner un projet";
            // 
            // dateFinProjet
            // 
            this.dateFinProjet.AutoSize = true;
            this.dateFinProjet.Location = new System.Drawing.Point(571, 226);
            this.dateFinProjet.Name = "dateFinProjet";
            this.dateFinProjet.Size = new System.Drawing.Size(108, 13);
            this.dateFinProjet.TabIndex = 29;
            this.dateFinProjet.Text = "selectionner un projet";
            // 
            // deleteJalon
            // 
            this.deleteJalon.Location = new System.Drawing.Point(1099, 237);
            this.deleteJalon.Name = "deleteJalon";
            this.deleteJalon.Size = new System.Drawing.Size(164, 29);
            this.deleteJalon.TabIndex = 33;
            this.deleteJalon.Text = "Supprimer un jalon";
            this.deleteJalon.UseVisualStyleBackColor = true;
            this.deleteJalon.Click += new System.EventHandler(this.deleteJalon_Click);
            // 
            // deleteTache
            // 
            this.deleteTache.Location = new System.Drawing.Point(1099, 174);
            this.deleteTache.Name = "deleteTache";
            this.deleteTache.Size = new System.Drawing.Size(164, 29);
            this.deleteTache.TabIndex = 32;
            this.deleteTache.Text = "Supprimer une tâche";
            this.deleteTache.UseVisualStyleBackColor = true;
            this.deleteTache.Click += new System.EventHandler(this.deleteTache_Click);
            // 
            // deleteExig
            // 
            this.deleteExig.Location = new System.Drawing.Point(836, 237);
            this.deleteExig.Name = "deleteExig";
            this.deleteExig.Size = new System.Drawing.Size(164, 29);
            this.deleteExig.TabIndex = 31;
            this.deleteExig.Text = "Supprimer une exigence";
            this.deleteExig.UseVisualStyleBackColor = true;
            this.deleteExig.Click += new System.EventHandler(this.deleteExig_Click);
            // 
            // deleteProjet
            // 
            this.deleteProjet.Location = new System.Drawing.Point(836, 174);
            this.deleteProjet.Name = "deleteProjet";
            this.deleteProjet.Size = new System.Drawing.Size(164, 29);
            this.deleteProjet.TabIndex = 30;
            this.deleteProjet.Text = "Supprimer un projet";
            this.deleteProjet.UseVisualStyleBackColor = true;
            this.deleteProjet.Click += new System.EventHandler(this.deleteProjet_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 655);
            this.Controls.Add(this.deleteJalon);
            this.Controls.Add(this.deleteTache);
            this.Controls.Add(this.deleteExig);
            this.Controls.Add(this.deleteProjet);
            this.Controls.Add(this.dateFinProjet);
            this.Controls.Add(this.ChefProjet);
            this.Controls.Add(this.dateDebutProjet);
            this.Controls.Add(this.nomProjet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenuProjet);
            this.Controls.Add(this.buttonModifProjet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonJalon);
            this.Controls.Add(this.buttonTache);
            this.Controls.Add(this.buttonExigence);
            this.Controls.Add(this.buttonProjet);
            this.Controls.Add(this.projet);
            this.Name = "Accueil";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).EndInit();
            this.contenuProjet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listExigence)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listTache)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listJalon)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listTacheExigence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox projet;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource projetBindingSource;
        private Database1DataSetTableAdapters.projetTableAdapter projetTableAdapter;
        private System.Windows.Forms.Button buttonJalon;
        private System.Windows.Forms.Button buttonTache;
        private System.Windows.Forms.Button buttonExigence;
        private System.Windows.Forms.Button buttonProjet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonModifProjet;
        private System.Windows.Forms.TabControl contenuProjet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView listExigence;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView listTache;
        private System.Windows.Forms.DataGridView listJalon;
        private System.Windows.Forms.BindingSource projetBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nomProjet;
        private System.Windows.Forms.Label dateDebutProjet;
        private System.Windows.Forms.Label ChefProjet;
        private System.Windows.Forms.Label dateFinProjet;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView listTacheExigence;
        private System.Windows.Forms.Button deleteJalon;
        private System.Windows.Forms.Button deleteTache;
        private System.Windows.Forms.Button deleteExig;
        private System.Windows.Forms.Button deleteProjet;
    }
}