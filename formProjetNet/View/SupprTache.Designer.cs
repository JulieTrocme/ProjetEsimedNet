namespace formProjetNet.View
{
    partial class SupprTache
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
            this.label5 = new System.Windows.Forms.Label();
            this.deleteProjet = new System.Windows.Forms.Button();
            this.listTache = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.database1DataSet = new formProjetNet.Database1DataSet();
            this.tacheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacheTableAdapter = new formProjetNet.Database1DataSetTableAdapters.tacheTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Supprimer tache";
            // 
            // deleteProjet
            // 
            this.deleteProjet.Location = new System.Drawing.Point(618, 221);
            this.deleteProjet.Name = "deleteProjet";
            this.deleteProjet.Size = new System.Drawing.Size(75, 23);
            this.deleteProjet.TabIndex = 42;
            this.deleteProjet.Text = "Supprimer";
            this.deleteProjet.UseVisualStyleBackColor = true;
            this.deleteProjet.Click += new System.EventHandler(this.deleteProjet_Click);
            // 
            // listTache
            // 
            this.listTache.DataSource = this.tacheBindingSource;
            this.listTache.DisplayMember = "libelle";
            this.listTache.FormattingEnabled = true;
            this.listTache.Location = new System.Drawing.Point(51, 144);
            this.listTache.Name = "listTache";
            this.listTache.Size = new System.Drawing.Size(642, 21);
            this.listTache.TabIndex = 41;
            this.listTache.ValueMember = "idTache";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Liste des taches : ";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tacheBindingSource
            // 
            this.tacheBindingSource.DataMember = "tache";
            this.tacheBindingSource.DataSource = this.database1DataSet;
            // 
            // tacheTableAdapter
            // 
            this.tacheTableAdapter.ClearBeforeFill = true;
            // 
            // SupprTache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteProjet);
            this.Controls.Add(this.listTache);
            this.Controls.Add(this.label1);
            this.Name = "SupprTache";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SupprTache_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteProjet;
        private System.Windows.Forms.ComboBox listTache;
        private System.Windows.Forms.Label label1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tacheBindingSource;
        private Database1DataSetTableAdapters.tacheTableAdapter tacheTableAdapter;
    }
}