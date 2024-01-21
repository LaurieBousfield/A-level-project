using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DatabaseCreation
{
    public partial class FrmBooking : Form
    {
        private const int noOfTimes = 3;
        private const string TutorDB = "TutorDatabase.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + TutorDB + ";";

        DatabaseConnection objConnect;
        DataTable dtStudent;
        DataRow dRow;

        private string[] daysOfWeek = new string[7] 
                {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        private string[] lessonTimes = new string[noOfTimes]
            {"16:00","17:15","18:30"};
        //private string[,] students = new string[5,3];
        private string[,] students = new string[3, 5];

        private int labelStartPositionH = 100;
        private int labelStartPositionV = 90;
        private TextBox[] TimeLabels = new TextBox[noOfTimes];

        /*DateTime lessonDate = dtpStudentLesson.Value;
        int iDay = lessonDate.Day;
        string slessonDate = lessonDate.ToString().Substring(0, 10);
        lessonDate = GbDateToUsDate(slessonDate, iDay);

        DataTable dtQueryResult;
        DataRow drRow;*/

        //******************************************************************************
        private DataTable RunQuery(string qryString)
        {
            DataTable dtQueryResult;

            objConnect = new DatabaseConnection();
            objConnect.connection_string = CONNECTION_STRING;

            objConnect.Sql = qryString;
            dtQueryResult = objConnect.GetConnection;

            return dtQueryResult;

        }


        //******************************************************************************


        public FrmBooking()
        {
            InitializeComponent();
        }
        
        private void frmBooking_Load(object sender, EventArgs e)

        {   
            dgvBookings.ColumnCount = 7;
            for (int i = 0; i < 7; i++)
            {
                dgvBookings.Columns[i].HeaderText = daysOfWeek[i];
            }
            dgvBookings.RowCount = 3;


            for (int i = 0; i < 2; i++)
            {
                //dgvBookings.Rows.Add();
                for (int j = 0; j < 6; j++)
                {
                    dgvBookings.Rows[i].Cells[j].Value = "  -  ";
                }
            }
        }

        private void frmBooking_Shown(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                TimeLabels[i] = new TextBox();
                TimeLabels[i].Location = new System.Drawing.Point(labelStartPositionH, labelStartPositionV);
                TimeLabels[i].Size = new System.Drawing.Size(70, 40);
                TimeLabels[i].Text = lessonTimes[i].ToString();
                TimeLabels[i].ReadOnly = true;
                //TimeLabels[i].Text = i.ToString();

                this.Controls.Add(TimeLabels[i]);
                labelStartPositionV += 118;
            }

                /*  for (int i = 0; i < 7; i++)
                  {
                      TextBox newTextBox = new TextBox();
                      newTextBox.Location = new System.Drawing.Point(txtBoxStartPosition, txtBoxStartPositionV);
                      newTextBox.Size = new System.Drawing.Size(70, 40);
                      newTextBox.Text = i.ToString();

                      this.Controls.Add(newTextBox);
                      txtBoxStartPositionV += 20;

                  }*/
            }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

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

        private void PopulateStudentArray(string student, DateTime lDate, string lTime)
        {
            int col = 0;
            int row = 0;

            /* while (col < 6)
             {
                     if (row == 3)
                     {
                         row = 0;
                         col++;
                     }*/
            col = (int) lDate.DayOfWeek;
            col--; //subtract one to place on grid
            if (lTime == "16:00")
            {
                row = 0;
            }
            else if (lTime == "17:15")
            {
                row = 1;
            }
            else if (lTime == "18:30")
            {
                row = 2;
            }
           
                students[row, col] = student; 
               // dgvBookings.Rows[row].Cells[col].Value = students[row, col];
            
        }

        private void OutputStudentArray()
        {
           int col = 5; //it would be better if these were private constants
           int row = 3;

            // while (col < 6)
            //********* use a nested loop to display values from array into grid ******
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    dgvBookings.Rows[r].Cells[c].Value = students[r, c];
                }
            }
            //*************************************************************************

               /* if (row == 3)
                {
                    row = 0;
                    col++;
                }

                dgvBookings.Rows[row].Cells[col].Value = students[row, col];
                row++;*/  
        }
     
        private void btnViewWeek_Click(object sender, EventArgs e)
        {
            //assigns date from the date time picker and assigns another date which represents the end of the week by adding a number of days to the first date assigned
            DateTime pStartDate = dtpBookings.Value;
            DateTime pEndDate = pStartDate.AddDays(4);
            int sDay = pStartDate.Day;
            int eDay = pEndDate.Day;
            string sDate = pStartDate.ToString().Substring(0, 10);
            string eDate = pEndDate.ToString().Substring(0, 10);
            DateTime dStartDate= GbDateToUsDate(sDate, sDay);
            DateTime dEndDate = GbDateToUsDate(eDate, eDay);
            string startDate = dStartDate.ToString().Substring(0, 10).Trim();
            string endDate = dEndDate.ToString().Substring(0, 10).Trim();
            
            dgvBookings.Rows.Clear();


            //Build Query String:
            string weekToShow = "SELECT Student.FirstName, Student.Surname, LessonBooking.Subject,"
                + " LessonDuration.DurationOfLesson, LessonBooking.DateOfLesson, LessonBooking.TimeOfLesson "
                + " FROM Student, LessonBooking, LessonDuration"
                + " WHERE (LessonBooking.DateOfLesson BETWEEN #" + startDate + "# AND "
                + "#" + endDate + "#) AND (Student.StudentID = LessonBooking.StudentID)"
                + " AND (LessonBooking.ChargeCode = LessonDuration.ChargeCode) ORDER BY LessonBooking.DateOfLesson, LessonBooking.TimeOfLesson;";

            DataTable Bookings = RunQuery(weekToShow);

            if (Bookings.Rows.Count > 0 )
            {
                DataRow bookingRow = Bookings.Rows[0];
                //MessageBox.Show(bookingRow.ItemArray.GetValue(0).ToString());

            }

            DataRow drRow;
            dgvBookings.Rows.Add(3);

            if (Bookings.Rows.Count > 0)
            {
                drRow = Bookings.Rows[0];
                for (int i = 0; i < Bookings.Rows.Count; i++)
                {
                    drRow = Bookings.Rows[i];
                    string firstName = drRow.ItemArray.GetValue(0).ToString().Trim();
                    string lastName = drRow.ItemArray.GetValue(1).ToString().Trim();
                    string subject = drRow.ItemArray.GetValue(2).ToString().Trim();
                    string Duration = drRow.ItemArray.GetValue(3).ToString().Trim();

                    string student = firstName + " " + lastName + "\n" + subject + "\n" + Duration;

                    DateTime lessonDate = (DateTime)drRow.ItemArray.GetValue(4);
                    string lessonTime = drRow.ItemArray.GetValue(5).ToString().Substring(11, 5);
                    PopulateStudentArray(student, lessonDate,lessonTime);
                }
                OutputStudentArray(); 
            }
            else
            {
                MessageBox.Show("No records match your criteria. Please try again.");
            }
        }

		private void btnMenuReturnFromBooking_Click(object sender, EventArgs e)
		{
          this.Hide();
            FrmMenu Menu = new FrmMenu();
            Menu.ShowDialog();
        }
	}
}
