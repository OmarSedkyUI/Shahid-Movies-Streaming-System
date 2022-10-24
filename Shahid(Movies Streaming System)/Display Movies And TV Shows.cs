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
    public partial class Display_Movies_And_TV_Shows : Form
    {
        // David
        string ordb = "Data Source= orcl; User Id=scott; Password=tiger";
        OracleConnection conn;
        public string type;
        public string name;
        public string ssn;

        public Display_Movies_And_TV_Shows(string name, string type, string ssn)
        {
            InitializeComponent();
            this.name = name;
            this.type = type;
            this.ssn = ssn;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (radioButton1.Checked == true)
            {
                string MOVIES_ID = textBox2.Text;
                cmd.CommandText = "INSERT INTO FAVOURITE_MOVIES values ('" + ssn + "', '" + MOVIES_ID + "')";
            }
            else
            {
                string TV_shows_ID = textBox2.Text;
                cmd.CommandText = "INSERT INTO FAVOURITE_TV_SHOWS values ('" + ssn + "', '" + TV_shows_ID + "')";
            }

            cmd.ExecuteNonQuery();
        }

        private void Display_Movies_And_TV_Shows_Load(object sender, EventArgs e)
        {
            if(type.Equals("Movies"))
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from  Movies  where Name=:Name";
                cmd.Parameters.Add("Name", name);
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    radioButton1.Select();
                    textBox2.Text = dr[0].ToString();
                    textBox1.Text = name;
                    richTextBox1.Text = dr[2].ToString();
                    textBox3.Text = dr[3].ToString();
                    textBox4.Text = dr[4].ToString();
                    textBox7.Text = dr[5].ToString();
                    if (dr[6].ToString().Equals("Comedy"))
                    {
                        checkBox1.Select();
                    }
                    else if (dr[6].ToString().Equals("Sci-Fi"))
                    {
                        checkBox2.Select();
                    }
                    else if (dr[6].ToString().Equals("Horror"))
                    {
                        checkBox3.Select();
                    }
                    else if (dr[6].ToString().Equals("Romance"))
                    {
                        checkBox4.Select();
                    }
                    else if (dr[6].ToString().Equals("Action"))
                    {
                        checkBox5.Select();
                    }
                    else if (dr[6].ToString().Equals("Thriller"))
                    {
                        checkBox6.Select();
                    }
                    else if (dr[6].ToString().Equals("Drama"))
                    {
                        checkBox7.Select();
                    }
                    else if (dr[6].ToString().Equals("Mystery"))
                    {
                        checkBox8.Select();
                    }
                    else if (dr[6].ToString().Equals("Crime"))
                    {
                        checkBox9.Select();
                    }
                    else if (dr[6].ToString().Equals("Animation"))
                    {
                        checkBox10.Select();
                    }
                    else if (dr[6].ToString().Equals("Adventure"))
                    {
                        checkBox11.Select();
                    }
                    else if (dr[6].ToString().Equals("Fantasy"))
                    {
                        checkBox12.Select();
                    }
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = $"Select a.name from  Actors a, MOVIES m, MOVIES_ACTORS ma  " + "where m.id=ID" + "and m.id=ma.MOVIE_ID" + "and ma.ACTOR_ID = a.ID";
                    cmd2.Parameters.Add("ID", textBox2.Text);
                    cmd2.CommandType = CommandType.Text;
                    OracleDataReader dr2 = cmd2.ExecuteReader();
                    textBox10.Text = dr2[0].ToString();
                }
            }
            else if(type.Equals("TV_Shows"))
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"Select * from  TV_SHOWS  where Name={name}";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr1 = cmd.ExecuteReader();
                while(dr1.Read())
                {
                    radioButton2.Select();
                    textBox2.Text = dr1[0].ToString();
                    textBox1.Text = name;
                    richTextBox1.Text = dr1[2].ToString();
                    textBox5.Text = dr1[3].ToString();
                    textBox6.Text = dr1[4].ToString();
                    textBox7.Text = dr1[5].ToString();
                    textBox4.Text = dr1[6].ToString();
                    if (dr1[7].ToString().Equals("Comedy"))
                    {
                        checkBox1.Select();
                    }
                    else if (dr1[7].ToString().Equals("Sci-Fi"))
                    {
                        checkBox2.Select();
                    }
                    else if (dr1[7].ToString().Equals("Horror"))
                    {
                        checkBox3.Select();
                    }
                    else if (dr1[7].ToString().Equals("Romance"))
                    {
                        checkBox4.Select();
                    }
                    else if (dr1[7].ToString().Equals("Action"))
                    {
                        checkBox5.Select();
                    }
                    else if (dr1[7].ToString().Equals("Thriller"))
                    {
                        checkBox6.Select();
                    }
                    else if (dr1[7].ToString().Equals("Drama"))
                    {
                        checkBox7.Select();
                    }
                    else if (dr1[7].ToString().Equals("Mystery"))
                    {
                        checkBox8.Select();
                    }
                    else if (dr1[7].ToString().Equals("Crime"))
                    {
                        checkBox9.Select();
                    }
                    else if (dr1[7].ToString().Equals("Animation"))
                    {
                        checkBox10.Select();
                    }
                    else if (dr1[7].ToString().Equals("Adventure"))
                    {
                        checkBox11.Select();
                    }
                    else if (dr1[7].ToString().Equals("Fantasy"))
                    {
                        checkBox12.Select();
                    }
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = $"Select a.name from  Actors a, TV_SHOWS tv, TV_SHOWS_ACTORS tva  " + "where tv.id=:ID" + "and tv.id=tva.MOVIE_ID" + "and tva.ACTOR_ID = a.ID";
                    cmd2.Parameters.Add("ID", textBox2.Text);
                    cmd2.CommandType = CommandType.Text;
                    OracleDataReader dr2 = cmd2.ExecuteReader();
                    textBox10.Text = dr2[0].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage f1 = new HomePage(ssn);
            f1.ShowDialog();
        }
    }
}
