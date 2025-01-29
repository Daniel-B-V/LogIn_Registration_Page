using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInPage
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vanjo\OneDrive\Documents\loginData.mdf;Integrated Security=True;Connect Timeout=30;Trust Server Certificate=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signin lForm = new Signin();
            lForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (SignInShowPass.Checked)
            {
                signUpPassword.PasswordChar = '\0';
            }
            else
            {
                signUpPassword.PasswordChar = '*';
            }
        }

        private void signInCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (signUpEmail.Text == "" || signUpUsername.Text == ""
                || signUpPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                        String checkUsername = "SELECT * FROM admin WHERE username = '"
                            + signUpUsername.Text.Trim() + "'"; //admin table

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connection))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show(signInUsername.Text + " is alraedy exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (email, username, passwords, date_created)" + "VALUES(@email, @username, @passwords, @date)";

                                DateTime dateTime = DateTime.Today;
                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@email", signUpEmail.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signUpUsername.Text.Trim());
                                    cmd.Parameters.AddWithValue("@passwords", signUpPassword.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", dateTime);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Log in successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Signin lform = new Signin();
                                    lform.Show();
                                    this.Hide();
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to database: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }

        }
    }
}
