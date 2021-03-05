namespace formProjetNet.View
{
    partial class SupprJalon
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
            this.listJalon = new System.Windows.Forms.ComboBox();
            this.tacheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new formProjetNet.Database1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tacheTableAdapter = new formProjetNet.Database1DataSetTableAdapters.tacheTableAdapter();
            this.jalon2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jalon2TableAdapter = new formProjetNet.Database1DataSetTableAdapters.Jalon2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jalon2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Supprimer jalon";
            // 
            // deleteProjet
            // 
            this.deleteProjet.Location = new System.Drawing.Point(624, 226);
            this.deleteProjet.Name = "deleteProjet";
            this.deleteProjet.Size = new System.Drawing.Size(75, 23);
            this.deleteProjet.TabIndex = 46;
            this.deleteProjet.Text = "Supprimer";
            this.deleteProjet.UseVisualStyleBackColor = true;
            this.deleteProjet.Click += new System.EventHandler(this.deleteProjet_Click);
            // 
            // listJalon
            // 
            this.listJalon.DataSource = this.jalon2BindingSource;
            this.listJalon.DisplayMember = "libelle";
            this.listJalon.FormattingEnabled = true;
            this.listJalon.Location = new System.Drawing.Point(57, 149);
            this.listJalon.Name = "listJalon";
            this.listJalon.Size = new System.Drawing.Size(642, 21);
            this.listJalon.TabIndex = 45;
            this.listJalon.ValueMember = "idJalon";
            // 
            // tacheBindingSource
            // 
            this.tacheBindingSource.DataMember = "tache";
            this.tacheBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Liste des jalons : ";
            // 
            // tacheTableAdapter
            // 
            this.tacheTableAdapter.ClearBeforeFill = true;
            // 
            // jalon2BindingSource
            // 
            this.jalon2BindingSource.DataMember = "Jalon2";
            this.jalon2BindingSource.DataSource = this.database1DataSet;
            // 
            // jalon2TableAdapter
            // 
            this.jalon2TableAdapter.ClearBeforeFill = true;
            // 
            // SupprJalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteProjet);
            this.Controls.Add(this.listJalon);
            this.Controls.Add(this.label1);
            this.Name = "SupprJalon";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SupprJalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jalon2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteProjet;
        private System.Windows.Forms.ComboBox listJalon;
        private System.Windows.Forms.BindingSource tacheBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Label label1;
        private Database1DataSetTableAdapters.tacheTableAdapter tacheTableAdapter;
        private System.Windows.Forms.BindingSource jalon2BindingSource;
        private Database1DataSetTableAdapters.Jalon2TableAdapter jalon2TableAdapter;
    }
}