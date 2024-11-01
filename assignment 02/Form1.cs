namespace Assignment_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                
                System.Drawing.FontStyle newFontStyle;

                // Check if the text is already bold
                if (richTextBox1.SelectionFont.Bold)
                {
                    newFontStyle = richTextBox1.SelectionFont.Style & ~System.Drawing.FontStyle.Bold;
                }
                else
                {
                    newFontStyle = richTextBox1.SelectionFont.Style | System.Drawing.FontStyle.Bold;
                }
                richTextBox1.SelectionFont = new System.Drawing.Font(
                    richTextBox1.SelectionFont,
                    newFontStyle
                );
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                // Get the current font of the selected text
                Font currentFont = richTextBox1.SelectionFont;

                // Toggle italic on or off based on the current font style
                FontStyle newFontStyle = currentFont.Style;

                if (currentFont.Style.HasFlag(FontStyle.Italic))
                {
                    // If italic is already applied, remove it
                    newFontStyle &= ~FontStyle.Italic;
                }
                else
                {
                    // If italic is not applied, add it
                    newFontStyle |= FontStyle.Italic;
                }

                // Apply the new font style to the selected text
                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
            else
            {
                MessageBox.Show("Please select text to make it italic.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Pencil is selected.");
            }
            else
            {
                MessageBox.Show("Pencil is not selected.");
            }

            // Check the state of the "Book" checkbox
            if (checkBox2.Checked)
            {
                MessageBox.Show("Book is selected.");
            }
            else
            {
                MessageBox.Show("Book is not selected.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("You selected: " + radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("You selected: " + radioButton2.Text);
            }
            else
            {
                MessageBox.Show("Please select an option.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "New York", "London", "Paris", "Tokyo", "Sydney" });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numericUpDown1.Value.ToString());
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label5.Text = e.Start.ToShortDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker1.Value.ToString("MMMM dd, yyyy");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}