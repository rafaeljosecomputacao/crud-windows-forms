using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Students
{
    public partial class MainForm : Form
    {
        SqlConnection ?sqlConnection;

        public MainForm()
        {
            InitializeComponent();
            DatabaseConnection();           
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
    }
}