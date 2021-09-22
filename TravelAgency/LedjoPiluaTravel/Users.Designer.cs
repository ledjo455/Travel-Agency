namespace LedjoPiluaTravel
{
    partial class Users
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
            this.travelDataSet4 = new LedjoPiluaTravel.travelDataSet4();
            this.userCredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userCredTableAdapter = new LedjoPiluaTravel.travelDataSet4TableAdapters.UserCredTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCredBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userCredBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(147, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(366, 347);
            this.dataGridView1.TabIndex = 1;
            // 
            // travelDataSet4
            // 
            this.travelDataSet4.DataSetName = "travelDataSet4";
            this.travelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userCredBindingSource
            // 
            this.userCredBindingSource.DataMember = "UserCred";
            this.userCredBindingSource.DataSource = this.travelDataSet4;
            // 
            // userCredTableAdapter
            // 
            this.userCredTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.Width = 150;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LedjoPiluaTravel.Properties.Resources.paris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1165, 655);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCredBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private travelDataSet4 travelDataSet4;
        private System.Windows.Forms.BindingSource userCredBindingSource;
        private travelDataSet4TableAdapters.UserCredTableAdapter userCredTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
    }
}