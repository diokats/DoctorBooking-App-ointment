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
    public partial class Form2 : Form
    {
        String connectionString = "Data source=test3.db;Version=3";
        SQLiteConnection conn;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnectUser f1 = new ConnectUser();
            f1.Show();
            Form2 form2 = new Form2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String amka = textBox1.Text.Trim();
            String password = textBox2.Text.Trim();
            String name = textBox3.Text.Trim();
            String tel = textBox4.Text.Trim();
            String email = textBox5.Text.Trim();

            if (amka != null && password != null && name !=null && tel != null && email != null && 
                amka != "" && password != "" && name != "" && tel != "" && email != "")
            {
                conn.Open();

                String insertSql = "Insert into User(amka,password,name,tel,email) values('" + amka + "','" + password + "','" + name + "','" + tel + "','" + email + "')";
                SQLiteCommand cmd = new SQLiteCommand(insertSql, conn);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)

                    MessageBox.Show(count.ToString() + "Congratulations, your account has been successfully created.");


                conn.Close();

            }
            else
            {
                MessageBox.Show("You must fill in all the fields to continue");

            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
