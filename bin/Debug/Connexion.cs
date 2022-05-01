using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
namespace ClassLibrary2
{
    public  class Connexion 
    {
        
        private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public static SqlCommand cmd=new SqlCommand();

        //Mode Connecter 
        public static SqlDataReader dtr;
        public static DataTable dtb;


        //Mode Deconnecter
        public static  SqlDataAdapter dtAdapt;
        public static DataSet dts=new DataSet();
        public static DataRow dtRow;
        public static SqlCommandBuilder Bulder;
        




        static Connexion()
        {
            
        }

        public static void Connecter()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.Open();
            }
            cmd.Connection = con;

        }

        public static void Deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }

       
       public static DataTable Select(String Mod,String Colomns ,String Table, bool grid=false, string join=null, string Where = null, string GroupBy=null,string Having= null , string OrderBy=null , String TypeOrder="asc")
        {
            cmd.Connection = con;
            cmd.CommandText = "Select " + Colomns + " From " + Table;
            if(join!=null)
            {
                cmd.CommandText +=" "+join;
            }
            if(Where!=null)
            {
                cmd.CommandText += " Where " + Where;
            }
            if (GroupBy != null)
            {
                cmd.CommandText += " Group By " + GroupBy;
            }
            if (Having != null)
            {
                cmd.CommandText += " Having " + Having;
            }
            if (OrderBy != null)
            {
                cmd.CommandText += " Order By " + OrderBy;
                if(TypeOrder!="asc")
                {
                    cmd.CommandText += " desc ";
                }

            }
            if(Mod=="Connecter")
            {
                ExucuetRequet_Reader();

                return dtb;
            }
            else
            {
                string nomTable=Table;
                if(grid)
                {
                    nomTable += "Grid";
                }
                dtAdapt = new SqlDataAdapter(cmd);
              
                dtAdapt.Fill(dts, nomTable);

                return dts.Tables[nomTable];
               
            }
           


        }

        #region Mode Connecter
        public static void ExucuetRequet_Reader()
        {
            Connecter();
            dtb = new DataTable();
            dtr = cmd.ExecuteReader();
            dtb.Load(dtr);
            Deconnecter();
           
        }
      public  static Double ExucuetRequet_Scalair()
        {
            Connecter();
            Double nb=(double)cmd.ExecuteScalar();
            Deconnecter();
            return nb;
        }

       public static int ExucuetRequet_MisAjour()
        {
            int nb;
            Connecter();
            try
            {
                nb = cmd.ExecuteNonQuery();
            }
            catch
            {
                nb = 0;
            }         
            Deconnecter();

            return nb;
        }
        #endregion


        #region Mode Deconnecter

        public static void Enregistrer(string Table)
        {
        
            Bulder = new SqlCommandBuilder(dtAdapt);
            dtAdapt.Update(dts,Table);


            

        }

        public static int Recherch(int Code , string Table)
        {


            for (int i = 0; i < Connexion.dts.Tables[Table].Rows.Count; i++)
            {
                if (Code == int.Parse(Connexion.dts.Tables[Table].Rows[i].ItemArray[0].ToString()))
                {
                    return i;

                }


            }
            return -1;
        }

        public static void SuPPP_md(int Index,string Table)
        {
            
            Connexion.dts.Tables[Table].Rows[Index].Delete();
          //  Connexion.dts.Tables[Table].Rows.RemoveAt(Index);


        }


        #endregion
    }
}