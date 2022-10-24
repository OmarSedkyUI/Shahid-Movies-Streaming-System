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
    public partial class Add_Movies_And_TV_Shows : Form
    {
        // Omar Magdy
        string ordb = "Data Source= orcl; User Id=scott; Password=tiger";
        OracleConnection conn;
        OracleDataReader reader;
        String Genre;
        int ID_VALUE;

        public Add_Movies_And_TV_Shows()
        {
            InitializeComponent();
        }

        private void Add_Movies_And_TV_Shows_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            label7.Hide();
            textBox8.Hide();
            label13.Hide();
            textBox9.Hide();
            label10.Hide();
            label14.Hide();
            label9.Hide();
            textBox10.Hide();
            label15.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox9.Hide();
            label10.Hide();
            label14.Hide();
            label9.Hide();
            textBox10.Hide();
            label15.Hide();
            label7.Show();
            textBox8.Show();
            label13.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Hide();
            textBox8.Hide();
            label13.Hide();
            textBox9.Show();
            label10.Show();
            label14.Show();
            label9.Show();
            textBox10.Show();
            label15.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Genre = "Comedy";
            }
            else if (radioButton4.Checked)
            {
                Genre = "Sci-Fi";
            }
            else if (radioButton5.Checked)
            {
                Genre = "Horror";
            }
            else if (radioButton6.Checked)
            {
                Genre = "Romance";
            }
            else if (radioButton7.Checked)
            {
                Genre = "Action";
            }
            else if (radioButton8.Checked)
            {
                Genre = "Thriller";
            }
            else if (radioButton9.Checked)
            {
                Genre = "Drama";
            }
            else if (radioButton10.Checked)
            {
                Genre = "Mystery";
            }
            else if (radioButton11.Checked)
            {
                Genre = "Crime";
            }
            else if (radioButton12.Checked)
            {
                Genre = "Animation";
            }
            else if (radioButton13.Checked)
            {
                Genre = "Adventure";
            }
            else if (radioButton14.Checked)
            {
                Genre = "Fantasy";
            }
            if (radioButton1.Checked)
            {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = "SELECT * FROM Actors WHERE Name = :NAME";
                cmd3.Parameters.Add("NAME", textBox7.Text);
                cmd3.CommandType = CommandType.Text;
                reader = cmd3.ExecuteReader();
                while (reader.Read())
                {
                    ID_VALUE = Convert.ToInt32(reader["ID"]);
                }
                int ID = Int32.Parse(textBox1.Text);
                cmd2.CommandText = "insert into Movies_Actors values('" + ID + "','" + ID_VALUE + "')";
                cmd2.ExecuteNonQuery();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                string NAME = textBox2.Text;
                string DESCRIPTION = richTextBox1.Text;
                int LENGTH = Int32.Parse(textBox8.Text);
                int RATE = Int32.Parse(textBox6.Text);
                int RELEASEDATE = Int32.Parse(textBox5.Text);
                cmd.CommandText = "insert into Movies  values('" + ID + "', '" + NAME + "', '" + DESCRIPTION + "', '" + LENGTH + "', '" + RELEASEDATE + "', '" + RATE + "', '" + Genre + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Movie is added");

            }
            else if (radioButton2.Checked)
            {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = "SELECT * FROM Actors WHERE Name = :NAME";
                cmd3.Parameters.Add("NAME", textBox7.Text);
                cmd3.CommandType = CommandType.Text;
                reader = cmd3.ExecuteReader();
                while (reader.Read())
                {
                    ID_VALUE = Convert.ToInt32(reader["ID"]);
                }
                int ID = Int32.Parse(textBox1.Text);
                cmd2.CommandText = "insert into TV_Shows_Actors values('" + ID + "','" + ID_VALUE + "')";
                cmd2.ExecuteNonQuery();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                string NAME = textBox2.Text;
                string DESCRIPTION = richTextBox1.Text;
                int NO_OF_SEASONS = Int32.Parse(textBox9.Text);
                int NO_OF_EPISODES = Int32.Parse(textBox10.Text);
                int RATE = Int32.Parse(textBox6.Text);
                int RELEASEDATE = Int32.Parse(textBox5.Text);
                cmd.CommandText = "insert into TV_Shows values('" + ID + "', '" + NAME + "', '" + DESCRIPTION + "', '" + NO_OF_SEASONS + "', '" + NO_OF_EPISODES + "', '" + RATE + "', '" + RELEASEDATE + "', '" + Genre + "')";
                int r = cmd.ExecuteNonQuery();
                if (r != 1)
                {
                    MessageBox.Show("New TV Show is added");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Form f1 = new Admin_Form();
            f1.ShowDialog();
        }
    }
}
