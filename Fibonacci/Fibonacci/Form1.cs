namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0 , y =1 ,z;
            for (int i = 0; i < 50; i++)
            {
                z = x + y;
                listBox1.Items.Add(z);
                x = y;
                y = z;
            }
        }
    }
}