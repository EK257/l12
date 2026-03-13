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
            Book myBook = new Book("Война и мир", "Лев Толстой", 1869);
            label4.Text = myBook.getInfo();

            Book unknownBook = new Book();
            label4.Text += "\n" + unknownBook.getInfo();
        }
    }
}
