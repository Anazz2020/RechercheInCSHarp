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
    public partial class Q4 : Form
    {
        public Q4()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            string chm="";
            if (Ch_Code.Checked == true)
            {
                chm += " Code_P ,";
            }
            if (Ch_Libelle.Checked == true)
            {
                chm += " Libelle ,";
            }
            if (Ch_Color.Checked == true)
            {
                chm += " Couleur ,";
            }
            if (Ch_Prix_Achat.Checked == true)
            {
                chm += " PrixAchat ,";
            }
            if (Ch_Prix_Vente.Checked == true)
            {
                chm += " PrixVente ,";
            }
            if (Ch_Qte.Checked == true)
            {
                chm += " QteStockee ,";
            }
            if (Ch_Seuil.Checked == true)
            {
                chm += " SeuilReapprovisionnement ,";
            }
            if (Ch_Msg.Checked == true)
            {
                chm += " MsgStock,";
            }

              if (Ch_Origine.Checked == true)
            {
                chm += " Origine,";
            }


              MessageBox.Show(chm.Substring(0,chm.Length-1)) ;
            con = new SqlConnection(@"Data Source=.;Initial Catalog=Db_Produit;Integrated Security=True");
            cmd = new SqlCommand("Select " + chm.Substring(0,chm.Length-1) + " from Produit where Code_P = '" + textBox1.Text + "'", con); 
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Produit");
            dataGridView1.DataSource = ds.Tables["Produit"];
 

        
        }  
    }
}
