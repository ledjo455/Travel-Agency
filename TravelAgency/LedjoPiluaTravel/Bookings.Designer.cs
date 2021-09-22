namespace LedjoPiluaTravel
{
    partial class Bookings
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
            this.travelDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDataTableAdapter = new LedjoPiluaTravel.travelDataSetTableAdapters.TravelDataTableAdapter();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destFlightIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrFlightIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfNightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.destFlightIDDataGridViewTextBoxColumn,
            this.arrFlightIDDataGridViewTextBoxColumn,
            this.hotelIDDataGridViewTextBoxColumn,
            this.fullPriceDataGridViewTextBoxColumn,
            this.numberOfNightsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.travelDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1170, 644);
            this.dataGridView1.TabIndex = 0;
            // 
            // travelDataSet
            // 
            this.travelDataSet.DataSetName = "travelDataSet";
            this.travelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // travelDataBindingSource
            // 
            this.travelDataBindingSource.DataMember = "TravelData";
            this.travelDataBindingSource.DataSource = this.travelDataSet;
            // 
            // travelDataTableAdapter
            // 
            this.travelDataTableAdapter.ClearBeforeFill = true;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // destFlightIDDataGridViewTextBoxColumn
            // 
            this.destFlightIDDataGridViewTextBoxColumn.DataPropertyName = "DestFlightID";
            this.destFlightIDDataGridViewTextBoxColumn.HeaderText = "DestFlightID";
            this.destFlightIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.destFlightIDDataGridViewTextBoxColumn.Name = "destFlightIDDataGridViewTextBoxColumn";
            this.destFlightIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // arrFlightIDDataGridViewTextBoxColumn
            // 
            this.arrFlightIDDataGridViewTextBoxColumn.DataPropertyName = "ArrFlightID";
            this.arrFlightIDDataGridViewTextBoxColumn.HeaderText = "ArrFlightID";
            this.arrFlightIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.arrFlightIDDataGridViewTextBoxColumn.Name = "arrFlightIDDataGridViewTextBoxColumn";
            this.arrFlightIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // hotelIDDataGridViewTextBoxColumn
            // 
            this.hotelIDDataGridViewTextBoxColumn.DataPropertyName = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.HeaderText = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hotelIDDataGridViewTextBoxColumn.Name = "hotelIDDataGridViewTextBoxColumn";
            this.hotelIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // fullPriceDataGridViewTextBoxColumn
            // 
            this.fullPriceDataGridViewTextBoxColumn.DataPropertyName = "FullPrice";
            this.fullPriceDataGridViewTextBoxColumn.HeaderText = "FullPrice";
            this.fullPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fullPriceDataGridViewTextBoxColumn.Name = "fullPriceDataGridViewTextBoxColumn";
            this.fullPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberOfNightsDataGridViewTextBoxColumn
            // 
            this.numberOfNightsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfNights";
            this.numberOfNightsDataGridViewTextBoxColumn.HeaderText = "NumberOfNights";
            this.numberOfNightsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberOfNightsDataGridViewTextBoxColumn.Name = "numberOfNightsDataGridViewTextBoxColumn";
            this.numberOfNightsDataGridViewTextBoxColumn.Width = 150;
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 655);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bookings";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.Bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private travelDataSet travelDataSet;
        private System.Windows.Forms.BindingSource travelDataBindingSource;
        private travelDataSetTableAdapters.TravelDataTableAdapter travelDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destFlightIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrFlightIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfNightsDataGridViewTextBoxColumn;
    }
}