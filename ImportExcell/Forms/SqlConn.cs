using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportExcell.Forms
{
    public partial class SqlConn : Form
    {
        public string ServerName;
        public string InstanceName;
        public string UserName;
        public string Password;
        public string InitialCatalog;
        public SqlConn()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            ServerName = txtServer.Text;
            InstanceName = txtInstance.Text;
            UserName = txtUser.Text;
            Password = txtPass.Text;
            InitialCatalog = txtInitial.Text;
            Close();
        }
    }
}
