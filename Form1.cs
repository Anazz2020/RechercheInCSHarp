using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Rechercher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Declaration & Function
        public static String where="";
        String champ = "p.Code_P",champ2="", afii;
        public static ClassLibrary2.Produit p;
        private bool Verf()

        {
            bool vr = false;
            afii = "";
           string Name;
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is System.Windows.Forms.CheckBox)
                    {
                        if ((control as System.Windows.Forms.CheckBox).Checked == true && (control as System.Windows.Forms.CheckBox).Name!= "checkBox1")
                        {
                            switch(control.Name)
                            {
                                case "Code_P": Name = "p.Code_P as [Code Produit]"; break;
                                case "msgStock": Name = "msgStock as [Message Stockee]"; break;
                                case "Origine": Name = "o.intitule as [Orgine]"; break;
                                default: Name = control.Name; break;



                            }


                            afii += " ,"+Name ;
                            vr = true;
                          
                        }
                           
                    }

                    else
                        func(control.Controls);
            };
            func(Controls);
           if(afii!="")
            {
                afii = afii.Substring(2).ToString();
            }
           else
            {
                dataGridView5.DataSource = null;

            }
           
            return vr;

        }

        #endregion

        #region Q1
        private void button2_Click(object sender, EventArgs e)
        {
            string Orderby;
            Orderby = null;
            dataGridView1.DataSource = null;
            if (rdb_def.Checked==true)
            {
                where = null;
            }
            else
            {
                
                where =champ2+ " = " + "'" + comboBox_AFFICHER.Text + "'";
              
            }
            if (comboBox_ARRG.Text != "" && comboBox_ARRG.Text != "Par Defaus")
            {
                if(comboBox_ARRG.Text == "ORIGINE" )
                {
                    Orderby = "o.intitule";
                }
                else if(comboBox_ARRG.Text == "CODE_P")
                {
                    Orderby = "p.Code_P";
                }
                else
                {
                    Orderby = comboBox_ARRG.Text;
                }
                
            }
        

            dataGridView1.DataSource=   ClassLibrary2.Connexion.Select("Connecter", " p.Code_P as [Code Produit] , Libelle , Couleur , PrixAchat , PrixVente,Qtestockee,SeuilReapprovisionnement , msgStock as [Message Stocke ], o.intitule as [Origine]", "Produit", false, " p join Origine o on p.Origine=o.code_o",where,null,null,Orderby, (radioButton1.Checked == true ? "asc" : "desc"));
        
        }

        private void rdb_def_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_def.Checked == true)
            {
                comboBox_AFFICHER.ResetText();
                comboBox_AFFICHER.Enabled = false;
                champ2 = "";

            }
        }

        private void rdb_msg_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_AFFICHER.DataSource = ClassLibrary2.Produit.Distinct("msgStock", "produit");
            comboBox_AFFICHER.DisplayMember = "d";
            comboBox_AFFICHER.Enabled = true;
            champ2 = "msgStock";
        }

        private void rdb_coleur_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_AFFICHER.DataSource = ClassLibrary2.Produit.Distinct("Couleur", "produit");
            comboBox_AFFICHER.DisplayMember = "d";
            comboBox_AFFICHER.Enabled = true;
            champ2 = "Couleur";
        }

        private void rdb_Origine_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_AFFICHER.DataSource = ClassLibrary2.Produit.Distinct("intitule", "Origine");
            comboBox_AFFICHER.DisplayMember = "d";
            comboBox_AFFICHER.Enabled = true;
            champ2 = "o.intitule";
        }
        #endregion

        #region Q2
        private void button1_Click(object sender, EventArgs e)
        {

            if(dtp_D.Value<=dtp_F.Value)
            {
                where = " c.Date between '" + dtp_D.Text + "' and '" + dtp_F.Text + "'";
              
                dataGridView2.DataSource = ClassLibrary2.Connexion.Select("Connecter", "c.DATE as [Date Vender] , d.Qte_Com as [Qte Vender] ,p.*", "Produit",false, "p inner join DetailsCommande d on d.Num_P=p.code_P inner Join Commande c on c.Num_Com=d.Num_Com ", where);
                if(ClassLibrary2.Connexion.dtb.Rows.Count==0)
                {
                    MessageBox.Show("MaKaaayn Ta waa7d !! ", "Pour Votre information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verifer les Date !! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        #endregion

        #region Q3 /Part1 & Part2
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            where = champ + "  LIKE '" + textBox1.Text + "%'";
            dataGridView3.DataSource = ClassLibrary2.Connexion.Select("Connecter", " p.Code_P as [Code Produit] , Libelle , Couleur , PrixAchat , PrixVente,Qtestockee,SeuilReapprovisionnement , msgStock as [Message Stocke ], o.intitule as [Origine]", "Produit", false, " p join Origine o on p.Origine=o.code_o", where);
            if (textBox1.Text == "")
                dataGridView3.DataSource = null;



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {




            string and = rdb_bon.Checked == true ? "BON" : "Passe Commande";

            where = champ + " LIKE '" + textBox2.Text + "%'  AND (msgStocK = '" + and + "')";
            dataGridView4.DataSource = ClassLibrary2.Connexion.Select("Connecter", " p.Code_P as [Code Produit] , Libelle , Couleur , PrixAchat , PrixVente,Qtestockee,SeuilReapprovisionnement , msgStock as [Message Stocke ], o.intitule as [Origine]", "Produit", false, " p join Origine o on p.Origine=o.code_o", where);
            if (textBox2.Text == "")
                dataGridView4.DataSource = null;
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdb_pass.Checked == true)
            {
                p = new ClassLibrary2.Produit();
                p = p.AfficherProduit(int.Parse(ClassLibrary2.Connexion.dtb.Rows[e.RowIndex].ItemArray[0].ToString()));
                Form_Fourniture fr = new Form_Fourniture();
                fr.ShowDialog();
                dataGridView4.DataSource = ClassLibrary2.Connexion.Select("Connecter", " p.Code_P as [Code Produit] , Libelle , Couleur , PrixAchat , PrixVente,Qtestockee,SeuilReapprovisionnement , msgStock as [Message Stocke ], o.intitule as [Origine]", "Produit", false, " p join Origine o on p.Origine=o.code_o", where);

            }



        }
        #endregion

        #region Q4
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (Verf())
            {
                errorProvider1.SetError(label4, "");
                where = champ + " LIKE '" + textBox3.Text + "%'";

                if(comboBox1.Visible==true && comboBox1.Text != "Tout")
                {
                    where +=" and MsgStock = '"+comboBox1.Text+"'";
                }
                if (comboBox2.Visible == true && comboBox2.Text != "Tout")
                {
                    where += " and o.intitule = '" + comboBox2.Text + "'";
                }

                dataGridView5.DataSource = ClassLibrary2.Connexion.Select("Connecter", afii, "Produit", false, " p join Origine o on p.Origine=o.code_o", where);
                if (textBox3.Text=="")
                 dataGridView5.DataSource = null;
                
            }
            else
            {
                errorProvider1.SetError(label4, "choisir un Column");

            }

        }

        #region Event CheckBox

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked == true)
            {
                Action<Control.ControlCollection> func = null;
                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is System.Windows.Forms.CheckBox)
                        {
                            if ((control.Name != checkBox1.Name))
                            {
                                (control as System.Windows.Forms.CheckBox).Checked = true;
                            }

                        }

                        else
                            func(control.Controls);
                };
                func(Controls);

            }




        }

        private void Code_P_CheckedChanged(object sender, EventArgs e)
        {

            comboBox1.Visible = msgStock.Checked;
            comboBox2.Visible = Origine.Checked;
           
            

            bool vr = true;
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is System.Windows.Forms.CheckBox)
                    {
                        if ((control as System.Windows.Forms.CheckBox).Checked == false && (control as System.Windows.Forms.CheckBox).Name != "checkBox1")
                        {
                            vr = false;
                            break;

                        }



                    }

                    else
                        func(control.Controls);


            };
            func(Controls);
            if (vr == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            if (textBox3.Text != "")
                textBox3_TextChanged(sender, e);

        }

        private void dbt_Origine_CheckedChanged(object sender, EventArgs e)
        {

            if (dbt_Origine.Checked == true)
            {
                champ = "o.intitule";

                textBox3_TextChanged(sender, e);
            }
        }

        private void Origine_CheckStateChanged(object sender, EventArgs e)
        {
            if (Origine.CheckState == CheckState.Checked)
            {
                comboBox2.Text = "Tout";
            }
        }

        private void msgStock_CheckStateChanged(object sender, EventArgs e)
        {

            if (msgStock.CheckState == CheckState.Checked)
            {
                comboBox1.Text = "Tout";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3_TextChanged(sender, e);
        }
        #endregion
        #endregion

        #region Event RadioButton for All Q
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked==true || radioButton8.Checked == true || dbt_code.Checked == true)
            {
                champ = "p.Code_P";
                
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked == true ||  radioButton7.Checked == true || dbt_lbl.Checked == true)
            {
                champ = "Libelle";
               
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true || radioButton6.Checked == true || dbt_PrixA.Checked == true)
            {
                champ = "PrixAchat";
                
            }
        }
        #endregion

        #region Event keyPress for All Q
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if(radioButton5.Checked==true)
            {  
                if(!char.IsDigit(key) && key != 8 && key != 46)
                    {
                        e.Handled = true;
                    }
                
            }
            else
            {
                e.Handled = false;
            }

           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (dbt_code.Checked == true)
            {
                if (!char.IsDigit(key) && key != 8 && key != 46)
                {
                    e.Handled = true;
                }

            }
            else
            {
                e.Handled = false;
            }
        }



        

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'bD_GESTCOMMDataSet1.Origine' table. You can move, or remove it, as needed.
            this.origineTableAdapter.Fill(this.bD_GESTCOMMDataSet1.Origine);
            DataRow dro = bD_GESTCOMMDataSet1.Tables["Origine"].NewRow();
            dro[0] = "0";
            dro[1] = "Tout";
            dro[2] = "0";
            bD_GESTCOMMDataSet1.Tables["Origine"].Rows.Add(dro);


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(ClassLibrary2.Connexion.dtb.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER ;
            pdfTable.DefaultCell.BorderWidth = 1;
            

            //Adding Header row
            PdfPCell cell;
            for (int i = 0; i < ClassLibrary2.Connexion.dtb.Columns.Count; i++)
            {
                cell = new PdfPCell(new Phrase(ClassLibrary2.Connexion.dtb.Columns[i].ColumnName));
                cell.BackgroundColor = iTextSharp.text.BaseColor.BLUE ;
                cell.Phrase.Font.Color= iTextSharp.text.BaseColor.WHITE;


                pdfTable.AddCell(cell);
            }


            //Adding DataRow


            int row = ClassLibrary2.Connexion.dtb.Rows.Count;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < ClassLibrary2.Connexion.dtb.Columns.Count; j++)
                {
                    cell = new PdfPCell(new Phrase(ClassLibrary2.Connexion.dtb.Rows[i].ItemArray[j].ToString()));
                    if (ClassLibrary2.Connexion.dtb.Rows[i].ItemArray[j].ToString() == "Passe Commande")
                    {
                        cell.BackgroundColor = iTextSharp.text.BaseColor.RED;
                        cell.Phrase.Font.Color = iTextSharp.text.BaseColor.WHITE;
                    }
                   
                    pdfTable.AddCell(cell);
                       

                }


                

            }

            ///////////////////////////
            var sav = new SaveFileDialog();
            sav.FileName = "ListeDesProduits";
            sav.DefaultExt = ".pdf";
            try
            {

                if (sav.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(sav.FileName, FileMode.Create))
                    {

                        Document doc = new Document(PageSize.A0, 20F, 20f, 20f, 10f);
                        PdfWriter.GetInstance(doc, stream);
                        doc.Open();
                        doc.Add(new Phrase("                                                    Liste  Des Produits                            \n\n"));
                        doc.Add(new Phrase("Nombre DES Produit : " + ClassLibrary2.Connexion.dtb.Rows.Count + " \n Date :  "+DateTime.Now.Date.ToString("dd/MM/yyy")));


                        doc.Add(pdfTable);
                        doc.Close();
                        MessageBox.Show(" Saved successfully ", "Save (Pdf)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                }

            }
            catch
            {
                MessageBox.Show("An error has occurred\n * Please close(.pdf) files on your computer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBox_ARRG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (radioButton8.Checked == true)
            {
                if (!char.IsDigit(key) && key != 8 && key != 46)
                {
                    e.Handled = true;
                }

            }
            else
            {
                e.Handled = false;
            }
        }
        #endregion

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet workset = null;
            workset = workbook.Sheets["sheet1"];
            workset = workbook.ActiveSheet;
            workset.Name = "Liste Produit";
            for(int i = 1;i<=ClassLibrary2.Connexion.dtb.Columns.Count;i++)
            {
                workset.Cells[1, i] = ClassLibrary2.Connexion.dtb.Columns[i-1].ColumnName;
            }
          
            for (int i = 0; i < ClassLibrary2.Connexion.dtb.Rows.Count; i++)
            { 
                for(int j = 1; j<= ClassLibrary2.Connexion.dtb.Columns.Count;j++)
                {
                    workset.Cells[i + 2, j] = ClassLibrary2.Connexion.dtb.Rows[i].ItemArray[j - 1].ToString();

                }

            }
            var sav = new SaveFileDialog();
            sav.FileName = "Liste Des Produits";
            sav.DefaultExt = ".xlsx";
            try
            {
                if (sav.ShowDialog() == DialogResult.OK)
                {

                    workbook.SaveAs(sav.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    MessageBox.Show(" Saved successfully ", "Save (Excel)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                app.Quit();
            }
            catch
            {
                MessageBox.Show("An error has occurred\n * Please close(.xlsx) files on your computer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }



    }
}
