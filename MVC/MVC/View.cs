namespace MVC
{
    public partial class View : Form
    {
        ControllerLivingCost controller = new ControllerLivingCost();

        public View()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var salary = Convert.ToDouble(textBox1.Text);
                var index = Convert.ToDouble(textBox2.Text);
                label4.Text = controller.Question(salary, index).ToString();
            }
            catch { MessageBox.Show("Помилка введення"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}