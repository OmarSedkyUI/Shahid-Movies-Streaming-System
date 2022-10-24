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
    public partial class Update_User : Form
    {
        // Antony
        string ordb = "Data Source= orcl; User Id=scott; Password=tiger";
        OracleConnection conn;
        string ssn;
        public Update_User(string ssn)
        {
            InitializeComponent();
            this.ssn = ssn;
        }
        int textboxva1 = 0;
        int textboxva2 = 0;
        int textboxva3 = 0;
        int textboxva4 = 0;
        int textboxva5 = 0;
        int textboxva6 = 0;
        int textboxva7 = 0;
        int textboxva8 = 0;
        int textboxva9 = 0;
        int textboxva10 = 0;
        int textboxva11 = 0;
        int textboxva12 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            if (textboxva1 == 0 || textboxva2 == 0 || textboxva3 == 0 || textboxva4 == 0 || textboxva5 == 0 || textboxva6 == 0 || textboxva7 == 0 || textboxva8 == 0 || textboxva9 == 0 || textboxva10 == 0 || textboxva11 == 0 || textboxva12 == 0)
            {
                MessageBox.Show("Must Fill All The Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox12.Text != textBox6.Text)
                {
                    MessageBox.Show("Passwords Doesn't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE Users SET FirstName = :first, LastName = :last, Password = :password ,Sex = :sex, Phone = :phone, BirthDate = :birthdate, SubscriptionType = :subscriptiontype, Address = :address, ZipCode = :zip, PaymentMethod = :paymentmethod WHERE Email = :email";
                cmd.Parameters.Add("first", textBox1.Text);
                cmd.Parameters.Add("last", textBox2.Text);
                cmd.Parameters.Add("email", textBox3.Text);
                cmd.Parameters.Add("sex", textBox4.Text);
                cmd.Parameters.Add("phone", textBox5.Text);
                cmd.Parameters.Add("password", textBox6.Text);
                cmd.Parameters.Add("birthdate", textBox7.Text);
                cmd.Parameters.Add("subscriptiontype", textBox8.Text);
                cmd.Parameters.Add("address", textBox9.Text);
                cmd.Parameters.Add("zip", textBox10.Text);
                cmd.Parameters.Add("paymentmethod", textBox11.Text);
                int r = cmd.ExecuteNonQuery();
                if(r != -1)
                {
                    MessageBox.Show("User Updated");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textboxva1 = 0;
            }
            else
            {
                textboxva1 = 1;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textboxva7 = 0;
            }
            else
            {
                textboxva7 = 1;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textboxva2 = 0;
            }
            else
            {
                textboxva2 = 1;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textboxva8 = 0;
            }
            else
            {
                textboxva8 = 1;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textboxva3 = 0;
            }
            else
            {
                textboxva3 = 1;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textboxva9 = 0;
            }
            else
            {
                textboxva9 = 1;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textboxva4 = 0;
            }
            else
            {
                textboxva4 = 1;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textboxva10 = 0;
            }
            else
            {
                textboxva10 = 1;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textboxva5 = 0;
            }
            else
            {
                textboxva5 = 1;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textboxva11 = 0;
            }
            else
            {
                textboxva11 = 1;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textboxva6 = 0;
            }
            else
            {
                textboxva6 = 1;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                textboxva12 = 0;
            }
            else
            {
                textboxva12 = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage(ssn);
            f1.ShowDialog();
        }
    }
}
