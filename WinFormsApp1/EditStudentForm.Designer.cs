namespace StudentRecordApp
{
    partial class EditStudentForm
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
            button2 = new Button();
            button1 = new Button();
            lblEditStudentFormTitle = new Label();
            dtBirthdate = new DateTimePicker();
            cmbGender = new ComboBox();
            txtAddress = new TextBox();
            txtSurname = new TextBox();
            txtFirstname = new TextBox();
            lblcmdGender = new Label();
            lbltxtAddress = new Label();
            lbldtBirthdate = new Label();
            lbltxtSurname = new Label();
            lbltxtFirstName = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(142, 233);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 27;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(44, 233);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblEditStudentFormTitle
            // 
            lblEditStudentFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEditStudentFormTitle.Location = new Point(12, 17);
            lblEditStudentFormTitle.Name = "lblEditStudentFormTitle";
            lblEditStudentFormTitle.Size = new Size(233, 42);
            lblEditStudentFormTitle.TabIndex = 25;
            lblEditStudentFormTitle.Text = "Edit Record";
            lblEditStudentFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblEditStudentFormTitle.Click += lblAddStudentFormTitle_Click;
            // 
            // dtBirthdate
            // 
            dtBirthdate.Location = new Point(95, 125);
            dtBirthdate.Name = "dtBirthdate";
            dtBirthdate.Size = new Size(150, 23);
            dtBirthdate.TabIndex = 24;
            dtBirthdate.ValueChanged += dtBirthdate_ValueChanged;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(95, 154);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(150, 23);
            cmbGender.TabIndex = 23;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(95, 183);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 23);
            txtAddress.TabIndex = 22;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(95, 96);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(150, 23);
            txtSurname.TabIndex = 21;
            txtSurname.TextChanged += txtSurname_TextChanged;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(95, 67);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(150, 23);
            txtFirstname.TabIndex = 20;
            txtFirstname.TextChanged += txtFirstname_TextChanged;
            // 
            // lblcmdGender
            // 
            lblcmdGender.Font = new Font("Segoe UI", 9.75F);
            lblcmdGender.Location = new Point(12, 154);
            lblcmdGender.Name = "lblcmdGender";
            lblcmdGender.Size = new Size(77, 23);
            lblcmdGender.TabIndex = 19;
            lblcmdGender.Text = "Gender";
            lblcmdGender.TextAlign = ContentAlignment.MiddleCenter;
            lblcmdGender.Click += lblcmdGender_Click;
            // 
            // lbltxtAddress
            // 
            lbltxtAddress.Font = new Font("Segoe UI", 9.75F);
            lbltxtAddress.Location = new Point(12, 183);
            lbltxtAddress.Name = "lbltxtAddress";
            lbltxtAddress.Size = new Size(77, 23);
            lbltxtAddress.TabIndex = 18;
            lbltxtAddress.Text = "Address";
            lbltxtAddress.TextAlign = ContentAlignment.MiddleCenter;
            lbltxtAddress.Click += lbltxtAddress_Click;
            // 
            // lbldtBirthdate
            // 
            lbldtBirthdate.Font = new Font("Segoe UI", 9.75F);
            lbldtBirthdate.Location = new Point(12, 123);
            lbldtBirthdate.Name = "lbldtBirthdate";
            lbldtBirthdate.Size = new Size(77, 23);
            lbldtBirthdate.TabIndex = 17;
            lbldtBirthdate.Text = "Birthdate";
            lbldtBirthdate.TextAlign = ContentAlignment.MiddleCenter;
            lbldtBirthdate.Click += lbldtBirthdate_Click;
            // 
            // lbltxtSurname
            // 
            lbltxtSurname.Font = new Font("Segoe UI", 9.75F);
            lbltxtSurname.Location = new Point(12, 94);
            lbltxtSurname.Name = "lbltxtSurname";
            lbltxtSurname.Size = new Size(77, 23);
            lbltxtSurname.TabIndex = 16;
            lbltxtSurname.Text = "Last Name";
            lbltxtSurname.TextAlign = ContentAlignment.MiddleCenter;
            lbltxtSurname.Click += lbltxtSurname_Click;
            // 
            // lbltxtFirstName
            // 
            lbltxtFirstName.Font = new Font("Segoe UI", 9.75F);
            lbltxtFirstName.Location = new Point(12, 67);
            lbltxtFirstName.Name = "lbltxtFirstName";
            lbltxtFirstName.Size = new Size(77, 23);
            lbltxtFirstName.TabIndex = 15;
            lbltxtFirstName.Text = "First Name";
            lbltxtFirstName.TextAlign = ContentAlignment.MiddleCenter;
            lbltxtFirstName.Click += lbltxtFirstName_Click;
            // 
            // EditStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 296);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblEditStudentFormTitle);
            Controls.Add(dtBirthdate);
            Controls.Add(cmbGender);
            Controls.Add(txtAddress);
            Controls.Add(txtSurname);
            Controls.Add(txtFirstname);
            Controls.Add(lblcmdGender);
            Controls.Add(lbltxtAddress);
            Controls.Add(lbldtBirthdate);
            Controls.Add(lbltxtSurname);
            Controls.Add(lbltxtFirstName);
            Name = "EditStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label lblEditStudentFormTitle;
        private DateTimePicker dtBirthdate;
        private ComboBox cmbGender;
        private TextBox txtAddress;
        private TextBox txtSurname;
        private TextBox txtFirstname;
        private Label lblcmdGender;
        private Label lbltxtAddress;
        private Label lbldtBirthdate;
        private Label lbltxtSurname;
        private Label lbltxtFirstName;
    }
}