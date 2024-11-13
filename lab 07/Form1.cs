namespace task_4_lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double fahrenheit))
            {
                double centigrade = (fahrenheit - 32) * 5 / 9;

                textBox1.Text = centigrade.ToString("F2"); 
            }
            else
            {
                MessageBox.Show("Please enter a valid number for Fahrenheit.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}