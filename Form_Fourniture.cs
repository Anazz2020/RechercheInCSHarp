using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechercher
{
    public partial class Form_Fourniture : Form
    {
        public Form_Fourniture()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Fourniture_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_GESTCOMMDataSet.Fournisseur' table. You can move, or remove it, as needed.
            this.fournisseurTableAdapter.Fill(this.bD_GESTCOMMDataSet.Fournisseur);

            txt_code.Text = Form1.p.Code_P1.ToString();
            txt_lbl.Text = Form1.p.Libelle1.ToString();
            txt_qntStocke.Text= Form1.p.QntStockee1.ToString();
            txt_sr.Text= Form1.p.SeuiR1.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClassLibrary2.Connexion.cmd.CommandText = "INSERT INTO Fourniture VALUES (@Num_F,@Code,@Qnt)";
            ClassLibrary2.Connexion.cmd.Parameters.Clear();
            ClassLibrary2.Connexion.cmd.Parameters.AddWithValue("@Num_F", comboBox1.SelectedValue);
            ClassLibrary2.Connexion.cmd.Parameters.AddWithValue("@Code", txt_code.Text);
            ClassLibrary2.Connexion.cmd.Parameters.AddWithValue("@Qnt", txt_qnt.Text);
            ClassLibrary2.Connexion.ExucuetRequet_MisAjour();
            this.Close();

        }
    }
}
