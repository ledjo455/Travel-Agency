using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedjoPiluaTravel
{
    public partial class Datadashboard : Form
    {
        public Datadashboard()
        {
            InitializeComponent();
        }

        private void AccessData_Load(object sender, EventArgs e)
        {

        }

        private void bookingsdatabtn_Click(object sender, EventArgs e)
        {
            Bookings bb = new Bookings();
            bb.Show();
        }

        private void accessDataBtn_Click(object sender, EventArgs e)
        {
            Flights flights = new Flights();
            flights.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Hotels_Click(object sender, EventArgs e)
        {
            Hotels hotels = new Hotels();
            hotels.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();
        }
    }
}
