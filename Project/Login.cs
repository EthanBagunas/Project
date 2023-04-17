using System;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace Project
{
    public partial class Login : Form
    {
        string connectionString = "server=localhost;user id=root; password=rootpass; database=staff_schema";


        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

       

        private void login1_Click(object sender, EventArgs e)
        {
            //Transactions transactions = new Transactions();
            //transactions.Show();

            empmain emp= new empmain();
            emp.Show();
            /*
            string query = "SELECT * FROM employee WHERE empname=@username AND emppass=@password";

            MySqlConnection conn = new MySqlConnection(connectionString);
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
            conn.Close();*/
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


    }
}