using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_page
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = null;
            string hobbies = null;
            if (radioButton1.Checked)
                gender = "Male";
            else
                gender = "Female";
            if (checkBox1.Checked)
                hobbies += "Cricket ";
            if (checkBox2.Checked)
                hobbies += "Football";
            Form5 f = new Form5();
            f.setvalue(textBox1.Text, textBox2.Text, gender, hobbies);
            f.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
