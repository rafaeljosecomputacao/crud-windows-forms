using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Students
{
    public partial class MainForm : Form
    {
        SqlConnection? sqlConnection;
        SqlCommand? sqlCommand;
        SqlDataAdapter? sqlAdapter;
        int id = 0;

        public MainForm()
        {
            InitializeComponent();
            DatabaseConnection();
            ViewData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Creating database connection
        private void DatabaseConnection()
        {
            ConnectionString connectionString = new ConnectionString();
            string sqlString = connectionString.GetConnectionString();

            sqlConnection = new SqlConnection(sqlString);

            // Attempt to connect to the database
            try
            {
                sqlConnection.Open();
                lblConnection.Text = "Connection: Connected to the database";
            }
            catch (Exception ex)
            {
                lblConnection.Text = $"Error: {ex.Message}";
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        // Fetching data for data grid view
        private void ViewData()
        {
            // Read
            string readSql = "SELECT * FROM students";
            sqlCommand = new SqlCommand(readSql, sqlConnection);

            // Attempt to connect to the database
            try
            {
                sqlConnection.Open();
                DataTable dataTable = new DataTable();
                sqlAdapter = new SqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dataTable);
                dgvStudents.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                lblConnection.Text = $"Error: {ex.Message}";
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        // Clearing all fields
        private void ClearFields()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtName.Focus();
        }

        // Creating new student
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Saving new student
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validating fields
            if (txtName.Text != "" && txtEmail.Text != "")
            {
                // Create
                string createSql = "INSERT INTO students(name,email) VALUES ('" + txtName.Text + "','" + txtEmail.Text + "')";
                sqlCommand = new SqlCommand(createSql, sqlConnection);

                // Attempt to connect to the database
                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Successfully created student");
                }
                catch (Exception ex)
                {
                    lblConnection.Text = $"Error: {ex.Message}";
                }
                finally
                {
                    sqlConnection.Close();
                    ViewData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Fill in all fields");
            }
        }

        // Filling in the text boxes when clicking on a line in data grid view
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Id for the update and delete operations
            id = Convert.ToInt32(dgvStudents.Rows[e.RowIndex].Cells[0].Value.ToString());
            // Clicked student name
            txtName.Text = dgvStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
            // Clicked student email
            txtEmail.Text = dgvStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        // Updating student
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validating fields
            if (txtEmail.Text != "" && txtEmail.Text != "")
            {
                // Update
                string updateSql = "UPDATE students SET name = '"+ txtName.Text + "', email = '" + txtEmail.Text + "' WHERE id = '" + id + "'";
                sqlCommand = new SqlCommand(updateSql, sqlConnection);

                // Attempt to connect to the database
                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated student");
                }
                catch (Exception ex)
                {
                    lblConnection.Text = $"Error: {ex.Message}";
                }
                finally
                {
                    sqlConnection.Close();
                    ViewData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Fill in all fields");
            }
        }
    }
}