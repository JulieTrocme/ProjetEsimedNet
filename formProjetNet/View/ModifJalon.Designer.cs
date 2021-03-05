namespace formProjetNet.View
{
    partial class ModifJalon
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
            this.database1DataSet = new formProjetNet.Database1DataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new formProjetNet.Database1DataSetTableAdapters.utilisateurTableAdapter();
            this.projet = new System.Windows.Forms.ComboBox();
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listTache = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.libelle = new System.Windows.Forms.TextBox();
            this.responsable = new System.Windows.Forms.ComboBox();
            this.utilisateurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateLivrPrevu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.projetTableAdapter = new formProjetNet.Database1DataSetTableAdapters.projetTableAdapter();
            this.dateLivrReel = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // projet
            // 
            this.projet.DataSource = this.projetBindingSource;
            this.projet.DisplayMember = "nomProjet";
            this.projet.FormattingEnabled = true;
            this.projet.Location = new System.Drawing.Point(117, 344);
            this.projet.Name = "projet";
            this.projet.Size = new System.Drawing.Size(390, 21);
            this.projet.TabIndex = 43;
            this.projet.ValueMember = "IdProjet";
            // 
            // projetBindingSource
            // 
            this.projetBindingSource.DataMember = "projet";
            this.projetBindingSource.DataSource = this.database1DataSet;
            // 
            // listTache
            // 
            this.listTache.FormattingEnabled = true;
            this.listTache.Location = new System.Drawing.Point(545, 112);
            this.listTache.Name = "listTache";
            this.listTache.Size = new System.Drawing.Size(390, 259);
            this.listTache.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Projet associé";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Selectionner les tâches que possède le jalon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Modifier Jalon";
            // 
            // libelle
            // 
            this.libelle.Location = new System.Drawing.Point(117, 127);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(390, 20);
            this.libelle.TabIndex = 37;
            // 
            // responsable
            // 
            this.responsable.DataSource = this.utilisateurBindingSource1;
            this.responsable.DisplayMember = "nomUser";
            this.responsable.FormattingEnabled = true;
            this.responsable.Location = new System.Drawing.Point(117, 182);
            this.responsable.Name = "responsable";
            this.responsable.Size = new System.Drawing.Size(390, 21);
            this.responsable.TabIndex = 36;
            this.responsable.ValueMember = "IdUser";
            // 
            // utilisateurBindingSource1
            // 
            this.utilisateurBindingSource1.DataMember = "utilisateur";
            this.utilisateurBindingSource1.DataSource = this.database1DataSet;
            // 
            // dateLivrPrevu
            // 
            this.dateLivrPrevu.CustomFormat = "dd-MM-yyyy";
            this.dateLivrPrevu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLivrPrevu.Location = new System.Drawing.Point(117, 234);
            this.dateLivrPrevu.Name = "dateLivrPrevu";
            this.dateLivrPrevu.Size = new System.Drawing.Size(390, 20);
            this.dateLivrPrevu.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Date de livraison prévue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Responsable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Libelle";
            // 
            // projetTableAdapter
            // 
            this.projetTableAdapter.ClearBeforeFill = true;
            // 
            // dateLivrReel
            // 
            this.dateLivrReel.Checked = false;
            this.dateLivrReel.CustomFormat = "dd-MM-yyyy";
            this.dateLivrReel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLivrReel.Location = new System.Drawing.Point(117, 283);
            this.dateLivrReel.Name = "dateLivrReel";
            this.dateLivrReel.Size = new System.Drawing.Size(390, 20);
            this.dateLivrReel.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Date de livraison réel";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(117, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 24);
            this.button5.TabIndex = 54;
            this.button5.Text = "Retour";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ModifJalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 481);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateLivrReel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.projet);
            this.Controls.Add(this.listTache);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.libelle);
            this.Controls.Add(this.responsable);
            this.Controls.Add(this.dateLivrPrevu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifJalon";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private Database1DataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.ComboBox projet;
        private System.Windows.Forms.CheckedListBox listTache;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox libelle;
        private System.Windows.Forms.ComboBox responsable;
        private System.Windows.Forms.BindingSource utilisateurBindingSource1;
        private System.Windows.Forms.DateTimePicker dateLivrPrevu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource projetBindingSource;
        private Database1DataSetTableAdapters.projetTableAdapter projetTableAdapter;
        private System.Windows.Forms.DateTimePicker dateLivrReel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
    }
}