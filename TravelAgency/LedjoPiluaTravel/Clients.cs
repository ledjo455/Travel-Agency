﻿using System;
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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDataSet3.ClientData' table. You can move, or remove it, as needed.
            this.clientDataTableAdapter.Fill(this.travelDataSet3.ClientData);

        }
    }
}
