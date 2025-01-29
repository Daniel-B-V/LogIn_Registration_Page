using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace LogInPage
{
    public partial class Signin : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vanjo\OneDrive\Documents\loginData.mdf;Integrated Security=True;Connect Timeout=30;Trust Server Certificate=True");

        public Signin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signUpGoBack_Click(object sender, EventArgs e)
        {
            Form1 sform = new Form1();
            sform.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logInCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (logInEmail.Text == "" || logInUsername.Text == "" || logInPassword.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        String selectData = "SELECT * FROM admin WHERE email = @email AND username = @username AND passwords = @passwords";
                        using (SqlCommand cmd = new SqlCommand(selectData, connection))
                        {
                            cmd.Parameters.AddWithValue("@email", logInEmail.Text);
                            cmd.Parameters.AddWithValue("@username", logInUsername.Text);
                            cmd.Parameters.AddWithValue("@passwords", logInPassword.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if(dataTable.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged in successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                WelcomePage welcomePage = new WelcomePage();
                                welcomePage.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Email/Username/Password please check your info", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        private void logInShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (logInShowPass.Checked)
            {
                logInPassword.PasswordChar = '\0';
            }else
            {
                logInPassword.PasswordChar = '*';
            }
        }
    }
}
