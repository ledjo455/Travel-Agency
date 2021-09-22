using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedjoPiluaTravel
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            RetriveId();

        }
       
        private void RetriveId()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
            string sql = "select BookingID from TravelData";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    int value = int.Parse(myreader[0].ToString())+5;
                    textBox1.Text = value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e) //Button Book
        {
            panel4.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            fillcomboclientid();
            fillcombodestflight();
            fillcomboarrivalflight();
            fillhotelname();
            filldestinationflightid();
            fillarrivalflightid();
            fillhotelid();
            RetriveId();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void SaveDataBtnNewClient_Click(object sender, EventArgs e)
        {
            try
            {
                
                int cid = Convert.ToInt32(txtCID.Text);

                String firstname = txtFirstName.Text;
                String lastname = txtLastName.Text;
                Int64 Number = Convert.ToInt64(txtNumber.Text);
                int age = Convert.ToInt32(txtAge.Text);
                String gender = comboBoxGender.Text;
                String nationality = txtNationality.Text;
                String clienttype = comboBoxClientType.Text;
             
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into ClientData values ("+cid+",'" + firstname + "','" + lastname + "'," + Number + "," + age + ",'" + gender + "','" + nationality + "','" + clienttype + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();

                DA.Fill(DS);

                MessageBox.Show("Data Saved successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error insertion invalid data or ID");

            }

            MessageBox.Show("Data submitted successfully.");
            txtCID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNumber.Clear();
            txtAge.Clear();
            comboBoxGender.ResetText();
            txtNationality.Clear();
            comboBoxClientType.ResetText();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                int flightid = Convert.ToInt32(txtflightid.Text);
                String originAirport = txtorigAirport.Text;
                String destAirport = txtDestAirport.Text;
                String origindate = dateTimePicker1.Text;
                String destinationdate = dateTimePicker2.Text;
                String origintime = dateTimePicker3.Text;
                String destinationtime = dateTimePicker4.Text;
                String flightname = txtflightname.Text;
                int price= Convert.ToInt32(txtflightprice.Text);
                Int64 statusID = Convert.ToInt64(txtstatusid.Text);
                

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into Flight values (" + flightid + ",'" + originAirport + "','" + destAirport + "','" + origindate + "','" + destinationdate + "','" + origintime + "','" + destinationtime + "','" + flightname + "'," + price + "," + statusID + ")";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();

                DA.Fill(DS);

                MessageBox.Show("Data Saved successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error insertion invalid data or ID");

            }

            MessageBox.Show("Data submitted successfully.");
            txtflightid.Clear();
            txtflightname.Clear();
            txtorigAirport.Clear();
            txtDestAirport.Clear();
            txtflightprice.Clear();
            txtstatusid.Clear();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            dateTimePicker3.ResetText();
            dateTimePicker4.ResetText();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveHotel_Click(object sender, EventArgs e)
        {
            try
            {

                int hotelid = Convert.ToInt32(txtHotelID.Text);
                String destAirport = txtDestHotelAirp.Text; //location
                String hotelname = txtHotelName.Text;
                int hotelpricenight = Convert.ToInt32(txtHotelPriceNight.Text);
                


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into Hotel values (" + hotelid + ",'" + destAirport + "','" + hotelname + "'," + hotelpricenight + ")";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();

                DA.Fill(DS);

                MessageBox.Show("Data Saved successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error insertion invalid data or ID");

            }

            MessageBox.Show("Data submitted successfully.");
            txtHotelID.Clear();
            txtHotelName.Clear();
            txtDestHotelAirp.Clear();
            txtHotelPriceNight.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void fillcomboclientid() {
            comboclientid.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
            string sql = "select * from ClientData";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    string sname5 = myreader.GetString(2);
                    comboclientid.Items.Add(sname +" "+ sname5);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void comboclientid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
            string sql = "select * from ClientData where FirstName +' ' + LastName = '" + comboclientid.Text+"';";
            
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string rollno = myreader.GetInt64(0).ToString();
                    textBox2.Text = rollno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillcombodestflight()
        {
            combodestflight.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
            string sql = "select * from Flight";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreaderr;
            try
            {
                con.Open();
                myreaderr = cmd.ExecuteReader();
                while (myreaderr.Read())
                {

                    string departure = myreaderr.GetString(1);
                    string destination = myreaderr.GetString(2);
                    string ddate = myreaderr.GetString(3);
                    string adate = myreaderr.GetString(4);
                    string dtime = myreaderr.GetString(5);
                    string atime = myreaderr.GetString(6);
                    string fname = myreaderr.GetString(7);
                    String ID = myreaderr.GetInt64(0).ToString();
                    combodestflight.Items.Add(departure + " - " + destination + " | " + ddate + " | " + adate + " | " +
                        dtime + " | " + atime + " | Flight: " + fname + " ID: " + ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fillcomboarrivalflight()
        {
            comboArrivalFlight.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
            string sql = "select * from Flight";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreaderr;
            try
            {
                con.Open();
                myreaderr = cmd.ExecuteReader();
                while (myreaderr.Read())
                {
                   
                    string departure = myreaderr.GetString(1);
                    string destination = myreaderr.GetString(2);
                    string ddate = myreaderr.GetString(3);
                    string adate = myreaderr.GetString(4);
                    string dtime = myreaderr.GetString(5);
                    string atime = myreaderr.GetString(6);
                    string fname = myreaderr.GetString(7);
                    String ID = myreaderr.GetInt64(0).ToString();
                    comboArrivalFlight.Items.Add(departure + " - " + destination + " | " + ddate + " | " + adate + " | " +
                        dtime + " | " + atime + " | Flight: " + fname + " ID: " +ID );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void fillhotelname()
        {
            comboHotelName.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
            string sql = "select * from Hotel";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreaderr;
            try
            {
                con.Open();
                myreaderr = cmd.ExecuteReader();
                while (myreaderr.Read())
                {
                    String hotelid = myreaderr.GetInt64(0).ToString();
                    string location = myreaderr.GetString(1);
                    string hotelname= myreaderr.GetString(2);
                 

                    comboHotelName.Items.Add(" || " +location+ " || "+ hotelname +" || Hotel ID: " + hotelid );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void filldestinationflightid()
        {
            comboBoxdestflightid.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
            string sql = "select * from Flight";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreaderr;
            try
            {
                con.Open();
                myreaderr = cmd.ExecuteReader();
                while (myreaderr.Read())
                {
                    string flightid = myreaderr.GetInt64(0).ToString();

                    comboBoxdestflightid.Items.Add(flightid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void fillarrivalflightid()
        {
            comboBoxarrivalflightid.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
            string sql = "select * from Flight";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreaderr;
            try
            {
                con.Open();
                myreaderr = cmd.ExecuteReader();
                while (myreaderr.Read())
                {
                    string flightid = myreaderr.GetInt64(0).ToString();

                    comboBoxarrivalflightid.Items.Add(flightid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void filltxtboxprice()
        {
            
     


        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textFullPrice_TextChanged(object sender, EventArgs e)
        {
            filltxtboxprice();
        }

        private void comboBoxdestflightid_SelectedIndexChanged(object sender, EventArgs e)
        {
            String pricedest;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
            string sql = "select PricePerFlight from Flight where FlightID = '" + comboBoxdestflightid.Text + "';";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                     pricedest = myreader.GetInt32(0).ToString();
                    textFullPrice.Text = pricedest;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxarrivalflightid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int first = 0;
            int second = 0;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
            string sql = "select PricePerFlight from Flight where FlightID = '" + comboBoxarrivalflightid.Text + "';";
            String destprice = textFullPrice.Text;

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string price = myreader.GetInt32(0).ToString();
                    textFullPrice.Text = price;
                    if (Int32.TryParse(destprice, out second) && Int32.TryParse(textFullPrice.Text, out first))
                        textFullPrice.Text = (first + second).ToString();
                }
                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void fillhotelid()
        {
            comboboxhotelid.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
            string sql = "select * from Hotel";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreaderr;
            try
            {
                con.Open();
                myreaderr = cmd.ExecuteReader();
                while (myreaderr.Read())
                {
                    String hotelid = myreaderr.GetInt64(0).ToString();

                    comboboxhotelid.Items.Add(hotelid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        String onenightprice;
        private void comboboxhotelid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int first = 0;
            int second = 0;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
            string sql = "select PricePerNight from Hotel where HotelID = '" + comboboxhotelid.Text + "';";
            String pricehotel = textFullPrice.Text;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    String price = myreader.GetInt32(0).ToString();
                    textFullPrice.Text = price;
                    if (Int32.TryParse(pricehotel, out second) && Int32.TryParse(textFullPrice.Text, out first))
                        textFullPrice.Text = (first + second).ToString();
                    onenightprice = price;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNumberofpeople_TextChanged(object sender, EventArgs e)
        {
            int first = 0;
            int second = 0;
            int third = 0;
            int one = 1;

            String number = txtnights.Text;

                    if (Int32.TryParse(onenightprice, out second) && Int32.TryParse(textFullPrice.Text, out first) && Int32.TryParse(number, out third)) 
                        textFullPrice.Text = ((third-one)*second + first).ToString();
                        

               
        }

        private void btnSaveBooking_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSaveBooking_Click_1(object sender, EventArgs e)
        {
            try
            {

                Int64 BookingID = Convert.ToInt64(textBox1.Text);
                Int64 CID = Convert.ToInt64(textBox2.Text);
                String ClientName = comboclientid.Text;
                String destFlight = combodestflight.Text;
                String arrFlight = comboArrivalFlight.Text;
                String hotel = comboHotelName.Text;

                Int64 destFlightID = Convert.ToInt64(comboBoxdestflightid.Text);
                Int64 arrFlightID = Convert.ToInt64(comboBoxarrivalflightid.Text);
                Int64 HotelID = Convert.ToInt64(comboboxhotelid.Text);
                int fullprice = Convert.ToInt32(textFullPrice.Text);
                int numberofnights = Convert.ToInt32(txtnights.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-TKIK5T3\\SQLEXPRESS;Initial Catalog=travel;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into TravelData values (" + BookingID + "," + CID + ",'" + ClientName + "','" + destFlight + "','"
                    + arrFlight + "','" + hotel + "'," + destFlightID + "," + arrFlightID + "," + HotelID +
                    "," + fullprice + "," + numberofnights + ")";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();

                DA.Fill(DS);

                MessageBox.Show("Data Saved successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error insertion invalid data or ID");

            }

            MessageBox.Show("Data submitted successfully.");
            textBox1.Clear();
            textBox2.Clear();
            comboclientid.ResetText();
            combodestflight.ResetText();
            comboArrivalFlight.ResetText();
            comboHotelName.ResetText();
            comboBoxdestflightid.ResetText();
            comboBoxarrivalflightid.ResetText();
            comboboxhotelid.ResetText();
            textFullPrice.ResetText();
            txtnights.ResetText();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datadashboard dd = new Datadashboard();
            dd.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }
    }
    }

