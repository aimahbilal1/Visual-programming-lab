namespace task_9_lab_7
{
    public partial class Form1 : Form
    {
        private const int MaxCharacters = 160;
        public Form1()
        {
            InitializeComponent();
            UpdateCharacterCount();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > MaxCharacters)
            {
                textBox1.Text = textBox1.Text.Substring(0, MaxCharacters);
                textBox1.SelectionStart = textBox1.Text.Length; 
            }

            UpdateCharacterCount();
        }
        private void UpdateCharacterCount()
        {
            int charactersLeft = MaxCharacters - textBox1.Text.Length;
            label1.Text = $"Characters Left: {charactersLeft}";
        }
    }
}