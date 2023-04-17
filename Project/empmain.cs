using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class empmain : Form
    {
        public empmain()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void transact_Click(object sender, EventArgs e)
        {
            Transactions trans = new Transactions();
            trans.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void customer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();  
            cus.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void reserve_Click(object sender, EventArgs e)
        {
            Reservations rsrv = new Reservations(); 
            rsrv.Show();
        }
    }
}
