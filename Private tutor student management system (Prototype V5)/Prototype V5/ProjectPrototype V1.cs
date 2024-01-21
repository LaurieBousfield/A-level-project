namespace DatabaseCreation
{
    partial class frmCreateDatabase
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
			this.btnClose = new System.Windows.Forms.Button();
			this.grpStudentDetails = new System.Windows.Forms.GroupBox();
			this.txtDoB = new System.Windows.Forms.TextBox();
			this.lblDoB = new System.Windows.Forms.Label();
			this.txtAdditionalInfo = new System.Windows.Forms.TextBox();
			this.lblAdditionalInfo = new System.Windows.Forms.Label();
			this.lblSurname = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblFamilyID = new System.Windows.Forms.Label();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtFamilyID = new System.Windows.Forms.TextBox();
			this.btnSubmitStudentDetail = new System.Windows.Forms.Button();
			this.grpParentDetails = new System.Windows.Forms.GroupBox();
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
			this.btnSubmitParentDetail = new System.Windows.Forms.Button();
			this.grpLessonDetails = new System.Windows.Forms.GroupBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.txtDurationOfLesson = new System.Windows.Forms.TextBox();
			this.lblDurationOfSession = new System.Windows.Forms.Label();
			this.lblSubject = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.lblQualification = new System.Windows.Forms.Label();
			this.lblFamilyIdNo = new System.Windows.Forms.Label();
			this.txtQualification = new System.Windows.Forms.TextBox();
			this.txtlFamilyId = new System.Windows.Forms.TextBox();
			this.lbllFirstName = new System.Windows.Forms.Label();
			this.txtlFirstName = new System.Windows.Forms.TextBox();
			this.btnSubmitLessonDetails = new System.Windows.Forms.Button();
			this.grpStudentDetails.SuspendLayout();
			this.grpParentDetails.SuspendLayout();
			this.grpLessonDetails.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(720, 1402);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(176, 37);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// grpStudentDetails
			// 
			this.grpStudentDetails.Controls.Add(this.txtDoB);
			this.grpStudentDetails.Controls.Add(this.lblDoB);
			this.grpStudentDetails.Controls.Add(this.txtAdditionalInfo);
			this.grpStudentDetails.Controls.Add(this.lblAdditionalInfo);
			this.grpStudentDetails.Controls.Add(this.lblSurname);
			this.grpStudentDetails.Controls.Add(this.lblFirstName);
			this.grpStudentDetails.Controls.Add(this.lblFamilyID);
			this.grpStudentDetails.Controls.Add(this.txtSurname);
			this.grpStudentDetails.Controls.Add(this.txtFirstName);
			this.grpStudentDetails.Controls.Add(this.txtFamilyID);
			this.grpStudentDetails.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpStudentDetails.Location = new System.Drawing.Point(69, 14);
			this.grpStudentDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpStudentDetails.Name = "grpStudentDetails";
			this.grpStudentDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpStudentDetails.Size = new System.Drawing.Size(636, 376);
			this.grpStudentDetails.TabIndex = 1;
			this.grpStudentDetails.TabStop = false;
			this.grpStudentDetails.Text = "Student details input";
			this.grpStudentDetails.Enter += new System.EventHandler(this.grpStudentDetails_Enter);
			// 
			// txtDoB
			// 
			this.txtDoB.Location = new System.Drawing.Point(207, 310);
			this.txtDoB.Name = "txtDoB";
			this.txtDoB.Size = new System.Drawing.Size(382, 21);
			this.txtDoB.TabIndex = 9;
			this.txtDoB.Text = "Type student\'s Date of Birth";
			// 
			// lblDoB
			// 
			this.lblDoB.AutoSize = true;
			this.lblDoB.Location = new System.Drawing.Point(30, 316);
			this.lblDoB.Name = "lblDoB";
			this.lblDoB.Size = new System.Drawing.Size(34, 15);
			this.lblDoB.TabIndex = 8;
			this.lblDoB.Text = "DoB:";
			// 
			// txtAdditionalInfo
			// 
			this.txtAdditionalInfo.Location = new System.Drawing.Point(207, 254);
			this.txtAdditionalInfo.Name = "txtAdditionalInfo";
			this.txtAdditionalInfo.Size = new System.Drawing.Size(382, 21);
			this.txtAdditionalInfo.TabIndex = 7;
			this.txtAdditionalInfo.Text = "Type any info you want your tutor to be aware of";
			this.txtAdditionalInfo.TextChanged += new System.EventHandler(this.txtAdditionalInfo_TextChanged);
			// 
			// lblAdditionalInfo
			// 
			this.lblAdditionalInfo.AutoSize = true;
			this.lblAdditionalInfo.Location = new System.Drawing.Point(30, 260);
			this.lblAdditionalInfo.Name = "lblAdditionalInfo";
			this.lblAdditionalInfo.Size = new System.Drawing.Size(87, 15);
			this.lblAdditionalInfo.TabIndex = 6;
			this.lblAdditionalInfo.Text = "Additional info:";
			this.lblAdditionalInfo.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblSurname
			// 
			this.lblSurname.AutoSize = true;
			this.lblSurname.Location = new System.Drawing.Point(30, 198);
			this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSurname.Name = "lblSurname";
			this.lblSurname.Size = new System.Drawing.Size(61, 15);
			this.lblSurname.TabIndex = 5;
			this.lblSurname.Text = "Surname:";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(30, 137);
			this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(69, 15);
			this.lblFirstName.TabIndex = 4;
			this.lblFirstName.Text = "First name:";
			// 
			// lblFamilyID
			// 
			this.lblFamilyID.AutoSize = true;
			this.lblFamilyID.Location = new System.Drawing.Point(30, 75);
			this.lblFamilyID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFamilyID.Name = "lblFamilyID";
			this.lblFamilyID.Size = new System.Drawing.Size(58, 15);
			this.lblFamilyID.TabIndex = 3;
			this.lblFamilyID.Text = "FamilyID:";
			// 
			// txtSurname
			// 
			this.txtSurname.Location = new System.Drawing.Point(207, 192);
			this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(382, 21);
			this.txtSurname.TabIndex = 2;
			this.txtSurname.Text = "Type a surname here";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(207, 131);
			this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(382, 21);
			this.txtFirstName.TabIndex = 1;
			this.txtFirstName.Text = "Type a first name here";
			// 
			// txtFamilyID
			// 
			this.txtFamilyID.Location = new System.Drawing.Point(207, 69);
			this.txtFamilyID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtFamilyID.Name = "txtFamilyID";
			this.txtFamilyID.Size = new System.Drawing.Size(382, 21);
			this.txtFamilyID.TabIndex = 0;
			this.txtFamilyID.Text = "Type a Family ID here (whole number)";
			// 
			// btnSubmitStudentDetail
			// 
			this.btnSubmitStudentDetail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitStudentDetail.Location = new System.Drawing.Point(69, 400);
			this.btnSubmitStudentDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSubmitStudentDetail.Name = "btnSubmitStudentDetail";
			this.btnSubmitStudentDetail.Size = new System.Drawing.Size(233, 39);
			this.btnSubmitStudentDetail.TabIndex = 2;
			this.btnSubmitStudentDetail.Text = "Submit Student Details";
			this.btnSubmitStudentDetail.UseVisualStyleBackColor = true;
			this.btnSubmitStudentDetail.Click += new System.EventHandler(this.btnSubmitStudentDetails_Click);
			// 
			// grpParentDetails
			// 
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
			this.grpParentDetails.Location = new System.Drawing.Point(69, 449);
			this.grpParentDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpParentDetails.Name = "grpParentDetails";
			this.grpParentDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpParentDetails.Size = new System.Drawing.Size(636, 376);
			this.grpParentDetails.TabIndex = 10;
			this.grpParentDetails.TabStop = false;
			this.grpParentDetails.Text = "Parent details input";
			this.grpParentDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// txtpPhoneNumber
			// 
			this.txtpPhoneNumber.Location = new System.Drawing.Point(207, 310);
			this.txtpPhoneNumber.Name = "txtpPhoneNumber";
			this.txtpPhoneNumber.Size = new System.Drawing.Size(382, 21);
			this.txtpPhoneNumber.TabIndex = 9;
			this.txtpPhoneNumber.Text = "Type the parent\'s phone number";
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.AutoSize = true;
			this.lblPhoneNumber.Location = new System.Drawing.Point(30, 316);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.Size = new System.Drawing.Size(94, 15);
			this.lblPhoneNumber.TabIndex = 8;
			this.lblPhoneNumber.Text = "Phone Number:";
			// 
			// txtpEmail
			// 
			this.txtpEmail.Location = new System.Drawing.Point(207, 254);
			this.txtpEmail.Name = "txtpEmail";
			this.txtpEmail.Size = new System.Drawing.Size(382, 21);
			this.txtpEmail.TabIndex = 7;
			this.txtpEmail.Text = "Type the parent\'s email ";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(30, 260);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(42, 15);
			this.lblEmail.TabIndex = 6;
			this.lblEmail.Text = "Email:";
			// 
			// lblpSurname
			// 
			this.lblpSurname.AutoSize = true;
			this.lblpSurname.Location = new System.Drawing.Point(30, 198);
			this.lblpSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblpSurname.Name = "lblpSurname";
			this.lblpSurname.Size = new System.Drawing.Size(61, 15);
			this.lblpSurname.TabIndex = 5;
			this.lblpSurname.Text = "Surname:";
			// 
			// lblpFirstName
			// 
			this.lblpFirstName.AutoSize = true;
			this.lblpFirstName.Location = new System.Drawing.Point(30, 137);
			this.lblpFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblpFirstName.Name = "lblpFirstName";
			this.lblpFirstName.Size = new System.Drawing.Size(69, 15);
			this.lblpFirstName.TabIndex = 4;
			this.lblpFirstName.Text = "First name:";
			// 
			// lblpFamilyId
			// 
			this.lblpFamilyId.AutoSize = true;
			this.lblpFamilyId.Location = new System.Drawing.Point(30, 75);
			this.lblpFamilyId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblpFamilyId.Name = "lblpFamilyId";
			this.lblpFamilyId.Size = new System.Drawing.Size(58, 15);
			this.lblpFamilyId.TabIndex = 3;
			this.lblpFamilyId.Text = "FamilyID:";
			// 
			// txtpSurname
			// 
			this.txtpSurname.Location = new System.Drawing.Point(207, 192);
			this.txtpSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtpSurname.Name = "txtpSurname";
			this.txtpSurname.Size = new System.Drawing.Size(382, 21);
			this.txtpSurname.TabIndex = 2;
			this.txtpSurname.Text = "Type a surname here";
			// 
			// txtpFirstName
			// 
			this.txtpFirstName.Location = new System.Drawing.Point(207, 131);
			this.txtpFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtpFirstName.Name = "txtpFirstName";
			this.txtpFirstName.Size = new System.Drawing.Size(382, 21);
			this.txtpFirstName.TabIndex = 1;
			this.txtpFirstName.Text = "Type a first name here";
			// 
			// txtpFamilyId
			// 
			this.txtpFamilyId.Location = new System.Drawing.Point(207, 69);
			this.txtpFamilyId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtpFamilyId.Name = "txtpFamilyId";
			this.txtpFamilyId.Size = new System.Drawing.Size(382, 21);
			this.txtpFamilyId.TabIndex = 0;
			this.txtpFamilyId.Text = "Type a Family ID here (whole number)";
			// 
			// btnSubmitParentDetail
			// 
			this.btnSubmitParentDetail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitParentDetail.Location = new System.Drawing.Point(69, 835);
			this.btnSubmitParentDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSubmitParentDetail.Name = "btnSubmitParentDetail";
			this.btnSubmitParentDetail.Size = new System.Drawing.Size(233, 37);
			this.btnSubmitParentDetail.TabIndex = 11;
			this.btnSubmitParentDetail.Text = "Submit Parent Details";
			this.btnSubmitParentDetail.UseVisualStyleBackColor = true;
			this.btnSubmitParentDetail.Click += new System.EventHandler(this.btnSubmitParentDetail_Click);
			// 
			// grpLessonDetails
			// 
			this.grpLessonDetails.Controls.Add(this.txtlFirstName);
			this.grpLessonDetails.Controls.Add(this.lbllFirstName);
			this.grpLessonDetails.Controls.Add(this.txtlFamilyId);
			this.grpLessonDetails.Controls.Add(this.txtQualification);
			this.grpLessonDetails.Controls.Add(this.lblFamilyIdNo);
			this.grpLessonDetails.Controls.Add(this.lblQualification);
			this.grpLessonDetails.Controls.Add(this.txtPrice);
			this.grpLessonDetails.Controls.Add(this.lblPrice);
			this.grpLessonDetails.Controls.Add(this.txtDurationOfLesson);
			this.grpLessonDetails.Controls.Add(this.lblDurationOfSession);
			this.grpLessonDetails.Controls.Add(this.lblSubject);
			this.grpLessonDetails.Controls.Add(this.lblTime);
			this.grpLessonDetails.Controls.Add(this.lblDate);
			this.grpLessonDetails.Controls.Add(this.txtSubject);
			this.grpLessonDetails.Controls.Add(this.txtTime);
			this.grpLessonDetails.Controls.Add(this.txtDate);
			this.grpLessonDetails.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpLessonDetails.Location = new System.Drawing.Point(69, 882);
			this.grpLessonDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpLessonDetails.Name = "grpLessonDetails";
			this.grpLessonDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grpLessonDetails.Size = new System.Drawing.Size(636, 510);
			this.grpLessonDetails.TabIndex = 11;
			this.grpLessonDetails.TabStop = false;
			this.grpLessonDetails.Text = "Lesson details input";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(207, 310);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(382, 21);
			this.txtPrice.TabIndex = 9;
			this.txtPrice.Text = "Type the price of this session";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(30, 316);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(38, 15);
			this.lblPrice.TabIndex = 8;
			this.lblPrice.Text = "Price:";
			// 
			// txtDurationOfLesson
			// 
			this.txtDurationOfLesson.Location = new System.Drawing.Point(207, 254);
			this.txtDurationOfLesson.Name = "txtDurationOfLesson";
			this.txtDurationOfLesson.Size = new System.Drawing.Size(382, 21);
			this.txtDurationOfLesson.TabIndex = 7;
			this.txtDurationOfLesson.Text = "Type the duration of this lesson";
			// 
			// lblDurationOfSession
			// 
			this.lblDurationOfSession.AutoSize = true;
			this.lblDurationOfSession.Location = new System.Drawing.Point(30, 260);
			this.lblDurationOfSession.Name = "lblDurationOfSession";
			this.lblDurationOfSession.Size = new System.Drawing.Size(111, 15);
			this.lblDurationOfSession.TabIndex = 6;
			this.lblDurationOfSession.Text = "Duratio of session:";
			// 
			// lblSubject
			// 
			this.lblSubject.AutoSize = true;
			this.lblSubject.Location = new System.Drawing.Point(30, 198);
			this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.Size = new System.Drawing.Size(51, 15);
			this.lblSubject.TabIndex = 5;
			this.lblSubject.Text = "Subject:";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(30, 137);
			this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(38, 15);
			this.lblTime.TabIndex = 4;
			this.lblTime.Text = "Time:";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(30, 75);
			this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(36, 15);
			this.lblDate.TabIndex = 3;
			this.lblDate.Text = "Date:";
			// 
			// txtSubject
			// 
			this.txtSubject.Location = new System.Drawing.Point(207, 192);
			this.txtSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(382, 21);
			this.txtSubject.TabIndex = 2;
			this.txtSubject.Text = "Type the subject of the lesson";
			// 
			// txtTime
			// 
			this.txtTime.Location = new System.Drawing.Point(207, 131);
			this.txtTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(382, 21);
			this.txtTime.TabIndex = 1;
			this.txtTime.Text = "Type the time of a lesson";
			// 
			// txtDate
			// 
			this.txtDate.Location = new System.Drawing.Point(207, 69);
			this.txtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDate.Name = "txtDate";
			this.txtDate.Size = new System.Drawing.Size(382, 21);
			this.txtDate.TabIndex = 0;
			this.txtDate.Text = "Type the Date of a lesson";
			// 
			// lblQualification
			// 
			this.lblQualification.AutoSize = true;
			this.lblQualification.Location = new System.Drawing.Point(30, 370);
			this.lblQualification.Name = "lblQualification";
			this.lblQualification.Size = new System.Drawing.Size(78, 15);
			this.lblQualification.TabIndex = 10;
			this.lblQualification.Text = "Qualification:";
			// 
			// lblFamilyIdNo
			// 
			this.lblFamilyIdNo.AutoSize = true;
			this.lblFamilyIdNo.Location = new System.Drawing.Point(30, 425);
			this.lblFamilyIdNo.Name = "lblFamilyIdNo";
			this.lblFamilyIdNo.Size = new System.Drawing.Size(58, 15);
			this.lblFamilyIdNo.TabIndex = 11;
			this.lblFamilyIdNo.Text = "FamilyID:";
			// 
			// txtQualification
			// 
			this.txtQualification.Location = new System.Drawing.Point(207, 364);
			this.txtQualification.Name = "txtQualification";
			this.txtQualification.Size = new System.Drawing.Size(382, 21);
			this.txtQualification.TabIndex = 12;
			this.txtQualification.Text = "Type the qualification of the lesson\'s subject";
			// 
			// txtlFamilyId
			// 
			this.txtlFamilyId.Location = new System.Drawing.Point(207, 419);
			this.txtlFamilyId.Name = "txtlFamilyId";
			this.txtlFamilyId.Size = new System.Drawing.Size(382, 21);
			this.txtlFamilyId.TabIndex = 13;
			this.txtlFamilyId.Text = "Type the familyID of the student taking this lesson ";
			// 
			// lbllFirstName
			// 
			this.lbllFirstName.AutoSize = true;
			this.lbllFirstName.Location = new System.Drawing.Point(20, 477);
			this.lbllFirstName.Name = "lbllFirstName";
			this.lbllFirstName.Size = new System.Drawing.Size(71, 15);
			this.lbllFirstName.TabIndex = 14;
			this.lbllFirstName.Text = "First Name:";
			// 
			// txtlFirstName
			// 
			this.txtlFirstName.Location = new System.Drawing.Point(207, 471);
			this.txtlFirstName.Name = "txtlFirstName";
			this.txtlFirstName.Size = new System.Drawing.Size(382, 21);
			this.txtlFirstName.TabIndex = 15;
			this.txtlFirstName.Text = "Type the first name of the student taking this lesson";
			// 
			// btnSubmitLessonDetails
			// 
			this.btnSubmitLessonDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitLessonDetails.Location = new System.Drawing.Point(69, 1402);
			this.btnSubmitLessonDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSubmitLessonDetails.Name = "btnSubmitLessonDetails";
			this.btnSubmitLessonDetails.Size = new System.Drawing.Size(233, 37);
			this.btnSubmitLessonDetails.TabIndex = 12;
			this.btnSubmitLessonDetails.Text = "Submit Lesson Details";
			this.btnSubmitLessonDetails.UseVisualStyleBackColor = true;
			this.btnSubmitLessonDetails.Click += new System.EventHandler(this.btnSubmitLessonDetails_Click);
			// 
			// frmCreateDatabase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(926, 1061);
			this.Controls.Add(this.btnSubmitLessonDetails);
			this.Controls.Add(this.grpLessonDetails);
			this.Controls.Add(this.btnSubmitParentDetail);
			this.Controls.Add(this.grpParentDetails);
			this.Controls.Add(this.btnSubmitStudentDetail);
			this.Controls.Add(this.grpStudentDetails);
			this.Controls.Add(this.btnClose);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCreateDatabase";
			this.Text = "Creating a database in code";
			this.Load += new System.EventHandler(this.frmCreateDatabase_Load);
			this.grpStudentDetails.ResumeLayout(false);
			this.grpStudentDetails.PerformLayout();
			this.grpParentDetails.ResumeLayout(false);
			this.grpParentDetails.PerformLayout();
			this.grpLessonDetails.ResumeLayout(false);
			this.grpLessonDetails.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblFamilyID;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtFamilyID;
        private System.Windows.Forms.Button btnSubmitStudentDetail;
		private System.Windows.Forms.Label lblAdditionalInfo;
		private System.Windows.Forms.TextBox txtDoB;
		private System.Windows.Forms.Label lblDoB;
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
		private System.Windows.Forms.Button btnSubmitParentDetail;
		private System.Windows.Forms.GroupBox grpLessonDetails;
		private System.Windows.Forms.TextBox txtlFirstName;
		private System.Windows.Forms.Label lbllFirstName;
		private System.Windows.Forms.TextBox txtlFamilyId;
		private System.Windows.Forms.TextBox txtQualification;
		private System.Windows.Forms.Label lblFamilyIdNo;
		private System.Windows.Forms.Label lblQualification;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.TextBox txtDurationOfLesson;
		private System.Windows.Forms.Label lblDurationOfSession;
		private System.Windows.Forms.Label lblSubject;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.TextBox txtDate;
		private System.Windows.Forms.Button btnSubmitLessonDetails;
	}
}

