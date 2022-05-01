namespace Rechercher
{
    partial class Q1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.db_ProduitDataSet = new Rechercher.Db_ProduitDataSet();
            this.origineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.origineTableAdapter = new Rechercher.Db_ProduitDataSetTableAdapters.OrigineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ProduitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 224);
            this.dataGridView1.TabIndex = 11;
            // 
            // cmb_1
            // 
            this.cmb_1.DataSource = this.origineBindingSource;
            this.cmb_1.DisplayMember = "Intitule";
            this.cmb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_1.FormattingEnabled = true;
            this.cmb_1.Location = new System.Drawing.Point(315, 36);
            this.cmb_1.Name = "cmb_1";
            this.cmb_1.Size = new System.Drawing.Size(147, 24);
            this.cmb_1.TabIndex = 10;
            this.cmb_1.ValueMember = "Code_O";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Shoiser le type     : ";
            // 
            // db_ProduitDataSet
            // 
            this.db_ProduitDataSet.DataSetName = "Db_ProduitDataSet";
            this.db_ProduitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // origineBindingSource
            // 
            this.origineBindingSource.DataMember = "Origine";
            this.origineBindingSource.DataSource = this.db_ProduitDataSet;
            // 
            // origineTableAdapter
            // 
            this.origineTableAdapter.ClearBeforeFill = true;
            // 
            // Q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_1);
            this.Controls.Add(this.label1);
            this.Name = "Q1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q1";
            this.Load += new System.EventHandler(this.Q1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ProduitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_1;
        private System.Windows.Forms.Label label1;
        private Db_ProduitDataSet db_ProduitDataSet;
        private System.Windows.Forms.BindingSource origineBindingSource;
        private Db_ProduitDataSetTableAdapters.OrigineTableAdapter origineTableAdapter;
    }
}