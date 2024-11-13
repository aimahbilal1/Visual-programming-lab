namespace lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label2.Visible = true;
                label2.Text = $"Hey! {textBox1.Text}, Welcome :)";
            }
            else
            {
                label2.Text = "Please Enter the Name first.";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("WeekDays");
            comboBox1.Items.Add("Year");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "WeekDays")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Monday");
                comboBox2.Items.Add("Tuesday");
                comboBox2.Items.Add("Wednesday");
                comboBox2.Items.Add("Thursday");
                comboBox2.Items.Add("Friday");
                comboBox2.Items.Add("Saturday");
                comboBox2.Items.Add("Sunday");
            }
            else
            if (comboBox1.SelectedItem == "Year")
            {
                comboBox2.Items.Add("2020");
                comboBox2.Items.Add("2021");
                comboBox2.Items.Add("2022");
                comboBox2.Items.Add("2023");
                comboBox2.Items.Add("2024");
            }
        }
    }
}