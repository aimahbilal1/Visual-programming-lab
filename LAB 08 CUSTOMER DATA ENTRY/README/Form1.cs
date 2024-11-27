using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab09_activity_1
{
    
    public partial class Form1 : Form
    {
        string Gender, Hobby, Status = " ";

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlconnection = "Data Source=AUMC-LAB3-30\\SQLEXPRESS; Initial Catalog = Customer; Integrated Security = True";
            SqlConnection sqlconnection1 = new SqlConnection(sqlconnection);
            sqlconnection1.Open();
            string command = "Select * from Customerdata";
            SqlCommand sqlcommand = new SqlCommand(command, sqlconnection1);

            DataSet obdataset = new DataSet();
            SqlDataAdapter adapter1 = new SqlDataAdapter(sqlcommand);
            adapter1.Fill(obdataset);
            dataGridView1.DataSource = obdataset.Tables[0];
            sqlconnection1.Close();
        }

        public Form1()
        { 
            InitializeComponent();
            comboBox2.Items.Add("Pakistan");
            comboBox2.Items.Add("India");
            comboBox2.Items.Add("Dubai");
        }
        private void clearForm()
        {
            textBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                Gender = radioButton1.Text;
            }
            else
            if (radioButton2.Checked)
            {
                Gender = radioButton2.Text;
            }

            if (radioButton3.Checked)
            {
                   Status = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                Status =radioButton4.Text;
            }
            if(checkBox1.Checked)
            {
                Hobby = checkBox1.Text;
            }
            else 
            if(checkBox2.Checked)
            {
                Hobby=checkBox2.Text;
            }
            ClassValidation valid = new ClassValidation();
            try
            {
                valid.CheckCustomerName(textBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error! {ex.Message}");
            }
            /*clearForm();
            string CustomerName = dtgCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            displayCustomer(CustomerName);*/
        
        Form2 form = new Form2();
            form.getData(textBox1.Text,comboBox2.Text, Gender, Hobby, Status);
            form.Show();
            string strConnection = "Data Source=AUMC-LAB3-30\\SQLEXPRESS;Initial Catalog=Customer;" + "Integrated Security=True";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            string strCommand = "insert into Customerdata values('" + textBox1.Text + "', '"+ comboBox2.Text + "','"+ Gender + "', '"+ Hobby + "','"+ Status + "' )";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            objCommand.ExecuteNonQuery();
            objConnection.Close();
            Form1_Load(sender,e);
        }
        

    }
}
