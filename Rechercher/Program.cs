using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Configuration;

namespace Rechercher
{
    static class Program
    {

        public static void RemplirComboBox(DataTable dt, ComboBox cbx, string afficher, string selectionner)
        {
            cbx.DataSource = dt;
            cbx.DisplayMember = afficher;
            cbx.ValueMember = selectionner;
            cbx.Refresh();

        }



        public static void ControleSaisieTextBox(TextBox txb, string msgErreur)
        {
            txb.BackColor = Color.Yellow;
            MessageBox.Show(msgErreur + " est obligatoire !!!", "Pour votre information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txb.BackColor = Color.White;
            txb.Select();
        }




        public static DataTable SelectTable(string champs, string tables, string NomDataTable, string WhereSql = null, string GroupBySql = null, string HavingSql = null, string OrderBySql = null)
        {
            string query = "SELECT " + champs +
                            " FROM " + tables;
            if (WhereSql != null)
            {
                query += " WHERE " + WhereSql;
            }
            if (GroupBySql != null)
            {
                query += " GROUP BY " + GroupBySql;
            }
            if (HavingSql != null)
            {
                query += " HAVING " + HavingSql;
            }
            if (OrderBySql != null)
            {
                query += " ORDER BY " + OrderBySql;
            }
            SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=Db_Produit;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, NomDataTable);
            return ds.Tables[NomDataTable];

        }


        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
