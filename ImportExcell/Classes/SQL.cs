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

        public void SetValues(string IP, string Instance, string User, string Pass, string Initial)
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
        public object ExecuteScalar(string pSql, bool pShowError = true, string pErrorMessage = "")
        {


            SqlConnection connection = new SqlConnection(string.Format(
                $"Data Source={DataSourcedefault};Initial Catalog={InitialCatalogDefault};User ID={UserIdDefault};Password={PasswordDefault}"));
            connection.Open();
            object str5 = Convert.ToString(new SqlCommand(pSql, connection).ExecuteScalar());
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
        public static string Nvl(object pObj, string pDefaultValue = "")
        {
            try
            {
                return pObj == null || pObj.ToString() == "" ? pDefaultValue : pObj.ToString();
            }
            catch
            {
                return pDefaultValue;
            }
        }
        public object CreateSequence(
            string pSqe,
            string pStartValue,
            bool pShowError = true,
            string pErrorMessage = "")
        {
            try
            {
                return this.ExecuteScalar(string.Format("CREATE SEQUENCE [{0}] \r\n                                                             AS [bigint]\r\n                                                             START WITH {1}\r\n                                                             INCREMENT BY 1\r\n                                                             MINVALUE -9223372036854775808\r\n                                                             MAXVALUE 9223372036854775807\r\n                                                             CACHE ", (object)pSqe, (object)Nvl((object)pStartValue, "1"))).ToString() != "-1" ? (object)1 : (object)-1;
            }
            catch (Exception ex)
            {
                if (pShowError)
                {

                    return (object)-1;
                }
                throw;
            }
        }

        public object GetSequenceValue(string pSqeName)
        {
            try
            {
                if (string.IsNullOrEmpty(pSqeName))
                {

                    return (object)null;
                }

                string str1 = Convert.ToString(this.ExecuteScalar(string.Format("Select next value for {0} ", (object)pSqeName)));
                if (str1 == "-1")
                {
                    string str2 = pSqeName.Replace("SQE_", "");
                    string[] strArray = str2.Split('_');
                    string str3 = strArray[strArray.Length - 1];
                    string str4 = str2.Replace("_" + str3, "");
                    string pStartValue = Nvl(this.ExecuteScalar(string.Format("select max({0})+1 from {1} ", (object)str3, (object)str4)), "1");
                    this.CreateSequence(pSqeName, pStartValue, true, "");
                    str1 = pStartValue;
                }
                return (object)str1;
            }
            catch (Exception ex)
            {

                return (object)null;
            }
        }
    }
}


