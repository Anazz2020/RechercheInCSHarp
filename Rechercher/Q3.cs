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
    public partial class Q3 : Form
    {
        public Q3()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader Dr ;
        string col;
        DataTable dt;
        string MsgSt;

 

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButton1.Checked == true )
            {
                char p = e.KeyChar;
                if (!char.IsDigit(p) &&  p!= 8)//8 pour upprimer et 46 pour la virgule
                    e.Handled = true;
            }
            else if (radioButton2.Checked == true)
            {
                char p = e.KeyChar;
                if (char.IsDigit(p) && p != 46 && p != 8)
                    e.Handled = true;
            }
            else if (radioButton3.Checked == true)
            {
                char p = e.KeyChar;
                if (!char.IsDigit(p) && p != 46 && p != 8)
                    e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = null;
            }
            else
            {

                if (radioButton1.Checked == true)
                {
                    col = " Code_Pro ";
                }
                if (radioButton2.Checked == true)
                {
                    col = " Libelle ";
                }
                if (radioButton3.Checked == true)
                {
                    col = " Code_Pro ";
                }
                if (Rd_bon.Checked == true)
                {
                    MsgSt = "Bon";
                }
                if (Rd_passe.Checked ==true)
                {
                    MsgSt = "Passe Commande";
                }
                dt = new DataTable();
                con = new SqlConnection(@"Data Source=.;Initial Catalog=Db_Produit;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("select * from Produit where " + col + " Like '" + this.textBox1.Text + "%' or MsgStock ='" + MsgSt +  "'" , con);
                Dr = cmd.ExecuteReader();
                dt.Load(Dr);
                dataGridView1.DataSource = dt;
                con.Close();
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Le champs est introvable");

            }
            
        }

        private void Rd_bon_CheckedChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);//pour supprimer les champs dans le textbox ----CheckedChanged
        }

        private void Q3_Load(object sender, EventArgs e)
        {

        }
        //if (radioButton1.Checked == true)
        //{
        //    ds = new DataSet();
        //    con = new SqlConnection(@"Data Source=Lenovo\SQLEXPRESS;Initial Catalog=DB_Client_cammande;Integrated Security=True");
        //    cmd = new SqlCommand("select * from Produit where Code_P = '" + this.textBox1.Text + " '" , con);
        //    da = new SqlDataAdapter(cmd);
        //    da.Fill(ds, "Produit");
        //    dataGridView1.DataSource = ds.Tables["Produit"];
        //    if (ds.Tables["Produit"].Rows.Count == 0)
        //    {
        //        MessageBox.Show( "Le code de produit  est introvable !!!");
        //    }

        //}




    }
}

