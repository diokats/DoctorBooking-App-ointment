using System.Data.SQLite;

namespace DoctorBooking_App_ointment
{
    public partial class ConnectUser : Form
    {
        String connectionString = "Data source=test3.db;Version=3";
        SQLiteConnection conn;

        public ConnectUser()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String amka = textBox1.Text.Trim();
            String password = textBox2.Text.Trim();

            if (amka != null && password != null && amka != "" && password != "")

            {
                conn.Open();

                String selectSQL = "Select * from User where " + "amka=@amka and password=@password";
                SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
                cmd.Parameters.AddWithValue("@amka", amka);
                cmd.Parameters.AddWithValue("@password", password);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Program.userId = amka;
                    Program.userType = "patient";
                    MessageBox.Show("You are successfully logged in");
                    new Form3().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong email and/or password");

                }
                conn.Close();

            }
            else
            {
                MessageBox.Show("You must fill in all the fields to continue");

            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();

        }
    }
}