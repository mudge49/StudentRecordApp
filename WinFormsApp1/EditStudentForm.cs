using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRecordApp
{

    public partial class EditStudentForm : Form
    {
        private int studentID;
        public EditStudentForm(int id)
        {
            InitializeComponent();
            studentID = id;
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            string query = "SELECT * FROM students WHERE StudentID=@ID";

            using (MySqlConnection conn = Database.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", studentID);
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtSurname.Text = reader["Surname"].ToString();
                        txtFirstname.Text = reader["Firstname"].ToString();
                        dtBirthdate.Value = Convert.ToDateTime(reader["Birthdate"]);
                        cmbGender.Text = reader["Gender"].ToString();
                        txtAddress.Text = reader["Address"].ToString();
                    }
                }
                conn.Close();
            }
        }

        private void lblAddStudentFormTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbltxtFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltxtSurname_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbldtBirthdate_Click(object sender, EventArgs e)
        {

        }

        private void dtBirthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblcmdGender_Click(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbltxtAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE students SET " +
                           "Surname=@Surname, Firstname=@Firstname, Birthdate=@Birthdate, " +
                           "Gender=@Gender, Address=@Address WHERE StudentID=@ID";

            using (MySqlConnection conn = Database.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", studentID);
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("@Birthdate", dtBirthdate.Value);
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Record updated successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
