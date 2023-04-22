using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorBooking_App_ointment
{
    public partial class Form4 : Form
    {
        String connectionString = "Data source=test3.db;Version=3";
        SQLiteConnection conn;
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ConnectUser f1 = new ConnectUser();
            f1.Show();
            Form2 form2 = new Form2();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            conn.Open();
            String ama = textBox3.Text;
            String password = textBox4.Text;
            String name = textBox5.Text;
            String specialty = textBox6.Text;
            String tel = textBox7.Text;
            String email = textBox8.Text;
            String address = textBox9.Text;
            String zip = textBox10.Text;
            String region = textBox11.Text;



            String insertSql = "Insert into Doctor(ama,password,name,specialty,tel,email,address,zip,region) values('" + ama + "','" + password + "','" + name + "','" + specialty + "','" + tel + "','" + email + "','" + address + "','" + zip + "','" + region + "')";
            SQLiteCommand cmd = new SQLiteCommand(insertSql, conn);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)

                MessageBox.Show(count.ToString() + "Congratulations, your account has been successfully created.");


            conn.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            String ama = textBox1.Text;
            String password = textBox2.Text;

            String selectSQL = "Select * from Doctor where " + "ama=@ama and password=@password";
            SQLiteCommand cmd = new SQLiteCommand(selectSQL, conn);
            cmd.Parameters.AddWithValue("@ama", ama);
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
    }
}
