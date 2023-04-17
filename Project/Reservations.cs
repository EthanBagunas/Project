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
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void Reservations_Load(object sender, EventArgs e)
        {

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
    }
}
