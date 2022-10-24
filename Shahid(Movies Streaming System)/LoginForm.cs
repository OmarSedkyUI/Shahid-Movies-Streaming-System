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
    public partial class LoginForm : Form
    {
        // Antony
        string ordb = "Data Source= orcl; User Id=scott; Password=tiger";
        OracleConnection conn;
        int textbox1 = 0;
        int textbox2 = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox1 == 0 || textbox2 == 0)
            {
                MessageBox.Show("Must Fill Email and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text.Equals("admin") && textBox2.Text.Equals("admin"))
            {
                this.Hide();
                Admin_Form f2 = new Admin_Form();
                f2.ShowDialog();
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                string EMAIL = textBox1.Text;
                string PASSWORD = textBox2.Text;
                cmd.CommandText = "SELECT * FROM Users WHERE Email = '" + EMAIL + "' and Password = '" + PASSWORD + "'";
                OracleDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    string ssn = reader[0].ToString();
                    this.Hide();
                    HomePage f1 = new HomePage(ssn);
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You Entered a wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textbox1 = 0;
            }
            else
            {
                textbox1 = 1;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textbox2 = 0;
            }
            else
            {
                textbox2 = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_User f1 = new Create_User();
            f1.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
