using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO students (Surname, Firstname, Birthdate, Gender, Address) " +
                           "VALUES (@Surname, @Firstname, @Birthdate, @Gender, @Address)";

            using (MySqlConnection conn = Database.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("@Birthdate", dtBirthdate.Value);
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Student record added!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
