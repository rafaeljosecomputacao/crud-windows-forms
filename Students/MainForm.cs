using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Students
{
    public partial class MainForm : Form
    {
        SqlConnection ?sqlConnection;
        SqlCommand ?sqlCommand;
        SqlDataAdapter ?sqlAdapter;

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
                lblConnection.Text += "Connected to the database";
            }
            catch (Exception ex)
            {
                lblConnection.Text += $"Error: {ex.Message}";
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
                lblConnection.Text += $"Error: {ex.Message}";
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}