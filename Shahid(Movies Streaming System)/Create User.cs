using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LoginForm
{
    public partial class Create_User : Form
    {
        // David
        string ordb = "Data Source= orcl; User Id=scott; Password=tiger";
        OracleConnection conn;

        public Create_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox12.Text.Equals(textBox11.Text))
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into users values(:SSN, :FirstName, :LastName, :Email, :Password, :SEX, :Phone, :BirthDate, :SubscriptionType, :Address, :ZipCode, :PaymentMethod)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("SSN", this.textBox13.Text);
                cmd.Parameters.Add("FirstName", this.textBox1.Text);
                cmd.Parameters.Add("LastName", this.textBox2.Text);
                cmd.Parameters.Add("Email", this.textBox3.Text);
                cmd.Parameters.Add("Password", this.textBox12.Text);
                cmd.Parameters.Add("SEX", this.textBox5.Text);
                cmd.Parameters.Add("Phone", this.textBox7.Text);
                cmd.Parameters.Add("BirthDate", this.textBox4.Text);
                cmd.Parameters.Add("SubscriptionType", this.textBox9.Text);
                cmd.Parameters.Add("Address", this.textBox6.Text);
                cmd.Parameters.Add("ZipCode", this.textBox8.Text);
                cmd.Parameters.Add("PaymentMethod", this.textBox10.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User info stored");
            }
            else
            {
                MessageBox.Show("The password you entered the second time does not match the first password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
        }
    }
}
