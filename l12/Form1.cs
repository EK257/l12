namespace l12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String title = textBox1.Text.Trim();
            String author = textBox2.Text.Trim();
            int year = (int)numericUpDown1.Value;

            Book myBook = new Book(title, author, year);

            label4.Text = myBook.getInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book unknownBook = new Book();
            label4.Text = unknownBook.getInfo();
        }
    }
}
