﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Project
{
    public partial class Reservations : Form
    {
        string conn = "server=localhost;user id=root; password=rootpass; database=hotel";
        string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        int x, y, z, a;




        public Reservations()
        {
            InitializeComponent();
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "ddd dd MMM yyyy";
        }

        private void newcus_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "SELECT * FROM reservations ORDER BY room_id ASC, check_in ASC;\r\n";
                MySqlConnection myconn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(Query, myconn);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            y = int.Parse(daytext.Text.ToString());
            z = (x * y) / 10;

            try
            {
               
                string Query = "DELETE FROM reservations WHERE res_id = @id; INSERT into transactions(transaction_date,transaction_type,customer,amount,status) values('" + currentDate + "', 'CANCELLATION', @cus, @amount, 'CANCEL')";
                MySqlConnection MyConn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                
                MyCommand2.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                MyCommand2.Parameters.AddWithValue("@amount", z);
                MyCommand2.Parameters.AddWithValue("@cus", textBox2.Text);

                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reserve_Click(object sender, EventArgs e)
        {
           
            string room = comboBox1.SelectedItem.ToString();
            string currentTime = DateTime.Now.ToString("hh:mm:ss");
            DateTime inDateTime = dateTimePicker1.Value;
            string inDate = inDateTime.ToString("yyyy-MM-dd");

            int days = int.Parse(daytext.Text);

            DateTime outDateTime = inDateTime.AddDays(days);
            string outDate = outDateTime.ToString("yyyy-MM-dd");
            try
            {
                string Query = "insert into reservations(cus_id,room_id,check_in,check_out,res_date,res_time) values('" + this.textBox2.Text + "','" + room + "','" + inDate + "','" + outDate + "','" + currentDate + "','" + currentTime + "');";
                MySqlConnection myconn = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, myconn);
                MySqlDataReader MyReader2;
                myconn.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                myconn.Close();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                y = int.Parse(daytext.Text.ToString());
                a = x * y;
                string Query = "insert into transactions (transaction_date,transaction_type,customer,amount,status) values('" + currentDate + "',' RESERVATION ','" + textBox2.Text + "', @amount,'RESERVE');";
                MySqlConnection myconn = new MySqlConnection(conn);
                MySqlCommand MyCommand = new MySqlCommand(Query, myconn);
                MyCommand.Parameters.AddWithValue("@amount", a);
                MySqlDataReader MyReader;
                myconn.Open();
                MyReader = MyCommand.ExecuteReader();
                while (MyReader.Read())
                {
                }
                myconn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {

                case "301":
                    x = 1000;
                    break;
                case "302":
                    x = 700;
                    break;

                case "303":
                    x = 500;
                    break;
                case "304":
                    x = 1000;
                    break;
                case "305":
                    x = 500;
                    break;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "SELECT * FROM customer WHERE Lastname = @name;";
                MySqlConnection myconn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(Query, myconn);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
