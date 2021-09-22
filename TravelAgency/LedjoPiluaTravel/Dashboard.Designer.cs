using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LedjoPiluaTravel
{
    partial class Dashboard
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveHotel = new System.Windows.Forms.Button();
            this.txtHotelPriceNight = new System.Windows.Forms.TextBox();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.txtDestHotelAirp = new System.Windows.Forms.TextBox();
            this.txtHotelID = new System.Windows.Forms.TextBox();
            this.namewh = new System.Windows.Forms.Label();
            this.airportlabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtstatusid = new System.Windows.Forms.TextBox();
            this.txtflightprice = new System.Windows.Forms.TextBox();
            this.txtflightname = new System.Windows.Forms.TextBox();
            this.txtorigAirport = new System.Windows.Forms.TextBox();
            this.txtDestAirport = new System.Windows.Forms.TextBox();
            this.txtflightid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveDataBtnNewClient = new System.Windows.Forms.Button();
            this.comboBoxClientType = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveBooking = new System.Windows.Forms.Button();
            this.comboboxhotelid = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.comboBoxarrivalflightid = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.comboBoxdestflightid = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textFullPrice = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.comboHotelName = new System.Windows.Forms.ComboBox();
            this.comboArrivalFlight = new System.Windows.Forms.ComboBox();
            this.combodestflight = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboclientid = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.accessDataBtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "New Client";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(183, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Book Trip";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(365, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Flight";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(554, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add Hotel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(1033, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 51);
            this.button4.TabIndex = 6;
            this.button4.Text = "Log Out";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::LedjoPiluaTravel.Properties.Resources.hoteli;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btnSaveHotel);
            this.panel3.Controls.Add(this.txtHotelPriceNight);
            this.panel3.Controls.Add(this.txtHotelName);
            this.panel3.Controls.Add(this.txtDestHotelAirp);
            this.panel3.Controls.Add(this.txtHotelID);
            this.panel3.Controls.Add(this.namewh);
            this.panel3.Controls.Add(this.airportlabel);
            this.panel3.Controls.Add(this.pricelabel);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Location = new System.Drawing.Point(12, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1141, 544);
            this.panel3.TabIndex = 22;
            // 
            // btnSaveHotel
            // 
            this.btnSaveHotel.BackColor = System.Drawing.SystemColors.Info;
            this.btnSaveHotel.Location = new System.Drawing.Point(711, 433);
            this.btnSaveHotel.Name = "btnSaveHotel";
            this.btnSaveHotel.Size = new System.Drawing.Size(145, 47);
            this.btnSaveHotel.TabIndex = 31;
            this.btnSaveHotel.Text = "Save";
            this.btnSaveHotel.UseVisualStyleBackColor = false;
            this.btnSaveHotel.Click += new System.EventHandler(this.btnSaveHotel_Click);
            // 
            // txtHotelPriceNight
            // 
            this.txtHotelPriceNight.BackColor = System.Drawing.SystemColors.Info;
            this.txtHotelPriceNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotelPriceNight.Location = new System.Drawing.Point(673, 305);
            this.txtHotelPriceNight.Name = "txtHotelPriceNight";
            this.txtHotelPriceNight.Size = new System.Drawing.Size(183, 35);
            this.txtHotelPriceNight.TabIndex = 30;
            // 
            // txtHotelName
            // 
            this.txtHotelName.BackColor = System.Drawing.SystemColors.Info;
            this.txtHotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotelName.Location = new System.Drawing.Point(673, 131);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(290, 35);
            this.txtHotelName.TabIndex = 29;
            // 
            // txtDestHotelAirp
            // 
            this.txtDestHotelAirp.BackColor = System.Drawing.SystemColors.Info;
            this.txtDestHotelAirp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestHotelAirp.Location = new System.Drawing.Point(201, 302);
            this.txtDestHotelAirp.Name = "txtDestHotelAirp";
            this.txtDestHotelAirp.Size = new System.Drawing.Size(183, 35);
            this.txtDestHotelAirp.TabIndex = 28;
            // 
            // txtHotelID
            // 
            this.txtHotelID.BackColor = System.Drawing.SystemColors.Info;
            this.txtHotelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotelID.Location = new System.Drawing.Point(201, 137);
            this.txtHotelID.Name = "txtHotelID";
            this.txtHotelID.Size = new System.Drawing.Size(183, 35);
            this.txtHotelID.TabIndex = 27;
            // 
            // namewh
            // 
            this.namewh.AutoSize = true;
            this.namewh.BackColor = System.Drawing.SystemColors.Info;
            this.namewh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namewh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.namewh.Location = new System.Drawing.Point(507, 135);
            this.namewh.Name = "namewh";
            this.namewh.Size = new System.Drawing.Size(89, 29);
            this.namewh.TabIndex = 26;
            this.namewh.Text = "Name:";
            // 
            // airportlabel
            // 
            this.airportlabel.AutoSize = true;
            this.airportlabel.BackColor = System.Drawing.SystemColors.Info;
            this.airportlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.airportlabel.Location = new System.Drawing.Point(58, 308);
            this.airportlabel.Name = "airportlabel";
            this.airportlabel.Size = new System.Drawing.Size(119, 29);
            this.airportlabel.TabIndex = 25;
            this.airportlabel.Text = "Location:";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.BackColor = System.Drawing.SystemColors.Info;
            this.pricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pricelabel.Location = new System.Drawing.Point(473, 311);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(146, 29);
            this.pricelabel.TabIndex = 24;
            this.pricelabel.Text = "Price/night:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.Info;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(58, 138);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(114, 29);
            this.label22.TabIndex = 23;
            this.label22.Text = "Hotel ID:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.Info;
            this.label21.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label21.Font = new System.Drawing.Font("Ink Free", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(431, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(214, 54);
            this.label21.TabIndex = 22;
            this.label21.Text = "Add Hotel";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::LedjoPiluaTravel.Properties.Resources.IMG_1514;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.dateTimePicker4);
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.txtstatusid);
            this.panel2.Controls.Add(this.txtflightprice);
            this.panel2.Controls.Add(this.txtflightname);
            this.panel2.Controls.Add(this.txtorigAirport);
            this.panel2.Controls.Add(this.txtDestAirport);
            this.panel2.Controls.Add(this.txtflightid);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(12, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 534);
            this.panel2.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Info;
            this.label20.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label20.Font = new System.Drawing.Font("Ink Free", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(359, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(231, 54);
            this.label20.TabIndex = 21;
            this.label20.Text = "Add Flight";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(693, 420);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker4.TabIndex = 20;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(247, 420);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker3.TabIndex = 19;
            this.dateTimePicker3.Value = new System.DateTime(2020, 6, 25, 22, 46, 0, 0);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(518, 420);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(161, 29);
            this.label19.TabIndex = 18;
            this.label19.Text = "Arrival Time:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(38, 420);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(203, 29);
            this.label18.TabIndex = 17;
            this.label18.Text = "Departure Time:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-mm-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(685, 340);
            this.dateTimePicker2.MinDate = new System.DateTime(2020, 6, 13, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(187, 35);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-mm-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 339);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 6, 13, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 35);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(524, 340);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 29);
            this.label17.TabIndex = 14;
            this.label17.Text = "Arrival Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(88, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 29);
            this.label16.TabIndex = 13;
            this.label16.Text = "Origin Date:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Location = new System.Drawing.Point(888, 471);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 47);
            this.button5.TabIndex = 12;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtstatusid
            // 
            this.txtstatusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatusid.Location = new System.Drawing.Point(688, 264);
            this.txtstatusid.Name = "txtstatusid";
            this.txtstatusid.Size = new System.Drawing.Size(188, 35);
            this.txtstatusid.TabIndex = 11;
            // 
            // txtflightprice
            // 
            this.txtflightprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtflightprice.Location = new System.Drawing.Point(693, 200);
            this.txtflightprice.Name = "txtflightprice";
            this.txtflightprice.Size = new System.Drawing.Size(188, 35);
            this.txtflightprice.TabIndex = 10;
            // 
            // txtflightname
            // 
            this.txtflightname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtflightname.Location = new System.Drawing.Point(693, 135);
            this.txtflightname.Name = "txtflightname";
            this.txtflightname.Size = new System.Drawing.Size(188, 35);
            this.txtflightname.TabIndex = 9;
            // 
            // txtorigAirport
            // 
            this.txtorigAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorigAirport.Location = new System.Drawing.Point(247, 203);
            this.txtorigAirport.Name = "txtorigAirport";
            this.txtorigAirport.Size = new System.Drawing.Size(188, 35);
            this.txtorigAirport.TabIndex = 8;
            // 
            // txtDestAirport
            // 
            this.txtDestAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestAirport.Location = new System.Drawing.Point(247, 267);
            this.txtDestAirport.Name = "txtDestAirport";
            this.txtDestAirport.Size = new System.Drawing.Size(188, 35);
            this.txtDestAirport.TabIndex = 7;
            this.txtDestAirport.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtflightid
            // 
            this.txtflightid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtflightid.Location = new System.Drawing.Point(247, 138);
            this.txtflightid.Name = "txtflightid";
            this.txtflightid.Size = new System.Drawing.Size(188, 35);
            this.txtflightid.TabIndex = 6;
            this.txtflightid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(71, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 29);
            this.label15.TabIndex = 5;
            this.label15.Text = "Origin Airport:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(464, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 29);
            this.label14.TabIndex = 4;
            this.label14.Text = "Price Per Flight: $";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(236, 29);
            this.label13.TabIndex = 3;
            this.label13.Text = "Destination Airport:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(562, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 29);
            this.label12.TabIndex = 2;
            this.label12.Text = "StatusID:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(525, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "Flight Name:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(130, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "FlightID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BackgroundImage = global::LedjoPiluaTravel.Properties.Resources.paris1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.SaveDataBtnNewClient);
            this.panel1.Controls.Add(this.comboBoxClientType);
            this.panel1.Controls.Add(this.comboBoxGender);
            this.panel1.Controls.Add(this.txtNationality);
            this.panel1.Controls.Add(this.txtCID);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 534);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SaveDataBtnNewClient
            // 
            this.SaveDataBtnNewClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SaveDataBtnNewClient.Location = new System.Drawing.Point(493, 382);
            this.SaveDataBtnNewClient.Name = "SaveDataBtnNewClient";
            this.SaveDataBtnNewClient.Size = new System.Drawing.Size(145, 47);
            this.SaveDataBtnNewClient.TabIndex = 17;
            this.SaveDataBtnNewClient.Text = "Save Data";
            this.SaveDataBtnNewClient.UseVisualStyleBackColor = false;
            this.SaveDataBtnNewClient.Click += new System.EventHandler(this.SaveDataBtnNewClient_Click);
            // 
            // comboBoxClientType
            // 
            this.comboBoxClientType.FormattingEnabled = true;
            this.comboBoxClientType.Items.AddRange(new object[] {
            "Regular",
            "Vip",
            "Platinum"});
            this.comboBoxClientType.Location = new System.Drawing.Point(644, 230);
            this.comboBoxClientType.Name = "comboBoxClientType";
            this.comboBoxClientType.Size = new System.Drawing.Size(147, 28);
            this.comboBoxClientType.TabIndex = 16;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBoxGender.Location = new System.Drawing.Point(644, 122);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(147, 28);
            this.comboBoxGender.TabIndex = 15;
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(644, 179);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(147, 26);
            this.txtNationality.TabIndex = 14;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(106, 44);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(147, 26);
            this.txtCID.TabIndex = 13;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(185, 289);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(147, 26);
            this.txtAge.TabIndex = 12;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(185, 238);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(147, 26);
            this.txtNumber.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(185, 192);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(147, 26);
            this.txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(185, 135);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(147, 26);
            this.txtFirstName.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Client Type:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nationality:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Client";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LedjoPiluaTravel.Properties.Resources._1287373;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1164, 660);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.Info;
            this.label23.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label23.Font = new System.Drawing.Font("Ink Free", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label23.Location = new System.Drawing.Point(429, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(271, 54);
            this.label23.TabIndex = 23;
            this.label23.Text = "New Booking";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Info;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(13, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(148, 29);
            this.label24.TabIndex = 24;
            this.label24.Text = "Booking ID:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(184, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 35);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSaveBooking);
            this.panel4.Controls.Add(this.comboboxhotelid);
            this.panel4.Controls.Add(this.label34);
            this.panel4.Controls.Add(this.comboBoxarrivalflightid);
            this.panel4.Controls.Add(this.label33);
            this.panel4.Controls.Add(this.comboBoxdestflightid);
            this.panel4.Controls.Add(this.label32);
            this.panel4.Controls.Add(this.textFullPrice);
            this.panel4.Controls.Add(this.txtnights);
            this.panel4.Controls.Add(this.comboHotelName);
            this.panel4.Controls.Add(this.comboArrivalFlight);
            this.panel4.Controls.Add(this.combodestflight);
            this.panel4.Controls.Add(this.label31);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.comboclientid);
            this.panel4.Controls.Add(this.label30);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Location = new System.Drawing.Point(-1, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1164, 547);
            this.panel4.TabIndex = 32;
            // 
            // btnSaveBooking
            // 
            this.btnSaveBooking.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveBooking.Location = new System.Drawing.Point(464, 474);
            this.btnSaveBooking.Name = "btnSaveBooking";
            this.btnSaveBooking.Size = new System.Drawing.Size(145, 47);
            this.btnSaveBooking.TabIndex = 50;
            this.btnSaveBooking.Text = "Save";
            this.btnSaveBooking.UseVisualStyleBackColor = false;
            this.btnSaveBooking.Click += new System.EventHandler(this.btnSaveBooking_Click_1);
            // 
            // comboboxhotelid
            // 
            this.comboboxhotelid.BackColor = System.Drawing.SystemColors.Info;
            this.comboboxhotelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxhotelid.FormattingEnabled = true;
            this.comboboxhotelid.Location = new System.Drawing.Point(824, 290);
            this.comboboxhotelid.Name = "comboboxhotelid";
            this.comboboxhotelid.Size = new System.Drawing.Size(134, 37);
            this.comboboxhotelid.TabIndex = 49;
            this.comboboxhotelid.SelectedIndexChanged += new System.EventHandler(this.comboboxhotelid_SelectedIndexChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.Info;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label34.Location = new System.Drawing.Point(669, 292);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(114, 29);
            this.label34.TabIndex = 48;
            this.label34.Text = "Hotel ID:";
            // 
            // comboBoxarrivalflightid
            // 
            this.comboBoxarrivalflightid.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxarrivalflightid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxarrivalflightid.FormattingEnabled = true;
            this.comboBoxarrivalflightid.Location = new System.Drawing.Point(505, 289);
            this.comboBoxarrivalflightid.Name = "comboBoxarrivalflightid";
            this.comboBoxarrivalflightid.Size = new System.Drawing.Size(134, 37);
            this.comboBoxarrivalflightid.TabIndex = 47;
            this.comboBoxarrivalflightid.SelectedIndexChanged += new System.EventHandler(this.comboBoxarrivalflightid_SelectedIndexChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.SystemColors.Info;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label33.Location = new System.Drawing.Point(351, 293);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(148, 29);
            this.label33.TabIndex = 46;
            this.label33.Text = "A. Flight ID:";
            // 
            // comboBoxdestflightid
            // 
            this.comboBoxdestflightid.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxdestflightid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxdestflightid.FormattingEnabled = true;
            this.comboBoxdestflightid.Location = new System.Drawing.Point(200, 285);
            this.comboBoxdestflightid.Name = "comboBoxdestflightid";
            this.comboBoxdestflightid.Size = new System.Drawing.Size(129, 37);
            this.comboBoxdestflightid.TabIndex = 45;
            this.comboBoxdestflightid.SelectedIndexChanged += new System.EventHandler(this.comboBoxdestflightid_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.SystemColors.Info;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label32.Location = new System.Drawing.Point(16, 289);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(178, 29);
            this.label32.TabIndex = 44;
            this.label32.Text = "Dest Flight ID:";
            // 
            // textFullPrice
            // 
            this.textFullPrice.BackColor = System.Drawing.SystemColors.Info;
            this.textFullPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFullPrice.Location = new System.Drawing.Point(674, 407);
            this.textFullPrice.Name = "textFullPrice";
            this.textFullPrice.Size = new System.Drawing.Size(183, 35);
            this.textFullPrice.TabIndex = 43;
            this.textFullPrice.TextChanged += new System.EventHandler(this.textFullPrice_TextChanged);
            // 
            // txtnights
            // 
            this.txtnights.BackColor = System.Drawing.SystemColors.Info;
            this.txtnights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnights.Location = new System.Drawing.Point(261, 407);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(183, 35);
            this.txtnights.TabIndex = 42;
            this.txtnights.TextChanged += new System.EventHandler(this.txtNumberofpeople_TextChanged);
            // 
            // comboHotelName
            // 
            this.comboHotelName.BackColor = System.Drawing.SystemColors.Info;
            this.comboHotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHotelName.FormattingEnabled = true;
            this.comboHotelName.Items.AddRange(new object[] {
            "None"});
            this.comboHotelName.Location = new System.Drawing.Point(246, 234);
            this.comboHotelName.Name = "comboHotelName";
            this.comboHotelName.Size = new System.Drawing.Size(855, 33);
            this.comboHotelName.TabIndex = 41;
            // 
            // comboArrivalFlight
            // 
            this.comboArrivalFlight.BackColor = System.Drawing.SystemColors.Info;
            this.comboArrivalFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboArrivalFlight.FormattingEnabled = true;
            this.comboArrivalFlight.Items.AddRange(new object[] {
            "None"});
            this.comboArrivalFlight.Location = new System.Drawing.Point(246, 188);
            this.comboArrivalFlight.Name = "comboArrivalFlight";
            this.comboArrivalFlight.Size = new System.Drawing.Size(855, 33);
            this.comboArrivalFlight.TabIndex = 40;
            // 
            // combodestflight
            // 
            this.combodestflight.BackColor = System.Drawing.SystemColors.Info;
            this.combodestflight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodestflight.FormattingEnabled = true;
            this.combodestflight.Items.AddRange(new object[] {
            "None"});
            this.combodestflight.Location = new System.Drawing.Point(246, 142);
            this.combodestflight.Name = "combodestflight";
            this.combodestflight.Size = new System.Drawing.Size(855, 33);
            this.combodestflight.TabIndex = 39;
            this.combodestflight.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.SystemColors.Info;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label31.Location = new System.Drawing.Point(589, 86);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(120, 29);
            this.label31.TabIndex = 38;
            this.label31.Text = "Client ID:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(775, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 35);
            this.textBox2.TabIndex = 36;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // comboclientid
            // 
            this.comboclientid.BackColor = System.Drawing.SystemColors.Info;
            this.comboclientid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboclientid.FormattingEnabled = true;
            this.comboclientid.Location = new System.Drawing.Point(237, 83);
            this.comboclientid.Name = "comboclientid";
            this.comboclientid.Size = new System.Drawing.Size(260, 37);
            this.comboclientid.TabIndex = 35;
            this.comboclientid.SelectedIndexChanged += new System.EventHandler(this.comboclientid_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.SystemColors.Info;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label30.Location = new System.Drawing.Point(59, 91);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(164, 29);
            this.label30.TabIndex = 34;
            this.label30.Text = "Client Name:";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.Info;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label29.Location = new System.Drawing.Point(153, 237);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(82, 29);
            this.label29.TabIndex = 33;
            this.label29.Text = "Hotel:";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.Info;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label28.Location = new System.Drawing.Point(16, 146);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(224, 29);
            this.label28.TabIndex = 32;
            this.label28.Text = "Destination Flight:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.Info;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(68, 189);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(167, 29);
            this.label27.TabIndex = 31;
            this.label27.Text = "Arrival Flight:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.Info;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label26.Location = new System.Drawing.Point(13, 410);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(219, 29);
            this.label26.TabIndex = 30;
            this.label26.Text = "Number of nights:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.Info;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(501, 410);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(153, 29);
            this.label25.TabIndex = 29;
            this.label25.Text = "Full Price $:";
            // 
            // accessDataBtn
            // 
            this.accessDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accessDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accessDataBtn.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessDataBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accessDataBtn.Location = new System.Drawing.Point(740, 12);
            this.accessDataBtn.Name = "accessDataBtn";
            this.accessDataBtn.Size = new System.Drawing.Size(271, 47);
            this.accessDataBtn.TabIndex = 33;
            this.accessDataBtn.Text = "Access Data";
            this.accessDataBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.accessDataBtn.UseVisualStyleBackColor = false;
            this.accessDataBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 655);
            this.Controls.Add(this.accessDataBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load_1);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveDataBtnNewClient;
        private System.Windows.Forms.ComboBox comboBoxClientType;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtstatusid;
        private System.Windows.Forms.TextBox txtflightprice;
        private System.Windows.Forms.TextBox txtflightname;
        private System.Windows.Forms.TextBox txtorigAirport;
        private System.Windows.Forms.TextBox txtDestAirport;
        private System.Windows.Forms.TextBox txtflightid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSaveHotel;
        private System.Windows.Forms.TextBox txtHotelPriceNight;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.TextBox txtDestHotelAirp;
        private System.Windows.Forms.TextBox txtHotelID;
        private System.Windows.Forms.Label namewh;
        private System.Windows.Forms.Label airportlabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboclientid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox combodestflight;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboArrivalFlight;
        private System.Windows.Forms.ComboBox comboHotelName;
        private System.Windows.Forms.TextBox textFullPrice;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.ComboBox comboBoxarrivalflightid;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox comboBoxdestflightid;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox comboboxhotelid;
        private System.Windows.Forms.Label label34;
        private Button btnSaveBooking;
        private Button accessDataBtn;
    }
}