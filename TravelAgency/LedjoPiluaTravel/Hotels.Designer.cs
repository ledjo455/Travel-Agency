namespace LedjoPiluaTravel
{
    partial class Hotels
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
            this.travelDataSet2 = new LedjoPiluaTravel.travelDataSet2();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelTableAdapter = new LedjoPiluaTravel.travelDataSet2TableAdapters.HotelTableAdapter();
            this.hotelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationAirportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerNightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotelIDDataGridViewTextBoxColumn,
            this.destinationAirportDataGridViewTextBoxColumn,
            this.hotelNameDataGridViewTextBoxColumn,
            this.pricePerNightDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hotelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(154, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(835, 553);
            this.dataGridView1.TabIndex = 1;
            // 
            // travelDataSet2
            // 
            this.travelDataSet2.DataSetName = "travelDataSet2";
            this.travelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.travelDataSet2;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // hotelIDDataGridViewTextBoxColumn
            // 
            this.hotelIDDataGridViewTextBoxColumn.DataPropertyName = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.HeaderText = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hotelIDDataGridViewTextBoxColumn.Name = "hotelIDDataGridViewTextBoxColumn";
            this.hotelIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // destinationAirportDataGridViewTextBoxColumn
            // 
            this.destinationAirportDataGridViewTextBoxColumn.DataPropertyName = "DestinationAirport";
            this.destinationAirportDataGridViewTextBoxColumn.HeaderText = "DestinationAirport";
            this.destinationAirportDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.destinationAirportDataGridViewTextBoxColumn.Name = "destinationAirportDataGridViewTextBoxColumn";
            this.destinationAirportDataGridViewTextBoxColumn.Width = 150;
            // 
            // hotelNameDataGridViewTextBoxColumn
            // 
            this.hotelNameDataGridViewTextBoxColumn.DataPropertyName = "HotelName";
            this.hotelNameDataGridViewTextBoxColumn.HeaderText = "HotelName";
            this.hotelNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hotelNameDataGridViewTextBoxColumn.Name = "hotelNameDataGridViewTextBoxColumn";
            this.hotelNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // pricePerNightDataGridViewTextBoxColumn
            // 
            this.pricePerNightDataGridViewTextBoxColumn.DataPropertyName = "PricePerNight";
            this.pricePerNightDataGridViewTextBoxColumn.HeaderText = "PricePerNight";
            this.pricePerNightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pricePerNightDataGridViewTextBoxColumn.Name = "pricePerNightDataGridViewTextBoxColumn";
            this.pricePerNightDataGridViewTextBoxColumn.Width = 150;
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LedjoPiluaTravel.Properties.Resources.hotel;
            this.ClientSize = new System.Drawing.Size(1165, 655);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Hotels";
            this.Text = "Hotels";
            this.Load += new System.EventHandler(this.Hotels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private travelDataSet2 travelDataSet2;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private travelDataSet2TableAdapters.HotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationAirportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerNightDataGridViewTextBoxColumn;
    }
}