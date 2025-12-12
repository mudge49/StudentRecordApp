namespace StudentRecordApp
{
    partial class ViewStudentForm
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
            lblcmdGender = new Label();
            lbltxtAddress = new Label();
            lbldtBirthdate = new Label();
            lbltxtSurname = new Label();
            lbltxtFirstName = new Label();
            txtFirstname = new Label();
            txtSurname = new Label();
            dtBirthdate = new Label();
            cmbGender = new Label();
            txtAddress = new Label();
            lblStudentID = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblcmdGender
            // 
            lblcmdGender.Font = new Font("Segoe UI", 9.75F);
            lblcmdGender.Location = new Point(30, 149);
            lblcmdGender.Name = "lblcmdGender";
            lblcmdGender.Size = new Size(77, 23);
            lblcmdGender.TabIndex = 32;
            lblcmdGender.Text = "Gender";
            lblcmdGender.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltxtAddress
            // 
            lbltxtAddress.Font = new Font("Segoe UI", 9.75F);
            lbltxtAddress.Location = new Point(30, 178);
            lbltxtAddress.Name = "lbltxtAddress";
            lbltxtAddress.Size = new Size(77, 23);
            lbltxtAddress.TabIndex = 31;
            lbltxtAddress.Text = "Address";
            lbltxtAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbldtBirthdate
            // 
            lbldtBirthdate.Font = new Font("Segoe UI", 9.75F);
            lbldtBirthdate.Location = new Point(30, 118);
            lbldtBirthdate.Name = "lbldtBirthdate";
            lbldtBirthdate.Size = new Size(77, 23);
            lbldtBirthdate.TabIndex = 30;
            lbldtBirthdate.Text = "Birthdate";
            lbldtBirthdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltxtSurname
            // 
            lbltxtSurname.Font = new Font("Segoe UI", 9.75F);
            lbltxtSurname.Location = new Point(30, 89);
            lbltxtSurname.Name = "lbltxtSurname";
            lbltxtSurname.Size = new Size(77, 23);
            lbltxtSurname.TabIndex = 29;
            lbltxtSurname.Text = "Last Name";
            lbltxtSurname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltxtFirstName
            // 
            lbltxtFirstName.Font = new Font("Segoe UI", 9.75F);
            lbltxtFirstName.Location = new Point(30, 62);
            lbltxtFirstName.Name = "lbltxtFirstName";
            lbltxtFirstName.Size = new Size(77, 23);
            lbltxtFirstName.TabIndex = 28;
            lbltxtFirstName.Text = "First Name";
            lbltxtFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstname
            // 
            txtFirstname.BackColor = SystemColors.ControlLightLight;
            txtFirstname.Font = new Font("Segoe UI", 9.75F);
            txtFirstname.Location = new Point(124, 62);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(110, 23);
            txtFirstname.TabIndex = 34;
            txtFirstname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSurname
            // 
            txtSurname.BackColor = SystemColors.ControlLightLight;
            txtSurname.Font = new Font("Segoe UI", 9.75F);
            txtSurname.Location = new Point(124, 89);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(110, 23);
            txtSurname.TabIndex = 35;
            txtSurname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtBirthdate
            // 
            dtBirthdate.BackColor = SystemColors.ControlLightLight;
            dtBirthdate.Font = new Font("Segoe UI", 9.75F);
            dtBirthdate.Location = new Point(124, 118);
            dtBirthdate.Name = "dtBirthdate";
            dtBirthdate.Size = new Size(110, 23);
            dtBirthdate.TabIndex = 36;
            dtBirthdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = SystemColors.ControlLightLight;
            cmbGender.Font = new Font("Segoe UI", 9.75F);
            cmbGender.Location = new Point(124, 149);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(110, 23);
            cmbGender.TabIndex = 37;
            cmbGender.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.ControlLightLight;
            txtAddress.Font = new Font("Segoe UI", 9.75F);
            txtAddress.Location = new Point(124, 178);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(110, 23);
            txtAddress.TabIndex = 38;
            txtAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStudentID
            // 
            lblStudentID.Font = new Font("Segoe UI", 16F);
            lblStudentID.Location = new Point(124, 9);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(121, 43);
            lblStudentID.TabIndex = 39;
            lblStudentID.TextAlign = ContentAlignment.MiddleCenter;
            lblStudentID.Click += label1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 43);
            label1.TabIndex = 40;
            label1.Text = "StudentID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // ViewStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 239);
            Controls.Add(label1);
            Controls.Add(lblStudentID);
            Controls.Add(txtAddress);
            Controls.Add(cmbGender);
            Controls.Add(dtBirthdate);
            Controls.Add(txtSurname);
            Controls.Add(txtFirstname);
            Controls.Add(lblcmdGender);
            Controls.Add(lbltxtAddress);
            Controls.Add(lbldtBirthdate);
            Controls.Add(lbltxtSurname);
            Controls.Add(lbltxtFirstName);
            Name = "ViewStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudentForm";
            ResumeLayout(false);
        }

        #endregion
        private Label lblcmdGender;
        private Label lbltxtAddress;
        private Label lbldtBirthdate;
        private Label lbltxtSurname;
        private Label lbltxtFirstName;
        private Label txtFirstname;
        private Label txtSurname;
        private Label dtBirthdate;
        private Label cmbGender;
        private Label txtAddress;
        private Label lblStudentID;
        private Label label1;
    }
}