using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MVP
{
    public partial class ViewLivingCost : Form, ILivingCostView
    {
        private LivingCostPresenter presenter;

        public ViewLivingCost()
        {
            InitializeComponent();
            presenter = new LivingCostPresenter(this, new LivingCost());
        }

        void ILivingCostView.SetCost(double c)
        {
            label4.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.LoadLivingCost(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }
            catch { MessageBox.Show("Помилка введення"); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}