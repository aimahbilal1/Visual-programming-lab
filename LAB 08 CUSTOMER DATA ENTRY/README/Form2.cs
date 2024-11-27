using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab09_activity_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void getData(string Name, String Country, string Hobby, string Gender, String Status)
        {
            label1.Text = $"Customer Name : {Name}";
            label2.Text = $"Country Name : {Country}";
            label3.Text = $"Gender : {Gender}";
            label4.Text = $"Hobby : {Hobby}";
            label5.Text = $"Status : {Status}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
