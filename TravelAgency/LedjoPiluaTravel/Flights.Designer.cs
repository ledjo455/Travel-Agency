namespace LedjoPiluaTravel
{
    partial class Flights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.travelDataSet = new LedjoPiluaTravel.travelDataSet();
            this.travelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDataSet1 = new LedjoPiluaTravel.travelDataSet1();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightTableAdapter = new LedjoPiluaTravel.travelDataSet1TableAdapters.FlightTableAdapter();
            this.flightIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureAirportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationAirportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerFlightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightIDDataGridViewTextBoxColumn,
            this.departureAirportDataGridViewTextBoxColumn,
            this.destinationAirportDataGridViewTextBoxColumn,
            this.departureDateDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.flightNameDataGridViewTextBoxColumn,
            this.pricePerFlightDataGridViewTextBoxColumn,
            this.statusIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 515);
            this.dataGridView1.TabIndex = 0;
            // 
            // travelDataSet
            // 
            this.travelDataSet.DataSetName = "travelDataSet";
            this.travelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // travelDataSetBindingSource
            // 
            this.travelDataSetBindingSource.DataSource = this.travelDataSet;
            this.travelDataSetBindingSource.Position = 0;
            // 
            // travelDataSet1
            // 
            this.travelDataSet1.DataSetName = "travelDataSet1";
            this.travelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "Flight";
            this.flightBindingSource.DataSource = this.travelDataSet1;
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // flightIDDataGridViewTextBoxColumn
            // 
            this.flightIDDataGridViewTextBoxColumn.DataPropertyName = "FlightID";
            this.flightIDDataGridViewTextBoxColumn.HeaderText = "FlightID";
            this.flightIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.flightIDDataGridViewTextBoxColumn.Name = "flightIDDataGridViewTextBoxColumn";
            this.flightIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // departureAirportDataGridViewTextBoxColumn
            // 
            this.departureAirportDataGridViewTextBoxColumn.DataPropertyName = "DepartureAirport";
            this.departureAirportDataGridViewTextBoxColumn.HeaderText = "DepartureAirport";
            this.departureAirportDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departureAirportDataGridViewTextBoxColumn.Name = "departureAirportDataGridViewTextBoxColumn";
            this.departureAirportDataGridViewTextBoxColumn.Width = 150;
            // 
            // destinationAirportDataGridViewTextBoxColumn
            // 
            this.destinationAirportDataGridViewTextBoxColumn.DataPropertyName = "DestinationAirport";
            this.destinationAirportDataGridViewTextBoxColumn.HeaderText = "DestinationAirport";
            this.destinationAirportDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.destinationAirportDataGridViewTextBoxColumn.Name = "destinationAirportDataGridViewTextBoxColumn";
            this.destinationAirportDataGridViewTextBoxColumn.Width = 150;
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            this.departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.HeaderText = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            this.departureDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            this.arrivalDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // flightNameDataGridViewTextBoxColumn
            // 
            this.flightNameDataGridViewTextBoxColumn.DataPropertyName = "FlightName";
            this.flightNameDataGridViewTextBoxColumn.HeaderText = "FlightName";
            this.flightNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.flightNameDataGridViewTextBoxColumn.Name = "flightNameDataGridViewTextBoxColumn";
            this.flightNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // pricePerFlightDataGridViewTextBoxColumn
            // 
            this.pricePerFlightDataGridViewTextBoxColumn.DataPropertyName = "PricePerFlight";
            this.pricePerFlightDataGridViewTextBoxColumn.HeaderText = "PricePerFlight";
            this.pricePerFlightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pricePerFlightDataGridViewTextBoxColumn.Name = "pricePerFlightDataGridViewTextBoxColumn";
            this.pricePerFlightDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusIDDataGridViewTextBoxColumn
            // 
            this.statusIDDataGridViewTextBoxColumn.DataPropertyName = "StatusID";
            this.statusIDDataGridViewTextBoxColumn.HeaderText = "StatusID";
            this.statusIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusIDDataGridViewTextBoxColumn.Name = "statusIDDataGridViewTextBoxColumn";
            this.statusIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LedjoPiluaTravel.Properties.Resources.IMG_1514;
            this.ClientSize = new System.Drawing.Size(1165, 655);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Flights";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource travelDataSetBindingSource;
        private travelDataSet travelDataSet;
        private travelDataSet1 travelDataSet1;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private travelDataSet1TableAdapters.FlightTableAdapter flightTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureAirportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationAirportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerFlightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusIDDataGridViewTextBoxColumn;
    }
}