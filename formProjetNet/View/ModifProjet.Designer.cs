namespace formProjetNet.View
{
    partial class ModifProjet
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
            this.listExigence = new System.Windows.Forms.ComboBox();
            this.listTache = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFinProjet = new System.Windows.Forms.DateTimePicker();
            this.dateDebutProjet = new System.Windows.Forms.DateTimePicker();
            this.userRespProjet = new System.Windows.Forms.ComboBox();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new formProjetNet.Database1DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listJalon = new System.Windows.Forms.ComboBox();
            this.nomProjet = new System.Windows.Forms.TextBox();
            this.utilisateurTableAdapter = new formProjetNet.Database1DataSetTableAdapters.utilisateurTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listExigence
            // 
            this.listExigence.FormattingEnabled = true;
            this.listExigence.Location = new System.Drawing.Point(40, 369);
            this.listExigence.Name = "listExigence";
            this.listExigence.Size = new System.Drawing.Size(379, 21);
            this.listExigence.TabIndex = 0;
            // 
            // listTache
            // 
            this.listTache.FormattingEnabled = true;
            this.listTache.Location = new System.Drawing.Point(436, 369);
            this.listTache.Name = "listTache";
            this.listTache.Size = new System.Drawing.Size(379, 21);
            this.listTache.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Date de fin du projet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Date de début du projet";
            // 
            // dateFinProjet
            // 
            this.dateFinProjet.CustomFormat = "dd-MM-yyyy";
            this.dateFinProjet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinProjet.Location = new System.Drawing.Point(496, 212);
            this.dateFinProjet.Name = "dateFinProjet";
            this.dateFinProjet.Size = new System.Drawing.Size(407, 20);
            this.dateFinProjet.TabIndex = 33;
            // 
            // dateDebutProjet
            // 
            this.dateDebutProjet.CustomFormat = "dd-MM-yyyy";
            this.dateDebutProjet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebutProjet.Location = new System.Drawing.Point(40, 212);
            this.dateDebutProjet.Name = "dateDebutProjet";
            this.dateDebutProjet.Size = new System.Drawing.Size(407, 20);
            this.dateDebutProjet.TabIndex = 32;
            // 
            // userRespProjet
            // 
            this.userRespProjet.DataSource = this.utilisateurBindingSource;
            this.userRespProjet.DisplayMember = "nomUser";
            this.userRespProjet.FormattingEnabled = true;
            this.userRespProjet.Location = new System.Drawing.Point(496, 148);
            this.userRespProjet.Name = "userRespProjet";
            this.userRespProjet.Size = new System.Drawing.Size(407, 21);
            this.userRespProjet.TabIndex = 31;
            this.userRespProjet.ValueMember = "IdUser";
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Chef de projet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nom du projet :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Enregistrer les données";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Modifier cette exigence";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(657, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 23);
            this.button4.TabIndex = 39;
            this.button4.Text = "Modifier cette tâche";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1063, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 24);
            this.button5.TabIndex = 41;
            this.button5.Text = "Modifier ce jalon";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listJalon
            // 
            this.listJalon.FormattingEnabled = true;
            this.listJalon.Location = new System.Drawing.Point(841, 369);
            this.listJalon.Name = "listJalon";
            this.listJalon.Size = new System.Drawing.Size(379, 21);
            this.listJalon.TabIndex = 40;
            // 
            // nomProjet
            // 
            this.nomProjet.Location = new System.Drawing.Point(40, 148);
            this.nomProjet.Name = "nomProjet";
            this.nomProjet.Size = new System.Drawing.Size(407, 20);
            this.nomProjet.TabIndex = 42;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Liste des exigences de ce projet : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Liste des tâches de ce projet : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(838, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Liste des jalons de ce projet : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "Modifier projet";
            // 
            // ModifProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 522);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomProjet);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listJalon);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateFinProjet);
            this.Controls.Add(this.dateDebutProjet);
            this.Controls.Add(this.userRespProjet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listTache);
            this.Controls.Add(this.listExigence);
            this.Name = "ModifProjet";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ModifProjet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listExigence;
        private System.Windows.Forms.ComboBox listTache;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFinProjet;
        private System.Windows.Forms.DateTimePicker dateDebutProjet;
        private System.Windows.Forms.ComboBox userRespProjet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox listJalon;
        private System.Windows.Forms.TextBox nomProjet;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private Database1DataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
    }
}