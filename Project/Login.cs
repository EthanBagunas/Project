using System;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace Project
{
    public partial class Login : Form
    {

        public string connstring = "server=localhost;user id=root; password=rootpass; database=hotel";


        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }



        private void login1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("admin") && textBox2.Text.Contains("admin"))
            {
                admin admin = new admin();
                admin.Show();
            }
            else
            {
                string query = "SELECT * FROM employee WHERE empfirst=@username AND password=@password";
                MySqlConnection conn = new MySqlConnection(connstring);
                MySqlCommand command = new MySqlCommand(query, conn);

                conn.Open();
                command.Parameters.AddWithValue("@username", textBox1.Text);
                command.Parameters.AddWithValue("@password", textBox2.Text);


                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    textBox1.Clear();
                    textBox2.Clear();

                    this.Hide();
                    empmain form2 = new empmain();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                conn.Close();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Show the password
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide the password
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}