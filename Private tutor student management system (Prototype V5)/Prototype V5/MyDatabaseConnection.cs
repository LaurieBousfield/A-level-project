using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
//using ADOX;


//namespace AccessingDataInADatabase
namespace DatabaseCreation
{
    class DatabaseConnection
    {
       // private const string EXAMPLEDB = "ExampleDatabase.mdb";
       // private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";

        private string sql_string;
        private string strCon;
        private OleDbDataAdapter daStudent;

        public string Sql
        {
            set { sql_string = value; }
        }

        public string connection_string
        {
            set { strCon = value; }
        }

        public System.Data.DataTable GetConnection
        {
            //get { return MyDataSet(); }
            get { return MyDataTable(); }
        }

        private System.Data.DataTable MyDataTable()
        {
            OleDbConnection connection = new OleDbConnection(strCon);
           
            connection.Open();
             
            daStudent = new OleDbDataAdapter(sql_string, connection);

            System.Data.DataTable dat_table = new System.Data.DataTable();
            daStudent.Fill(dat_table);
            connection.Close();
            return dat_table;
            
        }


    }
}
