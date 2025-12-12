using MySql.Data.MySqlClient;
using StudentRecordApp;
using System.Data;
using System.Xml.XPath;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadStudents();
        }
        private void LoadStudents()
        {
            string query = "SELECT * FROM students";

            using (MySqlConnection conn = Database.GetConnection())
            using (MySqlDataAdapter adp = new MySqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    dataGridViewStudents.Visible = false;
                    lblNoData.Visible = true;
                    return;
                }

                dataGridViewStudents.Visible = true;
                lblNoData.Visible = false;
                dataGridViewStudents.DataSource = dt;
            }
        }
        private int GetSelectedStudentID()
        {
            if (dataGridViewStudents.SelectedRows.Count == 0)
                return -1;

            DataGridViewRow row = dataGridViewStudents.SelectedRows[0];
            return Convert.ToInt32(row.Cells["StudentID"].Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadStudents();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = GetSelectedStudentID();

            if (id == -1)
            {
                MessageBox.Show("Please select a record by clicking on a row.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            string query = "DELETE FROM students WHERE StudentID=@ID";

            using (MySqlConnection conn = Database.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Record deleted successfully!");
            LoadStudents();

        }

        private bool sortAscending = true;

        private void button4_Click(object sender, EventArgs e)
        {
            string order = sortAscending ? "ASC" : "DESC";
            string query = $"SELECT * FROM students ORDER BY Surname {order}";

            using (MySqlConnection conn = Database.GetConnection())
            using (MySqlDataAdapter adp = new MySqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dataGridViewStudents.DataSource = dt;
                dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            sortAscending = !sortAscending;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditClick_Click(object sender, EventArgs e)
        {
            int id = GetSelectedStudentID();

            if (id == -1)
            {
                MessageBox.Show("Please select a record by clicking on a row.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditStudentForm editForm = new EditStudentForm(id);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadStudents();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = GetSelectedStudentID();

            if (id == -1)
            {
                MessageBox.Show("Please select a record by clicking on a row.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ViewStudentForm viewForm = new ViewStudentForm(id);

            if (viewForm.ShowDialog() == DialogResult.OK)
            {
                LoadStudents();
            }
        }
    }
}
