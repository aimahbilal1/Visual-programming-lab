namespace task_2_lab_7
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            operation = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double num = Double.Parse(textBox1.Text);
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + num).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - num).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * num).ToString();
                    break;
                case "/":
                    if (num != 0)
                    {
                        textBox1.Text = (result / num).ToString();
                    }
                    else
                    {
                        textBox1.Text = "Cannot divide by zero";
                    }
                    break;
            }
            result = Double.Parse(textBox1.Text);
            operation = "";
         }

        private void button11_Click(object sender, EventArgs e)
        {
                if (textBox1.Text == "0" || isOperationPerformed)
                    textBox1.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                textBox1.Text += button.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "2" || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "3" || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4" || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "5" || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "6" || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "7" || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "8" || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "9" || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "." || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                button13_Click(this, EventArgs.Empty);
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(textBox1.Text);
                isOperationPerformed = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                button13_Click(this, EventArgs.Empty);
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(textBox1.Text);
                isOperationPerformed = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                button13_Click(this, EventArgs.Empty);
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(textBox1.Text);
                isOperationPerformed = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                button13_Click(this, EventArgs.Empty);
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(textBox1.Text);
                isOperationPerformed = true;
            }
        }
    }
}