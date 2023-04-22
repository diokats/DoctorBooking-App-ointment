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



        /* private void Login_Click(object sender, EventArgs e)
         {

             richTextBox1.Clear();

             conn.Open();

             String selectSQL = "Select * from User";
             SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
             SQLiteDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
             {
                 richTextBox1.AppendText(reader.GetString(1) + Environment.NewLine);

             }

             conn.Close();
         }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }

        /*private void signup_Click(object sender, EventArgs e)
        {
            conn.Open();

            String insertSql = "Insert into User(name,password) values('Chrisanthi','123456')";
            SQLiteCommand cmd = new SQLiteCommand(insertSql, conn);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)

                MessageBox.Show(count.ToString() + "signUp succesful");


            conn.Close();

        }*/

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
            conn.Open();

            String amka = textBox1.Text;
            String password = textBox2.Text;

            String selectSQL = "Select * from User where " + "amka=@amka and password=@password";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            cmd.Parameters.AddWithValue("@amka", amka);
            cmd.Parameters.AddWithValue("@password", password);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                this.Hide();
                MessageBox.Show("You are successfully logged in");
                new Form3().Show();
            }
            else
            {
                MessageBox.Show("Wrong email and/or password");

            }
            conn.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();

        }
    }
}