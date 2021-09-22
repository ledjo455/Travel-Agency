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
    public partial class Hotels : Form
    {
        public Hotels()
        {
            InitializeComponent();
        }

        private void Hotels_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDataSet2.Hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter.Fill(this.travelDataSet2.Hotel);

        }
    }
}
