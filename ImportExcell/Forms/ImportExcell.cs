using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
namespace ImportExcell.Forms
{
    public partial class ImportExcell : Form
    {

        #region Variables
        Classes.SQL sqlCmd = new Classes.SQL();
        DataTable dt = new DataTable();
        List<string> vTur = new List<string>();

        #endregion

        #region Override Functions

        #endregion

        #region Other Functions

        #endregion

        #region LoadData Functions

        #endregion

        #region Form Declerations
        private void btnAdd_Click(object sender, EventArgs e)
        {
            vTur.Add(txtDataType.Text.ToString());
            dataGridView1.Columns.Add(txtTableColumn.Text.ToString(), txtExcellColumn.Text.ToString());

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Remove(txtExcellColumn.Text.ToString());

        }
        private void ImportExcell_Load(object sender, EventArgs e)
        {
            var vForm = new SqlConn();
            vForm.ShowDialog();
            sqlCmd.SetValues(vForm.ServerName, vForm.InstanceName, vForm.UserName, vForm.Password, vForm.InitialCatalog);
        }
        private void BtnReadExcell_Click(object sender, EventArgs e)
        {
            if (txtSheet.EditValue != null)
            {
                dataGridView2.DataSource = null;
                OpenFileDialog file = new OpenFileDialog();
                file.ShowDialog();
                string fileName = file.FileName.ToString();

                OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
                Data Source=" + fileName + "; Extended Properties='Excel 12.0 Xml; HDR = YES;'");
                string sheetName = txtSheet.Text.ToString();

                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [" + sheetName + "$]", baglanti);
                da.Fill(dt);
                dataGridView2.DataSource = dt;

            }

            else
            {
                MessageBox.Show("Lütfen excelldeki çalışma sayfasını belirtiniz...");
            }
        }

        private void btnImportExcell_Click(object sender, EventArgs e)
        {
            if (txtDbName.EditValue != null)
            {
                dt.Columns[0].ColumnName.ToString();
                string s = dataGridView1.Columns[0].Name.ToString();
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    s = s + "," + dataGridView1.Columns[i].Name.ToString();
                }
                //insert into kemalkartsend() values('kemal','gaya',1,1.5,15.03.1965);
                string val = "temp";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (vTur[0] == "int")
                    {
                        val = "'" + Convert.ToInt32(dt.Rows[i][dt.Columns[0].Caption.ToString()].ToString()) + "'";

                    }
                    else if (vTur[0] == "float")
                    {
                        string a = dt.Rows[i][dt.Columns[0].Caption.ToString()].ToString();
                        string replacement = a.Replace(',', '.');
                        val = "'" + Convert.ToDouble(replacement) + "'";

                    }
                    else if (vTur[0] == "datetime")
                    {
                        string a = dt.Rows[i][dt.Columns[0].Caption.ToString()].ToString();
                        DateTime dta = Convert.ToDateTime(a);
                        val = "'" + dta + ",1'";

                    }
                    else if (vTur[0] == "string")
                    {
                        val = "'" + dt.Rows[i][dt.Columns[0].Caption.ToString()].ToString() + "'";

                    }
                    for (int j = 1; j < dataGridView1.Columns.Count; j++)
                    {
                        if (vTur[j] == "int")
                        {
                            val = val + "," + Convert.ToInt32(dt.Rows[i][dt.Columns[j].Caption.ToString()].ToString()) + "";

                        }
                        else if (vTur[j] == "float")
                        {
                            string a = dt.Rows[i][dt.Columns[j].Caption.ToString()].ToString();

                            string replacement = a.Replace(',', '.');
                            val = val + "," + replacement + "";

                        }
                        else if (vTur[j] == "datetime")
                        {
                            //convert(datetime,'18-06-12 10:34:09 PM',5)
                            string a = dt.Rows[i][dt.Columns[j].Caption.ToString()].ToString();



                            val = val + ",CONVERT(datetime,'" + a + "',104)";

                        }
                        else if (vTur[j] == "string")
                        {
                            val = val + ",'" + dt.Rows[i][dt.Columns[j].Caption.ToString()].ToString() + "'";

                        }
                    }
                    // WebTools.Classes.SQL.ExecuteNonQuery("insert into KEMALKARTSEND(ADI,SOYADI,SKARTNO,NFCKARTNO,SUBEKODU) values('Kemal','Gaya',1,1.2,'15.03.1965')");
                    //CONVERT(nvarchar,@date, @counter
                    sqlCmd.ExecuteNonQuery("insert into " + txtDbName.Text + "(" + s + ") values(" + val + ")");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Database ismi giriniz");
            }


        }
        #endregion

        #region Initialize        
        public ImportExcell()
        {
            InitializeComponent();
        }





        #endregion

        

        private void btnSaveAnother_Click(object sender, EventArgs e)
        {
            var Vform = new SaveAnotherTable();
            Vform.ShowDialog();

             for (int i = 0; i < dt.Rows.Count; i++)
            {
                string a = dt.Rows[i][Vform.ExcellColumn].ToString();
                MessageBox.Show(a);
            }


        }
    }
}
