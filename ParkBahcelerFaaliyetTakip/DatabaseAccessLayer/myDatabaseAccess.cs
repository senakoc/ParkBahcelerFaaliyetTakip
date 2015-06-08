using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using DatabaseAccessValues;

namespace DatabaseAccessLayer
{
    public class myDatabaseAccess
    {
        #region Global değişkenler
       
        //sql değişkenleri
        private SqlConnection connection = null;
        private SqlDataAdapter adtr = null;
        private SqlCommand command = null;
        private SqlDataReader dReader = null;
        private DataTable dTable = null;

        //fonksiyonlar için oluşturulan değişkenler
        private List<string> dataList = null; // reader ile okunan verileri tutucak
        private int affectedRows = 0; // sorgu sonucu etkilenen satır sayısını tutacak
        private int scalarResult = 0; // aritmetik sorgu sonucu dönen veriyi tutacak
       
        #endregion Global END

        #region 1. Bağlantıyı sağlayan fonksiyon
        public bool ConnectionDatabase(connectionValues values)
        {
            try
            {
                connection = new SqlConnection("Server = " + values.Server + "; Initial Catalog = " + values.Database + ";  Integrated Security=true;");
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion 1. END

        #region 2. Datareader ile veri okuma
        public List<string> getDatareaderDataList(string query) 
        {
            try
            {
                dataList = new List<string>();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = new SqlCommand(query,connection);
                dReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dReader.Read())
                {
                    dataList.Add(dReader.GetString(0));
                }
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
                
                return dataList;
            }
            catch (Exception)
            {

                return null;
            }
        }
        #endregion 2. END

        #region 3. Datagridview DataSource
        public DataTable getDatagridDatasource(string databaseName,string tableName)
        {
            try
            {
                adtr = new SqlDataAdapter("SELECT ROW_NUMBER() OVER (ORDER BY KayitNo ) AS 'SatırNo',* FROM ["+databaseName+"].[dbo].[" + tableName + "]", connection);
                dTable = new DataTable(tableName);
                adtr.Fill(dTable);

                return dTable;
            }
            catch (Exception)
            {

                return null;
            }
           
        }
        #endregion 3. END

        #region 4. Sorgu executenonQuery
        public int executeQuery(string query)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = new SqlCommand(query,connection);
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion 4. END

        #region 5. Sogu executeScalar
        public object executeScalarQuery(string query) 
        {
            object resultScalar = null;
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
                resultScalar = (int)command.ExecuteScalar();
                return resultScalar;
            }
            catch (Exception)
            {
                return resultScalar;
            }
        }
        #endregion 5. END

        #region 6. Farklı sorgular için Data table
        public DataTable getDataTable(string query) 
        {
            try
            {
                adtr = new SqlDataAdapter(query, connection);
                dTable = new DataTable("TAblo");
                adtr.Fill(dTable);

                return dTable;
            }
            catch (Exception)
            {

                return null;
            }
        }
        #endregion 6. END

        #region
        #endregion

        #region
        #endregion
    }
}
