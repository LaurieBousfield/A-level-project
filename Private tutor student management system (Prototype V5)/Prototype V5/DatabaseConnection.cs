using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
//using ADOX;


//namespace AccessingDataInADatabase
namespace StudentDataApp
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
        /* This method (function) creates a connection to a database and then uses a data adapter to run an SQL query contained
         in the property sql_string. The resulting table is part of the data adapter object and the data adapters
        Fill() method os called to populate a locally declared data table. This populated data table is the return 
        value of the function */


            // Create a new connection to the database

            // System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection(CONNECTION_STRING);
            //System.Data.OleDb referenced by default
            OleDbConnection connection = new OleDbConnection(strCon);
           
            connection.Open();
             
            //daStudent = new System.Data.OleDb.OleDbDataAdapter(sql_string, connection);
            daStudent = new OleDbDataAdapter(sql_string, connection);

            System.Data.DataTable dat_table = new System.Data.DataTable();
            daStudent.Fill(dat_table);
            connection.Close();
            return dat_table;
            
        }


    }
}
