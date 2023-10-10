using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankUser
{
    public partial class Form1 : Form
    {
        public string cs = @"Data Source=DESKTOP-DS37MS3\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string q = "insert into tUsers Values(@AccountID,@AccountHName,@AccountType,@CurrentBalance,GETDATE())";
            SqlCommand cmd = new SqlCommand(q,con);
            if (radioButton1.Checked)
            {
                cmd.Parameters.AddWithValue("@AccountID", textBox1.Text);
                cmd.Parameters.AddWithValue("@AccountHName", textBox2.Text);
                cmd.Parameters.AddWithValue("@AccountType", radioButton1.Text);
                cmd.Parameters.AddWithValue("@CurrentBalance", textBox3.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@AccountID", textBox1.Text);
                cmd.Parameters.AddWithValue("@AccountHName", textBox2.Text);
                cmd.Parameters.AddWithValue("@AccountType", radioButton2.Text);
                cmd.Parameters.AddWithValue("@CurrentBalance", textBox3.Text);
            }
            cmd.ExecuteNonQuery();
            MessageBox.Show("Account Create Succesfully !");
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
