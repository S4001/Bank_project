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
    public partial class Form2 : Form
    {
        public string cs = @"Data Source=DESKTOP-DS37MS3\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
           
            if (radioButton1.Checked)
            {
                string q = "insert into tTransaction Values(@AccountNumber,@Amount,0,0,GETDATE())";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@AccountNumber", textBox1.Text);
                cmd.Parameters.AddWithValue("@Amount", textBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Amount Debited Succesfully !");
            }
            else
            {
                string Credit = "insert into tTransaction Values(@AccountNumber,0,@Amount,0,GETDATE())";
                SqlCommand cmd = new SqlCommand(Credit, con);
                cmd.Parameters.AddWithValue("@AccountNumber", textBox1.Text);
                cmd.Parameters.AddWithValue("@Amount", textBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Amount Credited Succesfully !");
            }
           
            con.Close();
        }
    }
}
