using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Resturant_Management_System
{
    public partial class Customer : Form
    {
        string connectionString = "Data Source=SHEHAN-HP15S\\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void gobtn_Click(object sender, EventArgs e)
        {
            // Get customer name and telephone number from textboxes
            string customerName = cusname.Text;
            string telephoneNo = custelno.Text;

            // Insert into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Define the query with parameters to prevent SQL injection
                string query = "INSERT INTO customer (customer_name, telephone_no) VALUES (@customerName, @telephoneNo)";

                // Create SqlCommand object
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the query
                command.Parameters.AddWithValue("@customerName", customerName);
                command.Parameters.AddWithValue("@telephoneNo", telephoneNo);

                try
                {
                    // Open connection
                    connection.Open();

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer data saved successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save customer data!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }
    }
}
