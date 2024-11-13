namespace task_7_lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //timer1 = new timer1();
            timer1.Interval = 1000; 
            timer1.Tick += timer1_Tick;
            timer1.Start();
            UpdateDateTime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }
        private void UpdateDateTime()
        {
            label1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
        }
    }
}