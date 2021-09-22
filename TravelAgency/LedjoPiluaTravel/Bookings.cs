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
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDataSet.TravelData' table. You can move, or remove it, as needed.
            this.travelDataTableAdapter.Fill(this.travelDataSet.TravelData);

        }
    }
}
