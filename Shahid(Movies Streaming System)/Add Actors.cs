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
    public partial class Add_Actors : Form
    {
        // Ahmed Essam
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;

        public Add_Actors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(textBox4.Text);
            string NAME = textBox1.Text;
            string SEX = textBox2.Text;
            int BIRTHDATE = Int32.Parse(textBox3.Text);

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert into Actors values('" + ID + "', '" + NAME + "', '" + SEX + "', '" + BIRTHDATE + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Actor has been added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Form f1 = new Admin_Form();
            f1.ShowDialog();
        }
    }
}
