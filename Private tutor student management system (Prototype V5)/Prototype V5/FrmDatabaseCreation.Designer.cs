namespace DatabaseCreation
{
    partial class FrmDatabaseCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.grpStudentDetails = new System.Windows.Forms.GroupBox();
			this.txtsStudentID = new System.Windows.Forms.TextBox();
			this.lblsStudentID = new System.Windows.Forms.Label();
			this.txtYearGroup = new System.Windows.Forms.TextBox();
			this.lblYearGroup = new System.Windows.Forms.Label();
			this.txtAdditionalInfo = new System.Windows.Forms.TextBox();
			this.lblAdditionalInfo = new System.Windows.Forms.Label();
			this.lblSurname = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblFamilyID = new System.Windows.Forms.Label();
			this.txtsSurname = new System.Windows.Forms.TextBox();
			this.txtsFirstName = new System.Windows.Forms.TextBox();
			this.txtFamilyID = new System.Windows.Forms.TextBox();
			this.grpParentDetails = new System.Windows.Forms.GroupBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtpPhoneNumber = new System.Windows.Forms.TextBox();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.txtpEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblpSurname = new System.Windows.Forms.Label();
			this.lblpFirstName = new System.Windows.Forms.Label();
			this.lblpFamilyId = new System.Windows.Forms.Label();
			this.txtpSurname = new System.Windows.Forms.TextBox();
			this.txtpFirstName = new System.Windows.Forms.TextBox();
			this.txtpFamilyId = new System.Windows.Forms.TextBox();
			this.btnSubmitParentDetails = new System.Windows.Forms.Button();
			this.grpLessonDetails = new System.Windows.Forms.GroupBox();
			this.txtlStudentID = new System.Windows.Forms.TextBox();
			this.lbllStudentID = new System.Windows.Forms.Label();
			this.txtKeyStage = new System.Windows.Forms.TextBox();
			this.lblKeyStage = new System.Windows.Forms.Label();
			this.txtDurationOfLesson = new System.Windows.Forms.TextBox();
			this.lblDurationOfSession = new System.Windows.Forms.Label();
			this.lblSubject = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnStudentEntry = new System.Windows.Forms.Button();
			this.btnParentEntry = new System.Windows.Forms.Button();
			this.btnLessonEntry = new System.Windows.Forms.Button();
			this.pnlStudentEntry = new System.Windows.Forms.Panel();
			this.btnSNext = new System.Windows.Forms.Button();
			this.btnSPrevious = new System.Windows.Forms.Button();
			this.btnSLast = new System.Windows.Forms.Button();
			this.btnSFirst = new System.Windows.Forms.Button();
			this.btnDltStudent = new System.Windows.Forms.Button();
			this.btnSSearch = new System.Windows.Forms.Button();
			this.btnSubmitStudentDetails = new System.Windows.Forms.Button();
			this.pnlParentEntry = new System.Windows.Forms.Panel();
			this.btnPNext = new System.Windows.Forms.Button();
			this.btnPPrevious = new System.Windows.Forms.Button();
			this.btnPLast = new System.Windows.Forms.Button();
			this.btnPFirst = new System.Windows.Forms.Button();
			this.btnDltParent = new System.Windows.Forms.Button();
			this.btnPSearch = new System.Windows.Forms.Button();
			this.pnlLessonEntry = new System.Windows.Forms.Panel();
			this.grpFindStudentLesson = new System.Windows.Forms.GroupBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.dgvStudentLesson = new System.Windows.Forms.DataGridView();
			this.btnFindStudentLesson = new System.Windows.Forms.Button();
			this.lblLessonDatePicker = new System.Windows.Forms.Label();
			this.dtpStudentLesson = new System.Windows.Forms.DateTimePicker();
			this.txtStudentSurname = new System.Windows.Forms.TextBox();
			this.lblStudentSurname = new System.Windows.Forms.Label();
			this.btnLNext = new System.Windows.Forms.Button();
			this.btnLPrevious = new System.Windows.Forms.Button();
			this.btnLLast = new System.Windows.Forms.Button();
			this.btnLFirst = new System.Windows.Forms.Button();
			this.btnDltlesson = new System.Windows.Forms.Button();
			this.btnLSearch = new System.Windows.Forms.Button();
			this.btnSubmitLessonDetails = new System.Windows.Forms.Button();
			this.toolTipPLookup = new System.Windows.Forms.ToolTip(this.components);
			this.toolTipSLookup = new System.Windows.Forms.ToolTip(this.components);
			this.toolTipLLookup = new System.Windows.Forms.ToolTip(this.components);
			this.btnMenuFromDataEntry = new System.Windows.Forms.Button();
			this.grpStudentDetails.SuspendLayout();
			this.grpParentDetails.SuspendLayout();
			this.grpLessonDetails.SuspendLayout();
			this.pnlStudentEntry.SuspendLayout();
			this.pnlParentEntry.SuspendLayout();
			this.pnlLessonEntry.SuspendLayout();
			this.grpFindStudentLesson.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudentLesson)).BeginInit();
			this.SuspendLayout();
			// 
			// grpStudentDetails
			// 
			this.grpStudentDetails.Controls.Add(this.txtsStudentID);
			this.grpStudentDetails.Controls.Add(this.lblsStudentID);
			this.grpStudentDetails.Controls.Add(this.txtYearGroup);
			this.grpStudentDetails.Controls.Add(this.lblYearGroup);
			this.grpStudentDetails.Controls.Add(this.txtAdditionalInfo);
			this.grpStudentDetails.Controls.Add(this.lblAdditionalInfo);
			this.grpStudentDetails.Controls.Add(this.lblSurname);
			this.grpStudentDetails.Controls.Add(this.lblFirstName);
			this.grpStudentDetails.Controls.Add(this.lblFamilyID);
			this.grpStudentDetails.Controls.Add(this.txtsSurname);
			this.grpStudentDetails.Controls.Add(this.txtsFirstName);
			this.grpStudentDetails.Controls.Add(this.txtFamilyID);
			this.grpStudentDetails.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpStudentDetails.Location = new System.Drawing.Point(10, 9);
			this.grpStudentDetails.Name = "grpStudentDetails";
			this.grpStudentDetails.Size = new System.Drawing.Size(424, 263);
			this.grpStudentDetails.TabIndex = 1;
			this.grpStudentDetails.TabStop = false;
			this.grpStudentDetails.Text = "Student details input/output";
			// 
			// txtsStudentID
			// 
			this.txtsStudentID.Location = new System.Drawing.Point(140, 41);
			this.txtsStudentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtsStudentID.Name = "txtsStudentID";
			this.txtsStudentID.Size = new System.Drawing.Size(256, 21);
			this.txtsStudentID.TabIndex = 13;
			this.txtsStudentID.Text = "Type the student\'s ID (whole number)";
			this.txtsStudentID.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// lblsStudentID
			// 
			this.lblsStudentID.AutoSize = true;
			this.lblsStudentID.Location = new System.Drawing.Point(22, 45);
			this.lblsStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblsStudentID.Name = "lblsStudentID";
			this.lblsStudentID.Size = new System.Drawing.Size(64, 15);
			this.lblsStudentID.TabIndex = 12;
			this.lblsStudentID.Text = "StudentID:";
			// 
			// txtYearGroup
			// 
			this.txtYearGroup.Location = new System.Drawing.Point(140, 234);
			this.txtYearGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtYearGroup.Name = "txtYearGroup";
			this.txtYearGroup.Size = new System.Drawing.Size(256, 21);
			this.txtYearGroup.TabIndex = 9;
			this.txtYearGroup.Text = "Type student\'s Date of Birth";
			this.txtYearGroup.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// lblYearGroup
			// 
			this.lblYearGroup.AutoSize = true;
			this.lblYearGroup.Location = new System.Drawing.Point(22, 238);
			this.lblYearGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblYearGroup.Name = "lblYearGroup";
			this.lblYearGroup.Size = new System.Drawing.Size(69, 15);
			this.lblYearGroup.TabIndex = 8;
			this.lblYearGroup.Text = "Year group:";
			// 
			// txtAdditionalInfo
			// 
			this.txtAdditionalInfo.Location = new System.Drawing.Point(140, 198);
			this.txtAdditionalInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtAdditionalInfo.Name = "txtAdditionalInfo";
			this.txtAdditionalInfo.Size = new System.Drawing.Size(256, 21);
			this.txtAdditionalInfo.TabIndex = 7;
			this.txtAdditionalInfo.Text = "Type any info you want your tutor to be aware of";
			this.txtAdditionalInfo.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// lblAdditionalInfo
			// 
			this.lblAdditionalInfo.AutoSize = true;
			this.lblAdditionalInfo.Location = new System.Drawing.Point(22, 202);
			this.lblAdditionalInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAdditionalInfo.Name = "lblAdditionalInfo";
			this.lblAdditionalInfo.Size = new System.Drawing.Size(87, 15);
			this.lblAdditionalInfo.TabIndex = 6;
			this.lblAdditionalInfo.Text = "Additional info:";
			// 
			// lblSurname
			// 
			this.lblSurname.AutoSize = true;
			this.lblSurname.Location = new System.Drawing.Point(22, 162);
			this.lblSurname.Name = "lblSurname";
			this.lblSurname.Size = new System.Drawing.Size(61, 15);
			this.lblSurname.TabIndex = 5;
			this.lblSurname.Text = "Surname:";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(22, 122);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(69, 15);
			this.lblFirstName.TabIndex = 4;
			this.lblFirstName.Text = "First name:";
			// 
			// lblFamilyID
			// 
			this.lblFamilyID.AutoSize = true;
			this.lblFamilyID.Location = new System.Drawing.Point(22, 82);
			this.lblFamilyID.Name = "lblFamilyID";
			this.lblFamilyID.Size = new System.Drawing.Size(58, 15);
			this.lblFamilyID.TabIndex = 3;
			this.lblFamilyID.Text = "FamilyID:";
			// 
			// txtsSurname
			// 
			this.txtsSurname.Location = new System.Drawing.Point(140, 158);
			this.txtsSurname.Name = "txtsSurname";
			this.txtsSurname.Size = new System.Drawing.Size(256, 21);
			this.txtsSurname.TabIndex = 2;
			this.txtsSurname.Text = "Type a surname here";
			this.txtsSurname.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// txtsFirstName
			// 
			this.txtsFirstName.Location = new System.Drawing.Point(140, 118);
			this.txtsFirstName.Name = "txtsFirstName";
			this.txtsFirstName.Size = new System.Drawing.Size(256, 21);
			this.txtsFirstName.TabIndex = 1;
			this.txtsFirstName.Text = "Type a first name here";
			this.txtsFirstName.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// txtFamilyID
			// 
			this.txtFamilyID.Location = new System.Drawing.Point(140, 78);
			this.txtFamilyID.Name = "txtFamilyID";
			this.txtFamilyID.Size = new System.Drawing.Size(256, 21);
			this.txtFamilyID.TabIndex = 0;
			this.txtFamilyID.Text = "Type a Family ID here (whole number)";
			this.txtFamilyID.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// grpParentDetails
			// 
			this.grpParentDetails.Controls.Add(this.txtAddress);
			this.grpParentDetails.Controls.Add(this.lblAddress);
			this.grpParentDetails.Controls.Add(this.txtpPhoneNumber);
			this.grpParentDetails.Controls.Add(this.lblPhoneNumber);
			this.grpParentDetails.Controls.Add(this.txtpEmail);
			this.grpParentDetails.Controls.Add(this.lblEmail);
			this.grpParentDetails.Controls.Add(this.lblpSurname);
			this.grpParentDetails.Controls.Add(this.lblpFirstName);
			this.grpParentDetails.Controls.Add(this.lblpFamilyId);
			this.grpParentDetails.Controls.Add(this.txtpSurname);
			this.grpParentDetails.Controls.Add(this.txtpFirstName);
			this.grpParentDetails.Controls.Add(this.txtpFamilyId);
			this.grpParentDetails.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpParentDetails.Location = new System.Drawing.Point(10, 9);
			this.grpParentDetails.Name = "grpParentDetails";
			this.grpParentDetails.Size = new System.Drawing.Size(424, 278);
			this.grpParentDetails.TabIndex = 10;
			this.grpParentDetails.TabStop = false;
			this.grpParentDetails.Text = "Parent details input/output";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(138, 235);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(256, 21);
			this.txtAddress.TabIndex = 11;
			this.txtAddress.Text = "Type an address - e.g. 17, Basingstoke road";
			this.txtAddress.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(20, 239);
			this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(91, 15);
			this.lblAddress.TabIndex = 10;
			this.lblAddress.Text = "Street address:";
			// 
			// txtpPhoneNumber
			// 
			this.txtpPhoneNumber.Location = new System.Drawing.Point(138, 197);
			this.txtpPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtpPhoneNumber.Name = "txtpPhoneNumber";
			this.txtpPhoneNumber.Size = new System.Drawing.Size(256, 21);
			this.txtpPhoneNumber.TabIndex = 9;
			this.txtpPhoneNumber.Text = "Type the parent\'s phone number";
			this.txtpPhoneNumber.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.AutoSize = true;
			this.lblPhoneNumber.Location = new System.Drawing.Point(20, 201);
			this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.Size = new System.Drawing.Size(94, 15);
			this.lblPhoneNumber.TabIndex = 8;
			this.lblPhoneNumber.Text = "Phone Number:";
			// 
			// txtpEmail
			// 
			this.txtpEmail.Location = new System.Drawing.Point(138, 161);
			this.txtpEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtpEmail.Name = "txtpEmail";
			this.txtpEmail.Size = new System.Drawing.Size(256, 21);
			this.txtpEmail.TabIndex = 7;
			this.txtpEmail.Text = "Type the parent\'s email ";
			this.txtpEmail.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(20, 165);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(42, 15);
			this.lblEmail.TabIndex = 6;
			this.lblEmail.Text = "Email:";
			// 
			// lblpSurname
			// 
			this.lblpSurname.AutoSize = true;
			this.lblpSurname.Location = new System.Drawing.Point(20, 125);
			this.lblpSurname.Name = "lblpSurname";
			this.lblpSurname.Size = new System.Drawing.Size(61, 15);
			this.lblpSurname.TabIndex = 5;
			this.lblpSurname.Text = "Surname:";
			// 
			// lblpFirstName
			// 
			this.lblpFirstName.AutoSize = true;
			this.lblpFirstName.Location = new System.Drawing.Point(20, 85);
			this.lblpFirstName.Name = "lblpFirstName";
			this.lblpFirstName.Size = new System.Drawing.Size(69, 15);
			this.lblpFirstName.TabIndex = 4;
			this.lblpFirstName.Text = "First name:";
			// 
			// lblpFamilyId
			// 
			this.lblpFamilyId.AutoSize = true;
			this.lblpFamilyId.Location = new System.Drawing.Point(20, 45);
			this.lblpFamilyId.Name = "lblpFamilyId";
			this.lblpFamilyId.Size = new System.Drawing.Size(58, 15);
			this.lblpFamilyId.TabIndex = 3;
			this.lblpFamilyId.Text = "FamilyID:";
			// 
			// txtpSurname
			// 
			this.txtpSurname.BackColor = System.Drawing.SystemColors.Window;
			this.txtpSurname.Location = new System.Drawing.Point(138, 121);
			this.txtpSurname.Name = "txtpSurname";
			this.txtpSurname.Size = new System.Drawing.Size(256, 21);
			this.txtpSurname.TabIndex = 2;
			this.txtpSurname.Text = "Type a surname here";
			this.txtpSurname.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// txtpFirstName
			// 
			this.txtpFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtpFirstName.Location = new System.Drawing.Point(138, 81);
			this.txtpFirstName.Name = "txtpFirstName";
			this.txtpFirstName.Size = new System.Drawing.Size(256, 21);
			this.txtpFirstName.TabIndex = 1;
			this.txtpFirstName.Text = "Type a first name here";
			this.txtpFirstName.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// txtpFamilyId
			// 
			this.txtpFamilyId.Location = new System.Drawing.Point(138, 41);
			this.txtpFamilyId.Name = "txtpFamilyId";
			this.txtpFamilyId.Size = new System.Drawing.Size(256, 21);
			this.txtpFamilyId.TabIndex = 0;
			this.txtpFamilyId.Text = "Type a Family ID here (whole number)";
			this.txtpFamilyId.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// btnSubmitParentDetails
			// 
			this.btnSubmitParentDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitParentDetails.Location = new System.Drawing.Point(446, 22);
			this.btnSubmitParentDetails.Name = "btnSubmitParentDetails";
			this.btnSubmitParentDetails.Size = new System.Drawing.Size(148, 47);
			this.btnSubmitParentDetails.TabIndex = 11;
			this.btnSubmitParentDetails.Text = "Add parent to a new field";
			this.btnSubmitParentDetails.UseVisualStyleBackColor = true;
			this.btnSubmitParentDetails.Click += new System.EventHandler(this.btnSubmitParentDetails_Click);
			// 
			// grpLessonDetails
			// 
			this.grpLessonDetails.Controls.Add(this.txtlStudentID);
			this.grpLessonDetails.Controls.Add(this.lbllStudentID);
			this.grpLessonDetails.Controls.Add(this.txtKeyStage);
			this.grpLessonDetails.Controls.Add(this.lblKeyStage);
			this.grpLessonDetails.Controls.Add(this.txtDurationOfLesson);
			this.grpLessonDetails.Controls.Add(this.lblDurationOfSession);
			this.grpLessonDetails.Controls.Add(this.lblSubject);
			this.grpLessonDetails.Controls.Add(this.lblTime);
			this.grpLessonDetails.Controls.Add(this.lblDate);
			this.grpLessonDetails.Controls.Add(this.txtSubject);
			this.grpLessonDetails.Controls.Add(this.txtTime);
			this.grpLessonDetails.Controls.Add(this.txtDate);
			this.grpLessonDetails.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpLessonDetails.Location = new System.Drawing.Point(10, 22);
			this.grpLessonDetails.Name = "grpLessonDetails";
			this.grpLessonDetails.Size = new System.Drawing.Size(394, 249);
			this.grpLessonDetails.TabIndex = 11;
			this.grpLessonDetails.TabStop = false;
			this.grpLessonDetails.Text = "Lesson details input/output";
			// 
			// txtlStudentID
			// 
			this.txtlStudentID.Location = new System.Drawing.Point(132, 28);
			this.txtlStudentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtlStudentID.Name = "txtlStudentID";
			this.txtlStudentID.Size = new System.Drawing.Size(256, 21);
			this.txtlStudentID.TabIndex = 15;
			this.txtlStudentID.Text = "Type the student\'s ID (whole number)";
			this.txtlStudentID.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// lbllStudentID
			// 
			this.lbllStudentID.AutoSize = true;
			this.lbllStudentID.Location = new System.Drawing.Point(14, 32);
			this.lbllStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbllStudentID.Name = "lbllStudentID";
			this.lbllStudentID.Size = new System.Drawing.Size(64, 15);
			this.lbllStudentID.TabIndex = 14;
			this.lbllStudentID.Text = "StudentID:";
			// 
			// txtKeyStage
			// 
			this.txtKeyStage.Location = new System.Drawing.Point(132, 217);
			this.txtKeyStage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtKeyStage.Name = "txtKeyStage";
			this.txtKeyStage.Size = new System.Drawing.Size(256, 21);
			this.txtKeyStage.TabIndex = 12;
			this.txtKeyStage.Text = "Type the Key stage of the lesson\'s student";
			this.txtKeyStage.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// lblKeyStage
			// 
			this.lblKeyStage.AutoSize = true;
			this.lblKeyStage.Location = new System.Drawing.Point(14, 217);
			this.lblKeyStage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblKeyStage.Name = "lblKeyStage";
			this.lblKeyStage.Size = new System.Drawing.Size(64, 15);
			this.lblKeyStage.TabIndex = 10;
			this.lblKeyStage.Text = "Key stage:";
			// 
			// txtDurationOfLesson
			// 
			this.txtDurationOfLesson.Location = new System.Drawing.Point(132, 180);
			this.txtDurationOfLesson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtDurationOfLesson.Name = "txtDurationOfLesson";
			this.txtDurationOfLesson.Size = new System.Drawing.Size(256, 21);
			this.txtDurationOfLesson.TabIndex = 7;
			this.txtDurationOfLesson.Text = "Type the duration of this lesson";
			this.txtDurationOfLesson.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// lblDurationOfSession
			// 
			this.lblDurationOfSession.AutoSize = true;
			this.lblDurationOfSession.Location = new System.Drawing.Point(14, 184);
			this.lblDurationOfSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDurationOfSession.Name = "lblDurationOfSession";
			this.lblDurationOfSession.Size = new System.Drawing.Size(118, 15);
			this.lblDurationOfSession.TabIndex = 6;
			this.lblDurationOfSession.Text = "Duration of session:";
			// 
			// lblSubject
			// 
			this.lblSubject.AutoSize = true;
			this.lblSubject.Location = new System.Drawing.Point(14, 145);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.Size = new System.Drawing.Size(51, 15);
			this.lblSubject.TabIndex = 5;
			this.lblSubject.Text = "Subject:";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(14, 105);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(38, 15);
			this.lblTime.TabIndex = 4;
			this.lblTime.Text = "Time:";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(14, 65);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(36, 15);
			this.lblDate.TabIndex = 3;
			this.lblDate.Text = "Date:";
			// 
			// txtSubject
			// 
			this.txtSubject.Location = new System.Drawing.Point(132, 141);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(256, 21);
			this.txtSubject.TabIndex = 2;
			this.txtSubject.Text = "Type the subject of the lesson";
			this.txtSubject.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// txtTime
			// 
			this.txtTime.Location = new System.Drawing.Point(132, 105);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(256, 21);
			this.txtTime.TabIndex = 1;
			this.txtTime.Text = "Type the time of a lesson e.g. HH:MM:SS";
			this.txtTime.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// txtDate
			// 
			this.txtDate.Location = new System.Drawing.Point(132, 67);
			this.txtDate.Name = "txtDate";
			this.txtDate.Size = new System.Drawing.Size(256, 21);
			this.txtDate.TabIndex = 0;
			this.txtDate.Text = "Type the Date of a lesson e.g. YYYY-MM-DD";
			this.txtDate.Click += new System.EventHandler(this.DatabaseEntryTextBox_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 24);
			this.label1.TabIndex = 13;
			this.label1.Text = "Select a table to edit:";
			// 
			// btnStudentEntry
			// 
			this.btnStudentEntry.BackColor = System.Drawing.Color.LightGray;
			this.btnStudentEntry.Location = new System.Drawing.Point(235, 27);
			this.btnStudentEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnStudentEntry.Name = "btnStudentEntry";
			this.btnStudentEntry.Size = new System.Drawing.Size(72, 27);
			this.btnStudentEntry.TabIndex = 14;
			this.btnStudentEntry.Text = "Student";
			this.btnStudentEntry.UseVisualStyleBackColor = false;
			this.btnStudentEntry.Click += new System.EventHandler(this.btnStudentEntry_Click);
			// 
			// btnParentEntry
			// 
			this.btnParentEntry.BackColor = System.Drawing.Color.LightGray;
			this.btnParentEntry.Location = new System.Drawing.Point(334, 27);
			this.btnParentEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnParentEntry.Name = "btnParentEntry";
			this.btnParentEntry.Size = new System.Drawing.Size(72, 27);
			this.btnParentEntry.TabIndex = 15;
			this.btnParentEntry.Text = "Parent";
			this.btnParentEntry.UseVisualStyleBackColor = false;
			this.btnParentEntry.Click += new System.EventHandler(this.btnParentEntry_Click);
			// 
			// btnLessonEntry
			// 
			this.btnLessonEntry.BackColor = System.Drawing.Color.LightGray;
			this.btnLessonEntry.Location = new System.Drawing.Point(432, 27);
			this.btnLessonEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnLessonEntry.Name = "btnLessonEntry";
			this.btnLessonEntry.Size = new System.Drawing.Size(72, 27);
			this.btnLessonEntry.TabIndex = 16;
			this.btnLessonEntry.Text = "Lesson";
			this.btnLessonEntry.UseVisualStyleBackColor = false;
			this.btnLessonEntry.Click += new System.EventHandler(this.btnLessonEntry_Click);
			// 
			// pnlStudentEntry
			// 
			this.pnlStudentEntry.Controls.Add(this.btnSNext);
			this.pnlStudentEntry.Controls.Add(this.btnSPrevious);
			this.pnlStudentEntry.Controls.Add(this.btnSLast);
			this.pnlStudentEntry.Controls.Add(this.btnSFirst);
			this.pnlStudentEntry.Controls.Add(this.btnDltStudent);
			this.pnlStudentEntry.Controls.Add(this.btnSSearch);
			this.pnlStudentEntry.Controls.Add(this.btnSubmitStudentDetails);
			this.pnlStudentEntry.Controls.Add(this.grpStudentDetails);
			this.pnlStudentEntry.Location = new System.Drawing.Point(635, 58);
			this.pnlStudentEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pnlStudentEntry.Name = "pnlStudentEntry";
			this.pnlStudentEntry.Size = new System.Drawing.Size(617, 295);
			this.pnlStudentEntry.TabIndex = 17;
			// 
			// btnSNext
			// 
			this.btnSNext.Location = new System.Drawing.Point(525, 257);
			this.btnSNext.Name = "btnSNext";
			this.btnSNext.Size = new System.Drawing.Size(67, 23);
			this.btnSNext.TabIndex = 24;
			this.btnSNext.Text = "Next";
			this.btnSNext.UseVisualStyleBackColor = true;
			this.btnSNext.Click += new System.EventHandler(this.btnSNext_Click);
			// 
			// btnSPrevious
			// 
			this.btnSPrevious.Location = new System.Drawing.Point(444, 257);
			this.btnSPrevious.Name = "btnSPrevious";
			this.btnSPrevious.Size = new System.Drawing.Size(65, 23);
			this.btnSPrevious.TabIndex = 23;
			this.btnSPrevious.Text = "Previous";
			this.btnSPrevious.UseVisualStyleBackColor = true;
			this.btnSPrevious.Click += new System.EventHandler(this.btnSPrevious_Click);
			// 
			// btnSLast
			// 
			this.btnSLast.Location = new System.Drawing.Point(525, 221);
			this.btnSLast.Name = "btnSLast";
			this.btnSLast.Size = new System.Drawing.Size(67, 23);
			this.btnSLast.TabIndex = 22;
			this.btnSLast.Text = "Last";
			this.btnSLast.UseVisualStyleBackColor = true;
			this.btnSLast.Click += new System.EventHandler(this.btnSLast_Click);
			// 
			// btnSFirst
			// 
			this.btnSFirst.Location = new System.Drawing.Point(444, 221);
			this.btnSFirst.Name = "btnSFirst";
			this.btnSFirst.Size = new System.Drawing.Size(65, 23);
			this.btnSFirst.TabIndex = 21;
			this.btnSFirst.Text = "First";
			this.btnSFirst.UseVisualStyleBackColor = true;
			this.btnSFirst.Click += new System.EventHandler(this.btnSFirst_Click);
			// 
			// btnDltStudent
			// 
			this.btnDltStudent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDltStudent.Location = new System.Drawing.Point(444, 152);
			this.btnDltStudent.Name = "btnDltStudent";
			this.btnDltStudent.Size = new System.Drawing.Size(148, 49);
			this.btnDltStudent.TabIndex = 20;
			this.btnDltStudent.Text = "Delete this student from database";
			this.btnDltStudent.UseVisualStyleBackColor = true;
			this.btnDltStudent.Click += new System.EventHandler(this.btnDltStudent_Click);
			// 
			// btnSSearch
			// 
			this.btnSSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSSearch.Location = new System.Drawing.Point(444, 84);
			this.btnSSearch.Name = "btnSSearch";
			this.btnSSearch.Size = new System.Drawing.Size(148, 49);
			this.btnSSearch.TabIndex = 19;
			this.btnSSearch.Text = "Lookup student in database";
			this.toolTipSLookup.SetToolTip(this.btnSSearch, "Input first name and surname, then click this button");
			this.btnSSearch.UseVisualStyleBackColor = true;
			this.btnSSearch.Click += new System.EventHandler(this.btnSSearch_Click);
			this.btnSSearch.MouseLeave += new System.EventHandler(this.btnSSearch_MouseLeave);
			this.btnSSearch.MouseHover += new System.EventHandler(this.btnSSearch_MouseHover);
			// 
			// btnSubmitStudentDetails
			// 
			this.btnSubmitStudentDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitStudentDetails.Location = new System.Drawing.Point(444, 17);
			this.btnSubmitStudentDetails.Name = "btnSubmitStudentDetails";
			this.btnSubmitStudentDetails.Size = new System.Drawing.Size(148, 47);
			this.btnSubmitStudentDetails.TabIndex = 18;
			this.btnSubmitStudentDetails.Text = "Add student to a new field";
			this.btnSubmitStudentDetails.UseVisualStyleBackColor = true;
			this.btnSubmitStudentDetails.Click += new System.EventHandler(this.btnSubmitStudentDetails_Click);
			// 
			// pnlParentEntry
			// 
			this.pnlParentEntry.Controls.Add(this.btnPNext);
			this.pnlParentEntry.Controls.Add(this.btnPPrevious);
			this.pnlParentEntry.Controls.Add(this.btnPLast);
			this.pnlParentEntry.Controls.Add(this.btnPFirst);
			this.pnlParentEntry.Controls.Add(this.btnDltParent);
			this.pnlParentEntry.Controls.Add(this.btnPSearch);
			this.pnlParentEntry.Controls.Add(this.grpParentDetails);
			this.pnlParentEntry.Controls.Add(this.btnSubmitParentDetails);
			this.pnlParentEntry.Location = new System.Drawing.Point(635, 357);
			this.pnlParentEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pnlParentEntry.Name = "pnlParentEntry";
			this.pnlParentEntry.Size = new System.Drawing.Size(612, 294);
			this.pnlParentEntry.TabIndex = 18;
			// 
			// btnPNext
			// 
			this.btnPNext.Location = new System.Drawing.Point(527, 262);
			this.btnPNext.Name = "btnPNext";
			this.btnPNext.Size = new System.Drawing.Size(67, 23);
			this.btnPNext.TabIndex = 17;
			this.btnPNext.Text = "Next";
			this.btnPNext.UseVisualStyleBackColor = true;
			this.btnPNext.Click += new System.EventHandler(this.btnPNext_Click);
			// 
			// btnPPrevious
			// 
			this.btnPPrevious.Location = new System.Drawing.Point(446, 262);
			this.btnPPrevious.Name = "btnPPrevious";
			this.btnPPrevious.Size = new System.Drawing.Size(65, 23);
			this.btnPPrevious.TabIndex = 16;
			this.btnPPrevious.Text = "Previous";
			this.btnPPrevious.UseVisualStyleBackColor = true;
			this.btnPPrevious.Click += new System.EventHandler(this.btnPPrevious_Click);
			// 
			// btnPLast
			// 
			this.btnPLast.Location = new System.Drawing.Point(527, 226);
			this.btnPLast.Name = "btnPLast";
			this.btnPLast.Size = new System.Drawing.Size(67, 23);
			this.btnPLast.TabIndex = 15;
			this.btnPLast.Text = "Last";
			this.btnPLast.UseVisualStyleBackColor = true;
			this.btnPLast.Click += new System.EventHandler(this.btnPLast_Click);
			// 
			// btnPFirst
			// 
			this.btnPFirst.Location = new System.Drawing.Point(446, 226);
			this.btnPFirst.Name = "btnPFirst";
			this.btnPFirst.Size = new System.Drawing.Size(65, 23);
			this.btnPFirst.TabIndex = 14;
			this.btnPFirst.Text = "First";
			this.btnPFirst.UseVisualStyleBackColor = true;
			this.btnPFirst.Click += new System.EventHandler(this.btnPFirst_Click);
			// 
			// btnDltParent
			// 
			this.btnDltParent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDltParent.Location = new System.Drawing.Point(446, 157);
			this.btnDltParent.Name = "btnDltParent";
			this.btnDltParent.Size = new System.Drawing.Size(148, 49);
			this.btnDltParent.TabIndex = 13;
			this.btnDltParent.Text = "Delete this parent from database";
			this.btnDltParent.UseVisualStyleBackColor = true;
			this.btnDltParent.Click += new System.EventHandler(this.btnDltParent_Click);
			// 
			// btnPSearch
			// 
			this.btnPSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPSearch.Location = new System.Drawing.Point(446, 89);
			this.btnPSearch.Name = "btnPSearch";
			this.btnPSearch.Size = new System.Drawing.Size(148, 49);
			this.btnPSearch.TabIndex = 12;
			this.btnPSearch.Text = "Lookup parent in database";
			this.toolTipPLookup.SetToolTip(this.btnPSearch, "Input first name and surname, then click this button");
			this.btnPSearch.UseVisualStyleBackColor = true;
			this.btnPSearch.Click += new System.EventHandler(this.btnPSearch_Click);
			this.btnPSearch.MouseLeave += new System.EventHandler(this.btnPSearch_MouseLeave);
			this.btnPSearch.MouseHover += new System.EventHandler(this.btnPSearch_MouseHover);
			// 
			// pnlLessonEntry
			// 
			this.pnlLessonEntry.Controls.Add(this.grpFindStudentLesson);
			this.pnlLessonEntry.Controls.Add(this.btnLNext);
			this.pnlLessonEntry.Controls.Add(this.btnLPrevious);
			this.pnlLessonEntry.Controls.Add(this.btnLLast);
			this.pnlLessonEntry.Controls.Add(this.btnLFirst);
			this.pnlLessonEntry.Controls.Add(this.btnDltlesson);
			this.pnlLessonEntry.Controls.Add(this.btnLSearch);
			this.pnlLessonEntry.Controls.Add(this.btnSubmitLessonDetails);
			this.pnlLessonEntry.Controls.Add(this.grpLessonDetails);
			this.pnlLessonEntry.Location = new System.Drawing.Point(11, 58);
			this.pnlLessonEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pnlLessonEntry.Name = "pnlLessonEntry";
			this.pnlLessonEntry.Size = new System.Drawing.Size(593, 624);
			this.pnlLessonEntry.TabIndex = 19;
			// 
			// grpFindStudentLesson
			// 
			this.grpFindStudentLesson.Controls.Add(this.btnClear);
			this.grpFindStudentLesson.Controls.Add(this.dgvStudentLesson);
			this.grpFindStudentLesson.Controls.Add(this.btnFindStudentLesson);
			this.grpFindStudentLesson.Controls.Add(this.lblLessonDatePicker);
			this.grpFindStudentLesson.Controls.Add(this.dtpStudentLesson);
			this.grpFindStudentLesson.Controls.Add(this.txtStudentSurname);
			this.grpFindStudentLesson.Controls.Add(this.lblStudentSurname);
			this.grpFindStudentLesson.Location = new System.Drawing.Point(10, 296);
			this.grpFindStudentLesson.Name = "grpFindStudentLesson";
			this.grpFindStudentLesson.Size = new System.Drawing.Size(579, 290);
			this.grpFindStudentLesson.TabIndex = 25;
			this.grpFindStudentLesson.TabStop = false;
			this.grpFindStudentLesson.Text = "Find Student\'s Lesson";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(499, 27);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(67, 47);
			this.btnClear.TabIndex = 22;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// dgvStudentLesson
			// 
			this.dgvStudentLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudentLesson.Location = new System.Drawing.Point(17, 93);
			this.dgvStudentLesson.Name = "dgvStudentLesson";
			this.dgvStudentLesson.Size = new System.Drawing.Size(549, 181);
			this.dgvStudentLesson.TabIndex = 21;
			// 
			// btnFindStudentLesson
			// 
			this.btnFindStudentLesson.Location = new System.Drawing.Point(418, 27);
			this.btnFindStudentLesson.Name = "btnFindStudentLesson";
			this.btnFindStudentLesson.Size = new System.Drawing.Size(65, 47);
			this.btnFindStudentLesson.TabIndex = 20;
			this.btnFindStudentLesson.Text = "Find Lesson";
			this.btnFindStudentLesson.UseVisualStyleBackColor = true;
			this.btnFindStudentLesson.Click += new System.EventHandler(this.btnFindStudentLesson_Click);
			// 
			// lblLessonDatePicker
			// 
			this.lblLessonDatePicker.AutoSize = true;
			this.lblLessonDatePicker.Location = new System.Drawing.Point(17, 63);
			this.lblLessonDatePicker.Name = "lblLessonDatePicker";
			this.lblLessonDatePicker.Size = new System.Drawing.Size(109, 13);
			this.lblLessonDatePicker.TabIndex = 19;
			this.lblLessonDatePicker.Text = "Select date of lesson:";
			// 
			// dtpStudentLesson
			// 
			this.dtpStudentLesson.Location = new System.Drawing.Point(131, 57);
			this.dtpStudentLesson.Name = "dtpStudentLesson";
			this.dtpStudentLesson.Size = new System.Drawing.Size(256, 20);
			this.dtpStudentLesson.TabIndex = 18;
			// 
			// txtStudentSurname
			// 
			this.txtStudentSurname.Location = new System.Drawing.Point(131, 26);
			this.txtStudentSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtStudentSurname.Name = "txtStudentSurname";
			this.txtStudentSurname.Size = new System.Drawing.Size(256, 20);
			this.txtStudentSurname.TabIndex = 17;
			this.txtStudentSurname.Text = "Type the student\'s surname";
			// 
			// lblStudentSurname
			// 
			this.lblStudentSurname.AutoSize = true;
			this.lblStudentSurname.Location = new System.Drawing.Point(16, 33);
			this.lblStudentSurname.Name = "lblStudentSurname";
			this.lblStudentSurname.Size = new System.Drawing.Size(90, 13);
			this.lblStudentSurname.TabIndex = 16;
			this.lblStudentSurname.Text = "Student surname:";
			// 
			// btnLNext
			// 
			this.btnLNext.Location = new System.Drawing.Point(509, 255);
			this.btnLNext.Name = "btnLNext";
			this.btnLNext.Size = new System.Drawing.Size(67, 23);
			this.btnLNext.TabIndex = 24;
			this.btnLNext.Text = "Next";
			this.btnLNext.UseVisualStyleBackColor = true;
			this.btnLNext.Click += new System.EventHandler(this.btnLNext_Click);
			// 
			// btnLPrevious
			// 
			this.btnLPrevious.Location = new System.Drawing.Point(428, 255);
			this.btnLPrevious.Name = "btnLPrevious";
			this.btnLPrevious.Size = new System.Drawing.Size(65, 23);
			this.btnLPrevious.TabIndex = 23;
			this.btnLPrevious.Text = "Previous";
			this.btnLPrevious.UseVisualStyleBackColor = true;
			this.btnLPrevious.Click += new System.EventHandler(this.btnLPrevious_Click);
			// 
			// btnLLast
			// 
			this.btnLLast.Location = new System.Drawing.Point(509, 219);
			this.btnLLast.Name = "btnLLast";
			this.btnLLast.Size = new System.Drawing.Size(67, 23);
			this.btnLLast.TabIndex = 22;
			this.btnLLast.Text = "Last";
			this.btnLLast.UseVisualStyleBackColor = true;
			this.btnLLast.Click += new System.EventHandler(this.btnLLast_Click);
			// 
			// btnLFirst
			// 
			this.btnLFirst.Location = new System.Drawing.Point(428, 219);
			this.btnLFirst.Name = "btnLFirst";
			this.btnLFirst.Size = new System.Drawing.Size(65, 23);
			this.btnLFirst.TabIndex = 21;
			this.btnLFirst.Text = "First";
			this.btnLFirst.UseVisualStyleBackColor = true;
			this.btnLFirst.Click += new System.EventHandler(this.btnLFirst_Click);
			// 
			// btnDltlesson
			// 
			this.btnDltlesson.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDltlesson.Location = new System.Drawing.Point(428, 154);
			this.btnDltlesson.Name = "btnDltlesson";
			this.btnDltlesson.Size = new System.Drawing.Size(148, 49);
			this.btnDltlesson.TabIndex = 20;
			this.btnDltlesson.Text = "Delete this lesson from database";
			this.btnDltlesson.UseVisualStyleBackColor = true;
			this.btnDltlesson.Click += new System.EventHandler(this.btnDltlesson_Click);
			// 
			// btnLSearch
			// 
			this.btnLSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLSearch.Location = new System.Drawing.Point(428, 89);
			this.btnLSearch.Name = "btnLSearch";
			this.btnLSearch.Size = new System.Drawing.Size(148, 49);
			this.btnLSearch.TabIndex = 19;
			this.btnLSearch.Text = "Lookup lesson in database";
			this.toolTipLLookup.SetToolTip(this.btnLSearch, "Input date and time, then click this button");
			this.btnLSearch.UseVisualStyleBackColor = true;
			this.btnLSearch.Click += new System.EventHandler(this.btnLSearch_Click);
			this.btnLSearch.MouseLeave += new System.EventHandler(this.btnLSearch_MouseLeave);
			this.btnLSearch.MouseHover += new System.EventHandler(this.btnLSearch_MouseHover);
			// 
			// btnSubmitLessonDetails
			// 
			this.btnSubmitLessonDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitLessonDetails.Location = new System.Drawing.Point(428, 27);
			this.btnSubmitLessonDetails.Name = "btnSubmitLessonDetails";
			this.btnSubmitLessonDetails.Size = new System.Drawing.Size(148, 47);
			this.btnSubmitLessonDetails.TabIndex = 18;
			this.btnSubmitLessonDetails.Text = "Add lesson to a new field";
			this.btnSubmitLessonDetails.UseVisualStyleBackColor = true;
			this.btnSubmitLessonDetails.Click += new System.EventHandler(this.btnSubmitLessonDetails_Click);
			// 
			// btnMenuFromDataEntry
			// 
			this.btnMenuFromDataEntry.BackColor = System.Drawing.Color.White;
			this.btnMenuFromDataEntry.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnMenuFromDataEntry.Location = new System.Drawing.Point(530, 27);
			this.btnMenuFromDataEntry.Margin = new System.Windows.Forms.Padding(2);
			this.btnMenuFromDataEntry.Name = "btnMenuFromDataEntry";
			this.btnMenuFromDataEntry.Size = new System.Drawing.Size(73, 27);
			this.btnMenuFromDataEntry.TabIndex = 20;
			this.btnMenuFromDataEntry.Text = "Menu";
			this.btnMenuFromDataEntry.UseVisualStyleBackColor = false;
			this.btnMenuFromDataEntry.Click += new System.EventHandler(this.btnMenuFromDataEntry_Click);
			// 
			// FrmDatabaseCreation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1237, 674);
			this.Controls.Add(this.btnMenuFromDataEntry);
			this.Controls.Add(this.pnlStudentEntry);
			this.Controls.Add(this.pnlLessonEntry);
			this.Controls.Add(this.pnlParentEntry);
			this.Controls.Add(this.btnLessonEntry);
			this.Controls.Add(this.btnParentEntry);
			this.Controls.Add(this.btnStudentEntry);
			this.Controls.Add(this.label1);
			this.Name = "FrmDatabaseCreation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Initial data entry";
			this.Load += new System.EventHandler(this.frmCreateDatabase_Load);
			this.grpStudentDetails.ResumeLayout(false);
			this.grpStudentDetails.PerformLayout();
			this.grpParentDetails.ResumeLayout(false);
			this.grpParentDetails.PerformLayout();
			this.grpLessonDetails.ResumeLayout(false);
			this.grpLessonDetails.PerformLayout();
			this.pnlStudentEntry.ResumeLayout(false);
			this.pnlParentEntry.ResumeLayout(false);
			this.pnlLessonEntry.ResumeLayout(false);
			this.grpFindStudentLesson.ResumeLayout(false);
			this.grpFindStudentLesson.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudentLesson)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpStudentDetails;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblFamilyID;
        private System.Windows.Forms.TextBox txtsSurname;
        private System.Windows.Forms.TextBox txtsFirstName;
        private System.Windows.Forms.TextBox txtFamilyID;
		private System.Windows.Forms.Label lblAdditionalInfo;
		private System.Windows.Forms.TextBox txtYearGroup;
		private System.Windows.Forms.Label lblYearGroup;
		private System.Windows.Forms.TextBox txtAdditionalInfo;
		private System.Windows.Forms.GroupBox grpParentDetails;
		private System.Windows.Forms.TextBox txtpPhoneNumber;
		private System.Windows.Forms.Label lblPhoneNumber;
		private System.Windows.Forms.TextBox txtpEmail;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblpSurname;
		private System.Windows.Forms.Label lblpFirstName;
		private System.Windows.Forms.Label lblpFamilyId;
		private System.Windows.Forms.TextBox txtpSurname;
		private System.Windows.Forms.TextBox txtpFirstName;
		private System.Windows.Forms.TextBox txtpFamilyId;
		private System.Windows.Forms.Button btnSubmitParentDetails;
		private System.Windows.Forms.GroupBox grpLessonDetails;
		private System.Windows.Forms.TextBox txtKeyStage;
		private System.Windows.Forms.Label lblKeyStage;
		private System.Windows.Forms.Label lblSubject;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.TextBox txtDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnStudentEntry;
		private System.Windows.Forms.Button btnParentEntry;
		private System.Windows.Forms.Button btnLessonEntry;
		private System.Windows.Forms.Panel pnlStudentEntry;
		private System.Windows.Forms.Panel pnlParentEntry;
		private System.Windows.Forms.Panel pnlLessonEntry;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtsStudentID;
		private System.Windows.Forms.Label lblsStudentID;
		private System.Windows.Forms.TextBox txtDurationOfLesson;
		private System.Windows.Forms.Label lblDurationOfSession;
		private System.Windows.Forms.TextBox txtlStudentID;
		private System.Windows.Forms.Label lbllStudentID;
		private System.Windows.Forms.Button btnPNext;
		private System.Windows.Forms.Button btnPPrevious;
		private System.Windows.Forms.Button btnPLast;
		private System.Windows.Forms.Button btnPFirst;
		private System.Windows.Forms.Button btnDltParent;
		private System.Windows.Forms.Button btnPSearch;
		private System.Windows.Forms.Button btnSNext;
		private System.Windows.Forms.Button btnSPrevious;
		private System.Windows.Forms.Button btnSLast;
		private System.Windows.Forms.Button btnSFirst;
		private System.Windows.Forms.Button btnDltStudent;
		private System.Windows.Forms.Button btnSSearch;
		private System.Windows.Forms.Button btnSubmitStudentDetails;
		private System.Windows.Forms.Button btnLNext;
		private System.Windows.Forms.Button btnLPrevious;
		private System.Windows.Forms.Button btnLLast;
		private System.Windows.Forms.Button btnLFirst;
		private System.Windows.Forms.Button btnDltlesson;
		private System.Windows.Forms.Button btnLSearch;
		private System.Windows.Forms.Button btnSubmitLessonDetails;
		private System.Windows.Forms.ToolTip toolTipPLookup;
		private System.Windows.Forms.ToolTip toolTipSLookup;
		private System.Windows.Forms.ToolTip toolTipLLookup;
		private System.Windows.Forms.TextBox txtStudentSurname;
		private System.Windows.Forms.Label lblStudentSurname;
		private System.Windows.Forms.GroupBox grpFindStudentLesson;
		private System.Windows.Forms.DataGridView dgvStudentLesson;
		private System.Windows.Forms.Button btnFindStudentLesson;
		private System.Windows.Forms.Label lblLessonDatePicker;
		private System.Windows.Forms.DateTimePicker dtpStudentLesson;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnMenuFromDataEntry;
	}
}

