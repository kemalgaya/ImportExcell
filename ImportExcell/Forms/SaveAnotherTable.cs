using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImportExcell.Forms
{
    public partial class SaveAnotherTable : Form
    {
        public string TableName;
        public string ExcellColumn;
        public string TableColumn;
        public string DataType;
        public SaveAnotherTable()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TableName = txtDbName.Text;
            TableColumn = txtTableColumn.Text;
            ExcellColumn = txtExcellColumn.Text;
            DataType = txtDataType.Text;

            Close();
        }
    }
}
