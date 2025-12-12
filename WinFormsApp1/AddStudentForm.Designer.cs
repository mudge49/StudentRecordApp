
namespace WinFormsApp1
{
    partial class AddStudentForm
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
            lbltxtFirstName = new Label();
            lbltxtSurname = new Label();
            lbldtBirthdate = new Label();
            lbltxtAddress = new Label();
            lblcmdGender = new Label();
            txtFirstname = new TextBox();
            txtSurname = new TextBox();
            txtAddress = new TextBox();
            cmbGender = new ComboBox();
            dtBirthdate = new DateTimePicker();
            lblAddStudentFormTitle = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lbltxtFirstName
            // 
            lbltxtFirstName.Font = new Font("Segoe UI", 9.75F);
            lbltxtFirstName.Location = new Point(12, 59);
            lbltxtFirstName.Name = "lbltxtFirstName";
            lbltxtFirstName.Size = new Size(77, 23);
            lbltxtFirstName.TabIndex = 0;
            lbltxtFirstName.Text = "First Name";
            lbltxtFirstName.TextAlign = ContentAlignment.MiddleCenter;
            lbltxtFirstName.Click += label1_Click;
            // 
            // lbltxtSurname
            // 
            lbltxtSurname.Font = new Font("Segoe UI", 9.75F);
            lbltxtSurname.Location = new Point(12, 86);
            lbltxtSurname.Name = "lbltxtSurname";
            lbltxtSurname.Size = new Size(77, 23);
            lbltxtSurname.TabIndex = 1;
            lbltxtSurname.Text = "Last Name";
            lbltxtSurname.TextAlign = ContentAlignment.MiddleCenter;
            lbltxtSurname.Click += label2_Click;
            // 
            // lbldtBirthdate
            // 
            lbldtBirthdate.Font = new Font("Segoe UI", 9.75F);
            lbldtBirthdate.Location = new Point(12, 115);
            lbldtBirthdate.Name = "lbldtBirthdate";
            lbldtBirthdate.Size = new Size(77, 23);
            lbldtBirthdate.TabIndex = 2;
            lbldtBirthdate.Text = "Birthdate";
            lbldtBirthdate.TextAlign = ContentAlignment.MiddleCenter;
            lbldtBirthdate.Click += label3_Click;
            // 
            // lbltxtAddress
            // 
            lbltxtAddress.Font = new Font("Segoe UI", 9.75F);
            lbltxtAddress.Location = new Point(12, 175);
            lbltxtAddress.Name = "lbltxtAddress";
            lbltxtAddress.Size = new Size(77, 23);
            lbltxtAddress.TabIndex = 3;
            lbltxtAddress.Text = "Address";
            lbltxtAddress.TextAlign = ContentAlignment.MiddleCenter;
            lbltxtAddress.Click += label4_Click;
            // 
            // lblcmdGender
            // 
            lblcmdGender.Font = new Font("Segoe UI", 9.75F);
            lblcmdGender.Location = new Point(12, 146);
            lblcmdGender.Name = "lblcmdGender";
            lblcmdGender.Size = new Size(77, 23);
            lblcmdGender.TabIndex = 4;
            lblcmdGender.Text = "Gender";
            lblcmdGender.TextAlign = ContentAlignment.MiddleCenter;
            lblcmdGender.Click += label5_Click;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(95, 59);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(150, 23);
            txtFirstname.TabIndex = 5;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(95, 88);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(150, 23);
            txtSurname.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(95, 175);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 67);
            txtAddress.TabIndex = 9;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(95, 146);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(150, 23);
            cmbGender.TabIndex = 10;
            // 
            // dtBirthdate
            // 
            dtBirthdate.Location = new Point(95, 117);
            dtBirthdate.Name = "dtBirthdate";
            dtBirthdate.Size = new Size(150, 23);
            dtBirthdate.TabIndex = 11;
            dtBirthdate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblAddStudentFormTitle
            // 
            lblAddStudentFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddStudentFormTitle.Location = new Point(12, 9);
            lblAddStudentFormTitle.Name = "lblAddStudentFormTitle";
            lblAddStudentFormTitle.Size = new Size(233, 42);
            lblAddStudentFormTitle.TabIndex = 12;
            lblAddStudentFormTitle.Text = "Add to Records";
            lblAddStudentFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(44, 260);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(142, 260);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 296);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblAddStudentFormTitle);
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
            Name = "AddStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lbltxtFirstName;
        private Label lbltxtSurname;
        private Label lbldtBirthdate;
        private Label lbltxtAddress;
        private Label lblcmdGender;
        private TextBox txtFirstname;
        private TextBox txtSurname;
        private TextBox txtAddress;
        private ComboBox cmbGender;
        private DateTimePicker dtBirthdate;
        private Label lblAddStudentFormTitle;
        private Button button1;
        private Button button2;
    }
}