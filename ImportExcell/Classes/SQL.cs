using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportExcell.Classes
{
    public class SQL
    {
        private string DataSourcedefault = "";
        private string UserIdDefault = "";
        private string PasswordDefault = "";
        private string InitialCatalogDefault = "";
        public bool ConnectionState = false;

        public void SetValues(string IP,string Instance,string User,string Pass,string Initial)
        {
            DataSourcedefault = $"{IP}\\{Instance}";
            UserIdDefault = User;
            PasswordDefault = Pass;
            InitialCatalogDefault = Initial;
        }

        public string ExecuteScalar(string pSql = "")
        {
            

            SqlConnection connection = new SqlConnection(string.Format(
                $"Data Source={DataSourcedefault};Initial Catalog={InitialCatalogDefault};User ID={UserIdDefault};Password={PasswordDefault}"));
            connection.Open();
            string str5 = Convert.ToString(new SqlCommand(pSql, connection).ExecuteScalar());
            connection.Close();
            return str5;
        }

        public string ExecuteNonQuery(string pSql = "")
        {
            
            SqlConnection connection = new SqlConnection(string.Format(
                $"Data Source={DataSourcedefault};Initial Catalog={InitialCatalogDefault};User ID={UserIdDefault};Password={PasswordDefault}"));
            
            connection.Open();
            string str5 = Convert.ToString(new SqlCommand(pSql, connection).ExecuteNonQuery());
            connection.Close();
            return str5;
        }
    }
}


