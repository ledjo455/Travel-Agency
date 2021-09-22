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
    public partial class Flights : Form
    {
        public Flights()
        {
            InitializeComponent();
        }

        private void Flights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDataSet1.Flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter.Fill(this.travelDataSet1.Flight);

        }
    }
}
