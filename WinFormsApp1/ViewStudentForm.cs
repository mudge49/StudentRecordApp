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
    public partial class ViewStudentForm : Form
    {
        private int studentID;
        public ViewStudentForm(int id)
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
                        lblStudentID.Text = reader["StudentID"].ToString();
                        txtSurname.Text = reader["Surname"].ToString();
                        txtFirstname.Text = reader["Firstname"].ToString();
                        dtBirthdate.Text = reader["Birthdate"].ToString();
                        cmbGender.Text = reader["Gender"].ToString();
                        txtAddress.Text = reader["Address"].ToString();
                    }
                }
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
