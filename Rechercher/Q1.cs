using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rechercher
{
    public partial class Q1 : Form
    {
        public Q1()
        {
            InitializeComponent();
        }
        SqlConnection cn_md;
        SqlDataAdapter da_md;
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            
                ds = new DataSet();
                cn_md = new SqlConnection(@"Data Source=.;Initial Catalog=Db_Produit;Integrated Security=True");
                da_md = new SqlDataAdapter(" select  O.[Code_O],P.[Code_Pro], P.[Libelle],O.[Intitule] from [dbo].[Produit] P join [dbo].[Origine] O on O.[Code_O]=P.[Origine] where O.[Code_O]  = " + this.cmb_1.SelectedValue, cn_md);
                da_md.Fill(ds, "Origine");
                dataGridView1.DataSource = ds.Tables["Origine"];
            
            if (ds.Tables["Origine"].Rows.Count == 0)
            {
                MessageBox.Show("le produit est introvable !!!");
            }

            //if (cmb_1.SelectedIndex >-1) 
            //else if (textBox1.Text !=null)
            //{
            //    ds = new DataSet();
            //    cn_md = new SqlConnection(@"Data Source=Lenovo\SQLEXPRESS;Initial Catalog=DB_Client_cammande;Integrated Security=True");
            //    da_md = new SqlDataAdapter(" select  O.[Code_O], P.[Libelle],O.[Intitule] from [dbo].[Produit] P join [dbo].[Origine] O on O.[Code_O]=P.[Origine] where O.[Code_O] = " + this.textBox1.Text, cn_md);
            //    da_md.Fill(ds, "Origine");
            //    dataGridView1.DataSource = ds.Tables["Origine"];

            //}
            
        }

        private void Q1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ProduitDataSet.Origine' table. You can move, or remove it, as needed.
            this.origineTableAdapter.Fill(this.db_ProduitDataSet.Origine);
            //Program.RemplirComboBox(Program.SelectTable(" * ", " Origine ", "DTorigine", null, null, null, " Intitule ASC"), this.cmb_1, "Intitule", "Code_O");

        }
    }
}
