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
    // Mostafa
    public partial class HomePage : Form
    {
        Display_Movies_And_TV_Shows f2;
        string ssn;
        public HomePage(string ssn)
        {
            InitializeComponent();
            this.ssn = ssn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_User f1 = new Update_User(ssn);
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new Display_Movies_And_TV_Shows(button2.Text, "Movies",ssn);
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new Display_Movies_And_TV_Shows(button3.Text, "Movies", ssn);
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new Display_Movies_And_TV_Shows(button4.Text, "Movies", ssn);
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new Display_Movies_And_TV_Shows(button5.Text, "Movies", ssn);
            f2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new Display_Movies_And_TV_Shows(button6.Text, "Movies", ssn);
            f2.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new Display_Movies_And_TV_Shows(button11.Text, "TV_Shows", ssn);
            f2.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new Display_Movies_And_TV_Shows(button11.Text, "TV_Shows", ssn);
            f2.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new Display_Movies_And_TV_Shows(button11.Text, "TV_Shows", ssn);
            f2.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new Display_Movies_And_TV_Shows(button11.Text, "TV_Shows", ssn);
            f2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2 = new Display_Movies_And_TV_Shows(button11.Text, "TV_Shows", ssn);
            f2.ShowDialog();
        }
    }
}
