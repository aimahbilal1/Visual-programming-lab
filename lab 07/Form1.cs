namespace task_6_lab_07
{
    public partial class Form1 : Form
    {
        private decimal ti;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            label2.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ti = numericUpDown1.Value * 10;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ti > 0)
            {
                ti--;
                label2.Visible = true;
                label2.Text = "Time Left: " + ti.ToString() + " seconds left.";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Time is Over.");
            }
        }

        
    }
}