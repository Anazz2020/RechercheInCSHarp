namespace Rechercher
{
    partial class Q4
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
            this.Ch_Libelle = new System.Windows.Forms.CheckBox();
            this.Ch_Prix_Achat = new System.Windows.Forms.CheckBox();
            this.Ch_Prix_Vente = new System.Windows.Forms.CheckBox();
            this.Ch_Qte = new System.Windows.Forms.CheckBox();
            this.Ch_Origine = new System.Windows.Forms.CheckBox();
            this.Ch_Seuil = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ch_Color = new System.Windows.Forms.CheckBox();
            this.Ch_Msg = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ch_Code = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ch_Libelle
            // 
            this.Ch_Libelle.AutoSize = true;
            this.Ch_Libelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ch_Libelle.Location = new System.Drawing.Point(10, 71);
            this.Ch_Libelle.Name = "Ch_Libelle";
            this.Ch_Libelle.Size = new System.Drawing.Size(73, 24);
            this.Ch_Libelle.TabIndex = 1;
            this.Ch_Libelle.Text = "Libelle";
            this.Ch_Libelle.UseVisualStyleBackColor = true;
            // 
            // Ch_Prix_Achat
            // 
            this.Ch_Prix_Achat.AutoSize = true;
            this.Ch_Prix_Achat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ch_Prix_Achat.Location = new System.Drawing.Point(103, 15);
            this.Ch_Prix_Achat.Name = "Ch_Prix_Achat";
            this.Ch_Prix_Achat.Size = new System.Drawing.Size(95, 24);
            this.Ch_Prix_Achat.TabIndex = 2;
            this.Ch_Prix_Achat.Text = "PrixAchat";
            this.Ch_Prix_Achat.UseVisualStyleBackColor = true;
            // 
            // Ch_Prix_Vente
            // 
            this.Ch_Prix_Vente.AutoSize = true;
            this.Ch_Prix_Vente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ch_Prix_Vente.Location = new System.Drawing.Point(103, 45);
            this.Ch_Prix_Vente.Name = "Ch_Prix_Vente";
            this.Ch_Prix_Vente.Size = new System.Drawing.Size(96, 24);
            this.Ch_Prix_Vente.TabIndex = 3;
            this.Ch_Prix_Vente.Text = "PrixVente";
            this.Ch_Prix_Vente.UseVisualStyleBackColor = true;
            // 
            // Ch_Qte
            // 
            this.Ch_Qte.AutoSize = true;
            this.Ch_Qte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ch_Qte.Location = new System.Drawing.Point(211, 45);
            this.Ch_Qte.Name = "Ch_Qte";
            this.Ch_Qte.Size = new System.Drawing.Size(110, 24);
            this.Ch_Qte.TabIndex = 4;
            this.Ch_Qte.Text = "Qtestockee";
            this.Ch_Qte.UseVisualStyleBackColor = true;
            // 
            // Ch_Origine
            // 
            this.Ch_Origine.AutoSize = true;
            this.Ch_Origine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ch_Origine.Location = new System.Drawing.Point(211, 71);
            this.Ch_Origine.Name = "Ch_Origine";
            this.Ch_Origine.Size = new System.Drawing.Size(78, 24);
            this.Ch_Origine.TabIndex = 5;
            this.Ch_Origine.Text = "Origine";
            this.Ch_Origine.UseVisualStyleBackColor = true;
            // 
            // Ch_Seuil
            // 
            this.Ch_Seuil.AutoSize = true;
            this.Ch_Seuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ch_Seuil.Location = new System.Drawing.Point(211, 15);
            this.Ch_Seuil.Name = "Ch_Seuil";
            this.Ch_Seuil.Size = new System.Drawing.Size(102, 24);
            this.Ch_Seuil.TabIndex = 6;
            this.Ch_Seuil.Text = "SeuilReap";
            this.Ch_Seuil.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Ch_Code);
            this.panel1.Controls.Add(this.Ch_Color);
            this.panel1.Controls.Add(this.Ch_Prix_Vente);
            this.panel1.Controls.Add(this.Ch_Origine);
            this.panel1.Controls.Add(this.Ch_Msg);
            this.panel1.Controls.Add(this.Ch_Qte);
            this.panel1.Controls.Add(this.Ch_Libelle);
            this.panel1.Controls.Add(this.Ch_Seuil);
            this.panel1.Controls.Add(this.Ch_Prix_Achat);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 121);
            this.panel1.TabIndex = 7;
            // 
            // Ch_Color
            // 
            this.Ch_Color.AutoSize = true;
            this.Ch_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ch_Color.Location = new System.Drawing.Point(10, 45);
            this.Ch_Color.Name = "Ch_Color";
            this.Ch_Color.Size = new System.Drawing.Size(65, 24);
            this.Ch_Color.TabIndex = 9;
            this.Ch_Color.Text = "Color";
            this.Ch_Color.UseVisualStyleBackColor = true;
            // 
            // Ch_Msg
            // 
            this.Ch_Msg.AutoSize = true;
            this.Ch_Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ch_Msg.Location = new System.Drawing.Point(103, 71);
            this.Ch_Msg.Name = "Ch_Msg";
            this.Ch_Msg.Size = new System.Drawing.Size(99, 24);
            this.Ch_Msg.TabIndex = 8;
            this.Ch_Msg.Text = "MsgStock";
            this.Ch_Msg.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(93, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 26);
            this.textBox1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(350, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 121);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(93, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rechercher";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 245);
            this.dataGridView1.TabIndex = 10;
            // 
            // Ch_Code
            // 
            this.Ch_Code.AutoSize = true;
            this.Ch_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ch_Code.Location = new System.Drawing.Point(10, 15);
            this.Ch_Code.Name = "Ch_Code";
            this.Ch_Code.Size = new System.Drawing.Size(66, 24);
            this.Ch_Code.TabIndex = 10;
            this.Ch_Code.Text = "Code";
            this.Ch_Code.UseVisualStyleBackColor = true;
            // 
            // Q4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(633, 408);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Q4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox Ch_Libelle;
        private System.Windows.Forms.CheckBox Ch_Prix_Achat;
        private System.Windows.Forms.CheckBox Ch_Prix_Vente;
        private System.Windows.Forms.CheckBox Ch_Qte;
        private System.Windows.Forms.CheckBox Ch_Origine;
        private System.Windows.Forms.CheckBox Ch_Seuil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Ch_Msg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox Ch_Color;
        private System.Windows.Forms.CheckBox Ch_Code;
    }
}