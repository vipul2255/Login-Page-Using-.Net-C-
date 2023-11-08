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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        public void setvalue(string name, string country, string gender, string hobbies)
        {
            label1.Text = name;
            label2.Text = country;
            label3.Text = gender;
            label4.Text = hobbies;
        }
    }
}
