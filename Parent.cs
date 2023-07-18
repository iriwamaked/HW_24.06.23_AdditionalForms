namespace HW_24._06._23
{
    public partial class Parent : Form
    {
        Child child = new Child();
        public Parent()
        {
            InitializeComponent();
        }

        private void Parent_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(100, 100);
            
            child.StartPosition = FormStartPosition.Manual;
            child.Location = new Point(750, 100);
            child.Show();
            child.textBox1.TextChanged += ChildTextBox_TextChanged;
        }

        private void textParent_TextChanged(object sender, EventArgs e)
        {
            child.textBox1.Text = textParent.Text;
        }

        private void ChildTextBox_TextChanged(object sender, EventArgs e)
        {
            textParent.Text = child.textBox1.Text;
        }
    }
}