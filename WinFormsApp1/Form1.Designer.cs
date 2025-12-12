namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewStudents = new DataGridView();
            btnAddClick = new Button();
            btnEditClick = new Button();
            btnDeleteClick = new Button();
            btnSortClick = new Button();
            lblNoData = new Label();
            lblTitle = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(12, 83);
            dataGridViewStudents.MultiSelect = false;
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.Size = new Size(731, 322);
            dataGridViewStudents.TabIndex = 1;
            // 
            // btnAddClick
            // 
            btnAddClick.Location = new Point(37, 425);
            btnAddClick.Name = "btnAddClick";
            btnAddClick.Size = new Size(99, 45);
            btnAddClick.TabIndex = 2;
            btnAddClick.Text = "Add";
            btnAddClick.UseVisualStyleBackColor = true;
            btnAddClick.Click += button1_Click;
            // 
            // btnEditClick
            // 
            btnEditClick.Location = new Point(181, 425);
            btnEditClick.Name = "btnEditClick";
            btnEditClick.Size = new Size(99, 45);
            btnEditClick.TabIndex = 3;
            btnEditClick.Text = "Edit";
            btnEditClick.UseVisualStyleBackColor = true;
            btnEditClick.Click += btnEditClick_Click;
            // 
            // btnDeleteClick
            // 
            btnDeleteClick.Location = new Point(334, 425);
            btnDeleteClick.Name = "btnDeleteClick";
            btnDeleteClick.Size = new Size(99, 45);
            btnDeleteClick.TabIndex = 4;
            btnDeleteClick.Text = "Delete";
            btnDeleteClick.UseVisualStyleBackColor = true;
            btnDeleteClick.Click += button3_Click;
            // 
            // btnSortClick
            // 
            btnSortClick.Location = new Point(605, 425);
            btnSortClick.Name = "btnSortClick";
            btnSortClick.Size = new Size(99, 45);
            btnSortClick.TabIndex = 5;
            btnSortClick.Text = "Sort";
            btnSortClick.UseVisualStyleBackColor = true;
            btnSortClick.Click += button4_Click;
            // 
            // lblNoData
            // 
            lblNoData.BackColor = SystemColors.AppWorkspace;
            lblNoData.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoData.Location = new Point(12, 83);
            lblNoData.Name = "lblNoData";
            lblNoData.Size = new Size(731, 322);
            lblNoData.TabIndex = 6;
            lblNoData.Text = "No data found";
            lblNoData.TextAlign = ContentAlignment.MiddleCenter;
            lblNoData.Visible = false;
            lblNoData.Click += label1_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = SystemColors.ButtonShadow;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(731, 47);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Student Records";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(472, 425);
            button1.Name = "button1";
            button1.Size = new Size(99, 45);
            button1.TabIndex = 8;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(755, 495);
            Controls.Add(button1);
            Controls.Add(lblTitle);
            Controls.Add(lblNoData);
            Controls.Add(btnSortClick);
            Controls.Add(btnDeleteClick);
            Controls.Add(btnEditClick);
            Controls.Add(btnAddClick);
            Controls.Add(dataGridViewStudents);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Record Management System";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewStudents;
        private Button btnAddClick;
        private Button btnEditClick;
        private Button btnDeleteClick;
        private Button btnSortClick;
        private Label lblNoData;
        private Label lblTitle;
        private Button button1;
    }
}
