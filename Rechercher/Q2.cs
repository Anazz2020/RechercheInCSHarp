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
    public partial class Q2 : Form
    {
        public Q2()
        {
            InitializeComponent();
        }
        SqlConnection cn_md;
        SqlDataAdapter da_md;
        DataSet ds;
        SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            cn_md = new SqlConnection(@"Data Source=.;Initial Catalog=Db_Produit;Integrated Security=True");
            cmd = new SqlCommand("select P.Libelle ,C.Date  , D.[PrixVente]  from Commande C inner join DetailsCommande D ON C.Num_Com=D.Num_COM " +
                    "  inner join Produit P ON D.Num_P = P.Code_P where C.Date between '" + Datedébut.Value.ToString() + "' and '" + DateFin.Value.ToString() + "'", cn_md);
            da_md = new SqlDataAdapter(cmd);
            da_md.Fill(ds, "Command");
            dataGridView1.DataSource = ds.Tables["Command"];
            if (ds.Tables["Command"].Rows.Count == 0)
            {
                MessageBox.Show("le produit est introvable !!! ");
            }
            
        }
    }
}
