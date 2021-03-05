namespace formProjetNet.View
{
    partial class SupprExigence
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
            this.listExigence = new System.Windows.Forms.ComboBox();
            this.exigenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new formProjetNet.Database1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.exigenceTableAdapter = new formProjetNet.Database1DataSetTableAdapters.exigenceTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exigenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Supprimer exigence";
            // 
            // deleteProjet
            // 
            this.deleteProjet.Location = new System.Drawing.Point(499, 220);
            this.deleteProjet.Name = "deleteProjet";
            this.deleteProjet.Size = new System.Drawing.Size(183, 23);
            this.deleteProjet.TabIndex = 42;
            this.deleteProjet.Text = "Supprimer";
            this.deleteProjet.UseVisualStyleBackColor = true;
            this.deleteProjet.Click += new System.EventHandler(this.deleteProjet_Click);
            // 
            // listExigence
            // 
            this.listExigence.DataSource = this.exigenceBindingSource;
            this.listExigence.DisplayMember = "besoin";
            this.listExigence.FormattingEnabled = true;
            this.listExigence.Location = new System.Drawing.Point(40, 143);
            this.listExigence.Name = "listExigence";
            this.listExigence.Size = new System.Drawing.Size(642, 21);
            this.listExigence.TabIndex = 41;
            this.listExigence.ValueMember = "IdExigence";
            // 
            // exigenceBindingSource
            // 
            this.exigenceBindingSource.DataMember = "exigence";
            this.exigenceBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Liste des exigences : ";
            // 
            // exigenceTableAdapter
            // 
            this.exigenceTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SupprExigence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteProjet);
            this.Controls.Add(this.listExigence);
            this.Controls.Add(this.label1);
            this.Name = "SupprExigence";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SupprExigence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exigenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteProjet;
        private System.Windows.Forms.ComboBox listExigence;
        private System.Windows.Forms.Label label1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource exigenceBindingSource;
        private Database1DataSetTableAdapters.exigenceTableAdapter exigenceTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}