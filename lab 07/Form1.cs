namespace task_5_lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private long CalculateFactorial(int number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox1.Text);

                if (number < 0)
                {
                    MessageBox.Show("Please enter a non-negative integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long factorial = CalculateFactorial(number);
                textBox2.Text = " " + factorial.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = " ";
        }
    }
}