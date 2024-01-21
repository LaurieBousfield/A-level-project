using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using ADOX;
using System.Globalization;

namespace DatabaseCreation
{
    public partial class FrmDatabaseCreation : Form
    {
        private const string TutorDB = "TutorDatabase.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + TutorDB + ";";

        DatabaseConnection objConnect;
        DataTable LessonBookingEntity;
        DataTable LessonDurationEntity;
        DataTable StudentEntity;
        DataTable ParentEntity;
        DataRow dRow;

        int MaxRows;
        int inc;

        public FrmDatabaseCreation()
        {
            InitializeComponent();
        }

        //The three methods below allow entries from every entity in the database to be output by populating a DataTable
        private void NewStudentConnection()
        {
            try
            {
                objConnect = new DatabaseConnection();
                objConnect.connection_string = CONNECTION_STRING;

                objConnect.Sql = "SELECT * FROM Student";

                StudentEntity = objConnect.GetConnection;

                MaxRows = StudentEntity.Rows.Count;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void NewLessonDurationConnection()
        {
            try
            {
                objConnect = new DatabaseConnection();
                objConnect.connection_string = CONNECTION_STRING;

                objConnect.Sql = "SELECT * FROM LessonDuration";

                LessonDurationEntity = objConnect.GetConnection;

                MaxRows = LessonDurationEntity.Rows.Count;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void NewLessonBookingConnection()
        {
            try
            {
                objConnect = new DatabaseConnection();
                objConnect.connection_string = CONNECTION_STRING;

                objConnect.Sql = "SELECT * FROM LessonBooking";

                LessonBookingEntity = objConnect.GetConnection;

                MaxRows = LessonBookingEntity.Rows.Count;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void NewParentConnection()
        {
            try
            {
                objConnect = new DatabaseConnection();
                objConnect.connection_string = CONNECTION_STRING;

                objConnect.Sql = "SELECT * FROM Parent";

                ParentEntity = objConnect.GetConnection;

                MaxRows = ParentEntity.Rows.Count;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //**************************************************************************************************************

        private int DataSearch(DataTable drDataTable, string searchClause1, String searchClause2, string whichTable)
        {
            //This method will perform a linear search and return the row number in the data table where a match is found.
            //If a match is not found the value -1 will be returned.   
             
            int iCount = 0; //first row is 0
            int surnameColNo = 0;
            int firstNameColNo = 0;
            DataRow dRow;
            Boolean found = false;
            do
            {
                if (whichTable == "Parent")
                {
                    surnameColNo = 2;
                    firstNameColNo = 1;
                }
                else 
                {
                    surnameColNo = 3;
                    firstNameColNo = 2;
                }
                
                dRow = drDataTable.Rows[iCount];

                if ((dRow.ItemArray.GetValue(firstNameColNo).ToString().Trim() == searchClause2) &&
                            (dRow.ItemArray.GetValue(surnameColNo).ToString().Trim() == searchClause1))
                    {
                    found = true;
                }
                else
                {
                    ++iCount; //increment count
                }
            }
            while (!found && iCount != drDataTable.Rows.Count);  //last row index will be one less thanthe number of rows in data table
            if (!found)
            {
                iCount = -1;
            }
            return iCount;
        }

        //The three methods below are called in the navigation buttons (First, Next, Previous, Last. - on the form). The 'inc' variable increments or decrements depending on the button pressed  
        private void NavigateLessonRecords()
        {
            dRow = LessonBookingEntity.Rows[inc];
            DataRow durationDRow = LessonDurationEntity.Rows[inc];
            txtlStudentID.Text = dRow.ItemArray.GetValue(0).ToString().Trim();
            txtDate.Text = dRow.ItemArray.GetValue(1).ToString().Substring(0, 10);
            txtTime.Text = dRow.ItemArray.GetValue(2).ToString().Substring(11, 8);
            txtSubject.Text = dRow.ItemArray.GetValue(3).ToString().Trim();
            txtKeyStage.Text = dRow.ItemArray.GetValue(4).ToString().Trim();
            txtDurationOfLesson.Text = durationDRow.ItemArray.GetValue(0).ToString().Trim();
        }
        private void NavigateParentRecords()
        {
            dRow = ParentEntity.Rows[inc];
            txtpFamilyId.Text = dRow.ItemArray.GetValue(0).ToString().Trim();
            txtpSurname.Text = dRow.ItemArray.GetValue(1).ToString().Trim();
            txtpFirstName.Text = dRow.ItemArray.GetValue(2).ToString().Trim();
            txtpEmail.Text = dRow.ItemArray.GetValue(3).ToString().Trim();
            txtpPhoneNumber.Text = dRow.ItemArray.GetValue(4).ToString().Trim();
            txtAddress.Text = dRow.ItemArray.GetValue(5).ToString().Trim();
        }
        private void NavigateStudentRecords()
        {
            dRow = StudentEntity.Rows[inc];
            txtsStudentID.Text = dRow.ItemArray.GetValue(0).ToString().Trim();
            txtFamilyID.Text = dRow.ItemArray.GetValue(1).ToString().Trim();
            txtsSurname.Text = dRow.ItemArray.GetValue(2).ToString().Trim();
            txtsFirstName.Text = dRow.ItemArray.GetValue(3).ToString().Trim();
            txtAdditionalInfo.Text = dRow.ItemArray.GetValue(4).ToString().Trim();
            txtYearGroup.Text = dRow.ItemArray.GetValue(5).ToString().Trim();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //*************************************************************************************
        public void ExecuteSql(String sSqlString)
        {
            // Create a new connection to the database
            using (OleDbConnection connection = new OleDbConnection(CONNECTION_STRING))
            {
                // The sSqlString string contains a SQL statement to run on the database
                using (OleDbCommand command = new OleDbCommand(sSqlString))
                {
                    // Set the Connection to the new OleDbConnection.
                    command.Connection = connection;
                    // Open the connection and execute the command.
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } // The command is automatically closed when the code exits the using block.
            } // The connection is automatically closed when the code exits the using block.
        }

        private void RunNonSelectSQL(string _sqlString, string _ConnectionString)
        {
            OleDbConnection connection = new OleDbConnection(_ConnectionString);
            OleDbCommand command = new OleDbCommand(_sqlString);
            {
                command.Connection = connection;
                try
                {

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private DataTable RunQuery(string qryString)
        {
            DataTable dtQueryResult;

            objConnect = new DatabaseConnection(); //Create a new database connection object

            //Assign properties
            objConnect.connection_string = CONNECTION_STRING;
            objConnect.Sql = qryString;

            //Run query method and return results ina data table
            return dtQueryResult = objConnect.GetConnection;
        }

        private void CreateLessonDurationTable()
        {
            string _sSqlString;

            _sSqlString = "CREATE TABLE LessonDuration("
            + " DurationOfLesson Char(15),"
            + " ChargeCode Char(8),"  
            + " Price Currency,"
            + " PRIMARY KEY(ChargeCode)"
            + ");";

            ExecuteSql(_sSqlString);
        }


        private void CreateAttendanceTable()
        {
            string _sSqlstring;

            _sSqlstring = "CREATE TABLE Attendance("
            + " StudentIdNo int,"
            + " LessonDate date,"
            + " Attended Bit,"
            + " Paid Bit,"
            + " DatePaid Date,"
            + " CONSTRAINT AttendancePK PRIMARY KEY(StudentIdNo, LessonDate)"
            + ");";

            ExecuteSql(_sSqlstring);
        }

        private void CreateLessonBookingTable()
        {
            string _sSqlString;

            _sSqlString = "CREATE TABLE LessonBooking("
            + " StudentID int,"
            + " DateOfLesson Date,"
            + " TimeOfLesson Time,"
            + " Subject Char(30),"
            + " KeyStage Char(15),"
            + " ChargeCode Char(4),"
            + " CONSTRAINT LessonPK PRIMARY KEY(StudentID, DateOfLesson, TimeOfLesson)"
            + ");";

            ExecuteSql(_sSqlString);
        }
        private void CreateParentTable()
        {
            string _sSqlString;

            _sSqlString = "CREATE TABLE Parent("
            + " FamilyIdNo SHORT NOT NULL,"
            + " Surname Char(30),"
            + " FirstName Char(15),"
            + " Email Char(35),"
            + " PhoneNumber Char(15),"
            + " Address Char(60),"
            + " PRIMARY KEY(FamilyIdNo)"
            + ");";

            ExecuteSql(_sSqlString);
        }
        private void CreateStudentTable()
        {
            string _sSqlString;
            _sSqlString = "CREATE TABLE Student("
            + " StudentID Int,"
            + " FamilyIdNo SHORT NOT NULL,"
            + " Surname Char(30),"
            + " FirstName Char(15),"
            + " AdditionalInfo Char(255),"
            + " YearGroup Int,"
            + " PRIMARY KEY(StudentID)"
            + ");";

            ExecuteSql(_sSqlString);
        }

        //**************************************************************************************



        private void CreateDatabase()
        {
            // Create a catalog object
            CatalogClass cat = new CatalogClass();
            if (!File.Exists(TutorDB))
            {
                // Create the database
                cat.Create(CONNECTION_STRING);
                MessageBox.Show(" Database Created Successfully", " Database Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // create database tables
                // Code to create tables can be called here
                CreateStudentTable();
                CreateParentTable();
                CreateLessonBookingTable();
                CreateLessonDurationTable();
                CreateAttendanceTable();
            }
            else
            {
                MessageBox.Show(" The database already exists", " Database Creation", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            //cleanup
            cat = null;
        }


        private void frmCreateDatabase_Load(object sender, EventArgs e)
        {

            CreateDatabase();
            pnlLessonEntry.Visible = false;
            pnlParentEntry.Visible = false;
            pnlStudentEntry.Visible = true;
            btnStudentEntry.BackColor = Color.LightSteelBlue;

            NewLessonBookingConnection();
            NewLessonDurationConnection();
            NavigateLessonRecords();

            NewStudentConnection();
            NavigateStudentRecords();
        }

        private void btnSubmitStudentDetails_Click(object sender, EventArgs e)
        {
            string sFamilyId = txtFamilyID.Text;
            string sSurname = txtsSurname.Text;
            string sFirstName = txtsFirstName.Text;
            string sAdditionalInfo = txtAdditionalInfo.Text;
            string YearGroup = txtYearGroup.Text;
            string sStudentID = txtsStudentID.Text;
            // insert a row to the student's table
            string _sSqlString = "INSERT INTO Student(StudentID, FamilyIdNo, Surname, FirstName, AdditionalInfo, YearGroup) " +
                " Values('" + sStudentID + "','" + sFamilyId + "', '" + sSurname + "', '" + sFirstName + "', '" + sAdditionalInfo + "', '" + YearGroup + "');";
            // run the command
            ExecuteSql(_sSqlString);
        }

        private void btnSubmitParentDetails_Click(object sender, EventArgs e)
        {
            string pFamilyId = txtpFamilyId.Text;
            string pSurname = txtpSurname.Text;
            string pFirstName = txtpFirstName.Text;
            string pEmail = txtpEmail.Text;
            string pPhoneNumber = txtpPhoneNumber.Text;
            string pAddress = txtAddress.Text;
            // insert a row to the parent's table
            string _sSqlString = "INSERT INTO Parent(FamilyIdNo, Surname, FirstName, Email, PhoneNumber, Address) " +
                " Values('" + pFamilyId + "', '" + pSurname + "', '" + pFirstName + "', '" + pEmail + "', '" + pPhoneNumber + "', '" + pAddress + "');";

            // run the command
            ExecuteSql(_sSqlString);

        }
        private void btnSubmitLessonDetails_Click(object sender, EventArgs e)
        {
            string lStudentID = txtlStudentID.Text;
            string Date = txtDate.Text;
            string Time = txtTime.Text;
            string Subject = txtSubject.Text;
            string KeyStage = txtKeyStage.Text;
            string DurationOfLesson = txtDurationOfLesson.Text;
            // insert a row to the parent's table
            string _sSqlString1 = "INSERT INTO LessonBooking(StudentID, DateOfLesson, TimeOfLesson, Subject, KeyStage) " +
                " Values('" + lStudentID + "', '" + Date + "', '" + Time + "', '" + Subject + "', '" + KeyStage + "');";
            string _sSqlString2 = "INSERT INTO LessonDuration(DurationOfLesson, StudentID) " +
                " Values('" + DurationOfLesson + "', '" + lStudentID + "');";
            // run the command
            ExecuteSql(_sSqlString1);
            ExecuteSql(_sSqlString2);
        }


        private void btnStudentEntry_Click(object sender, EventArgs e)
        {
            pnlLessonEntry.Visible = false;
            pnlParentEntry.Visible = false;
            pnlStudentEntry.Visible = true;

            inc = 0;
            NewStudentConnection();

            btnStudentEntry.BackColor = Color.LightSteelBlue;
            btnParentEntry.BackColor = Color.LightGray;
            btnLessonEntry.BackColor = Color.LightGray;
        }

        private void btnParentEntry_Click(object sender, EventArgs e)
        {
            pnlLessonEntry.Visible = false;
            pnlParentEntry.Visible = true;
            pnlStudentEntry.Visible = false;

            NewParentConnection();

            btnParentEntry.BackColor = Color.LightSteelBlue;
            btnLessonEntry.BackColor = Color.LightGray;
            btnStudentEntry.BackColor = Color.LightGray;
        }

        private void btnLessonEntry_Click(object sender, EventArgs e)
        {
            pnlLessonEntry.Visible = true;
            pnlParentEntry.Visible = false;
            pnlStudentEntry.Visible = false;

            NewLessonBookingConnection();
            NewLessonDurationConnection();

            btnLessonEntry.BackColor = Color.LightSteelBlue;
            btnStudentEntry.BackColor = Color.LightGray;
            btnParentEntry.BackColor = Color.LightGray;
        }

        //'DatabaseEntryTextBox_Click' event is to highlight the intial text in all of the database editing text boxes
        private void DatabaseEntryTextBox_Click(object sender, EventArgs e)
        {
            txtsFirstName.SelectAll();
            txtKeyStage.SelectAll();
            txtAdditionalInfo.SelectAll();
            txtsSurname.SelectAll();
            txtFamilyID.SelectAll();
            txtAddress.SelectAll();
            txtpPhoneNumber.SelectAll();
            txtpEmail.SelectAll();
            txtpSurname.SelectAll();
            txtpFirstName.SelectAll();
            txtpFamilyId.SelectAll();
            txtlStudentID.SelectAll();
            txtKeyStage.SelectAll();
            txtDurationOfLesson.SelectAll();
            txtSubject.SelectAll();
            txtTime.SelectAll();
            txtDate.SelectAll();
            txtYearGroup.SelectAll();
            txtsStudentID.SelectAll();
        }

        private void btnPSearch_Click(object sender, EventArgs e)
        {
            //Get search terms
            string firstName = txtpFirstName.Text;
            String surname = txtpSurname.Text;

            inc = DataSearch(ParentEntity, firstName, surname, "Parent"); //call to datasearch function to find student
            if ((inc < MaxRows) && (inc > -1))
            {
                NavigateParentRecords();
                MessageBox.Show(firstName + " " + surname + "'s information is succesfully displayed!", "Data found succesfully");
            }
            else
            {
                MessageBox.Show(firstName + " " + surname + " not found \n\n- make sure initials are capitalised!", "Data not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSSearch_Click(object sender, EventArgs e)
        {
            //Get search terms
            string firstName = txtsFirstName.Text;
            String surname = txtsSurname.Text;

            inc = DataSearch(StudentEntity, firstName, surname, "Student"); //call to datasearch function to find student
            if ((inc < MaxRows) && (inc > -1))
            {
                NavigateStudentRecords();
                MessageBox.Show(firstName + " " + surname + "'s information is succesfully displayed!", "Data found succesfully");
            }
            else
            {
                MessageBox.Show(firstName + " " + surname + " not found \n\n- make sure initials are capitalised!", "Data not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLSearch_Click(object sender, EventArgs e)
        {
            //Get search terms
            string date = txtDate.Text;
            String time = txtTime.Text;

             //call to datasearch function to find student
            if ((inc < MaxRows) && (inc > -1))
            {
                NavigateLessonRecords();
                MessageBox.Show("The lesson at this time: " + date + " " + time + " has been succesfully displayed!", "Data found succesfully");
            }
            else
            {
                MessageBox.Show("A lesson at this time: " + date + " " + time + " has not been found", "Data not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // These event methods define the navigation buttons for all of the entities such as "First, Last, Next, Previous". 
        //Parent navigation buttons
        private void btnPFirst_Click(object sender, EventArgs e)
        {
            inc = 0;
            NavigateParentRecords();
        }private void btnPNext_Click(object sender, EventArgs e)
        {
            inc++;
            if (inc == MaxRows)
                inc = MaxRows - 1;

            NavigateParentRecords();
        }private void btnPPrevious_Click(object sender, EventArgs e)
        {
            if (inc == 0)
                inc = 0;
            else
                inc--;

            NavigateParentRecords();
        }private void btnPLast_Click(object sender, EventArgs e)
        {
            inc = MaxRows - 1;
            NavigateParentRecords();
        }


        //Student navigation buttons

        private void btnSFirst_Click(object sender, EventArgs e)
        {
            inc = 0;
            NavigateStudentRecords();
        }private void btnSLast_Click(object sender, EventArgs e)
        {
            inc = MaxRows - 1;
            NavigateStudentRecords();
        }private void btnSPrevious_Click(object sender, EventArgs e)
        {
            if (inc == 0)
                inc = 0;
            else
                inc--;

            NavigateStudentRecords();
        }private void btnSNext_Click(object sender, EventArgs e)
        {
            inc++;
            if (inc == MaxRows)
                inc = MaxRows - 1;

            NavigateStudentRecords();
        }


        //Lesson navigation buttons

        private void btnLFirst_Click(object sender, EventArgs e)
        {
            inc = 0;
            NavigateLessonRecords();
        }private void btnLLast_Click(object sender, EventArgs e)
        {
            inc = MaxRows - 1;
            NavigateLessonRecords();
        }private void btnLPrevious_Click(object sender, EventArgs e)
        {
            if (inc == 0)
                inc = 0;
            else
                inc--;

            NavigateLessonRecords();
        }private void btnLNext_Click(object sender, EventArgs e)
        {
            inc++;
            if (inc == MaxRows)
                inc = MaxRows - 1;

            NavigateLessonRecords();
        }

        //*******************************************************************************************************************

        //The three event methods below are for deleting a field from the database
        private void btnDltParent_Click(object sender, EventArgs e)
        {
            //get first name and surname of parent to delete
            string firstName = txtpFirstName.Text.ToString().Trim();
            string surName = txtpSurname.Text.ToString().Trim();

            //Set up a message for the user
            string message = "Do you really want to delete " + firstName + " " + surName + "?";
            string title = "Delete Parent";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            // The sSqlString string contains a SQL statement to run on the database
            string sSqlString = "DELETE FROM Parent WHERE Surname = '" + surName + "' AND "
                    + "FirstName = '" + firstName + "'";

            if (result == DialogResult.Yes)
            {
                ExecuteSql(sSqlString);
                NewParentConnection();
                NavigateParentRecords();
            }
        }

		private void btnDltlesson_Click(object sender, EventArgs e)
		{
            //get student ID, Date, time of Lesson to delete
            string StudentId = txtlStudentID.Text.ToString().Trim();
            string date = txtDate.Text.ToString().Trim();
            string time = txtTime.Text.ToString().Trim();

            //Set up a message for the user
            string message = "Do you really want to delete the lesson on the date of " + date + " and the time of " + time + "?";
            string title = "Delete Lesson";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            // The sSqlString string contains a SQL statement to run on the database
            string sSqlString1 = "DELETE FROM LessonBooking WHERE StudentID = '" + StudentId + "'";
            string sSqlString2 = "DELETE FROM LessonDuration WHERE StudentID = '" + StudentId + "'";

            if (result == DialogResult.Yes)
            {
                ExecuteSql(sSqlString1);
                ExecuteSql(sSqlString2);
                NewLessonBookingConnection();
                NewLessonDurationConnection();
                NavigateLessonRecords();
            }
        }

		private void btnDltStudent_Click(object sender, EventArgs e)
		{
            //get first name and surname of student to delete
            string StudentId = txtsStudentID.Text.ToString().Trim();
            string firstName = txtsFirstName.Text.ToString().Trim();
            string surName = txtsSurname.Text.ToString().Trim();

            //Set up a message for the user
            string message = "Do you really want " + firstName + " " + surName + " from the student entity?";
            string title = "Delete Student";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            // The sSqlString string contains a SQL statement to run on the database
            string sSqlString = "DELETE FROM Student WHERE StudentID = " + StudentId + "";

            if (result == DialogResult.Yes)
            {
                ExecuteSql(sSqlString);
                NewStudentConnection();
                NavigateStudentRecords();
            }
        }

        //*****************************************************************************
        //The 6 methods below are to aid the user on how to use the "lookup" button for each panel e.g. parent, student or lesson  
        private void btnPSearch_MouseHover(object sender, EventArgs e)
		{
            txtpSurname.ForeColor = Color.Blue;
            txtpFirstName.ForeColor = Color.Blue;
        }private void btnPSearch_MouseLeave(object sender, EventArgs e)
		{
            txtpSurname.ForeColor = Color.Black;
            txtpFirstName.ForeColor = Color.Black;
        }

        private void btnSSearch_MouseHover(object sender, EventArgs e)
        {
            txtsSurname.ForeColor = Color.Blue;
            txtsFirstName.ForeColor = Color.Blue;
        }private void btnSSearch_MouseLeave(object sender, EventArgs e)
        {
            txtsSurname.ForeColor = Color.Black;
            txtsFirstName.ForeColor = Color.Black;
        }

		private void btnLSearch_MouseHover(object sender, EventArgs e)
		{
            txtTime.ForeColor = Color.Blue;
            txtDate.ForeColor = Color.Blue;
        }private void btnLSearch_MouseLeave(object sender, EventArgs e)
		{
            txtTime.ForeColor = Color.Black;
            txtDate.ForeColor = Color.Black;
        }

        private DateTime GbDateToUsDate(string sGBDate, int iDayOfMonth)
        {
            //Declare variables
            string tempDate = "";
            string format = "d";
            DateTime newDate;
            CultureInfo provider = CultureInfo.InvariantCulture;

            if (iDayOfMonth > 12)
            {
                tempDate = sGBDate.Substring(3, 2) + "/";
                tempDate = tempDate + sGBDate.Substring(0, 2) + sGBDate.Substring(5, 5);

                newDate = DateTime.ParseExact(tempDate, format, provider);
            }
            else
            {
                newDate = DateTime.ParseExact(sGBDate, format, provider);
            }

            return newDate;
        }

        private void btnFindStudentLesson_Click(object sender, EventArgs e)
        {
            //Assigning fullname textbox to local variables to be used in query
            string surname = txtStudentSurname.Text;
            string qryFind = "";

            DateTime lessonDate = dtpStudentLesson.Value;
            int iDay = lessonDate.Day;
            string slessonDate = lessonDate.ToString().Substring(0, 10);
            lessonDate = GbDateToUsDate(slessonDate, iDay);

            DataTable dtQueryResult;
            DataRow drRow;

            //Build query string

            if (surname == "Type the student's surname")
            {
                surname = "";
            }

            if (surname != "")
            {
                qryFind = "SELECT Student.StudentID, Student.FirstName, Student.Surname, LessonBooking.Subject, LessonBooking.DateOfLesson, LessonBooking.TimeofLesson, LessonBooking.Keystage, LessonDuration.DurationOfLesson FROM Student, LessonBooking, LessonDuration WHERE "
                     + "((Student.Surname = '" + surname + "') AND (LessonBooking.DateOfLesson = #" + lessonDate + "#)"
                     + " AND (Student.StudentID = LessonBooking.StudentID)"
                     + " AND (LessonBooking.ChargeCode = LessonDuration.ChargeCode));";
            }
            else
            {
                qryFind = "SELECT Student.StudentID, Student.FirstName, Student.Surname, LessonBooking.Subject, "
                    + "LessonBooking.DateOfLesson, LessonBooking.TimeofLesson, LessonBooking.Keystage, "
                    + "LessonDuration.DurationOfLesson "
                    + "FROM Student, LessonBooking, LessonDuration "
                    + "WHERE ((LessonBooking.DateOfLesson = #" + lessonDate + "#)"
                    + " AND (Student.StudentID = LessonBooking.StudentID)"
                    + " AND (LessonBooking.ChargeCode = LessonDuration.ChargeCode));";
            }

            dtQueryResult = RunQuery(qryFind);

            int noOfColumns = dtQueryResult.Columns.Count;
            dgvStudentLesson.Columns.Clear();
            dgvStudentLesson.Columns.Add("Columns", "StudentId");
            dgvStudentLesson.Columns.Add("Columns", "First Name");
            dgvStudentLesson.Columns.Add("Columns", "Surname");
            dgvStudentLesson.Columns.Add("Columns", "Subject");
            dgvStudentLesson.Columns.Add("Columns", "Date of lesson");
            dgvStudentLesson.Columns.Add("Columns", "Time of lesson");
            dgvStudentLesson.Columns.Add("Columns", "Keystage");
            dgvStudentLesson.Columns.Add("Columns", "DurationOfLesson");


            if (dtQueryResult.Rows.Count > 0)
            {
                drRow = dtQueryResult.Rows[0];
                for (int i = 0; i < dtQueryResult.Rows.Count; i++)
                {
                    // dRow = dsStudent.Tables[0].Rows[i];
                    drRow = dtQueryResult.Rows[i];
                    dgvStudentLesson.Rows.Add();
                    dgvStudentLesson.Rows[i].Cells[0].Value = drRow.ItemArray.GetValue(0);
                    dgvStudentLesson.Rows[i].Cells[1].Value = drRow.ItemArray.GetValue(1);
                    dgvStudentLesson.Rows[i].Cells[2].Value = drRow.ItemArray.GetValue(2);
                    dgvStudentLesson.Rows[i].Cells[3].Value = drRow.ItemArray.GetValue(3);
                    dgvStudentLesson.Rows[i].Cells[4].Value = drRow.ItemArray.GetValue(4);
                    dgvStudentLesson.Rows[i].Cells[5].Value = drRow.ItemArray.GetValue(5);
                    dgvStudentLesson.Rows[i].Cells[6].Value = drRow.ItemArray.GetValue(6);
                    dgvStudentLesson.Rows[i].Cells[7].Value = drRow.ItemArray.GetValue(7);
                }
            }
            else
            {
                MessageBox.Show("No records match your criteria. Please try again.");
            }

        }        //*********************************************************************************************************************

		private void btnClear_Click(object sender, EventArgs e)
		{
            dgvStudentLesson.DataSource = null;
            this.dgvStudentLesson.Rows.Clear();
        }

		private void btnMenuFromDataEntry_Click(object sender, EventArgs e)
		{
            this.Hide();
            FrmMenu Menu = new FrmMenu();
            Menu.ShowDialog();
		}
	}
}
