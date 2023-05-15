using QWFramework;
namespace UndefineIntegralQW
{
    public partial class Form1 : Form
    {
        private UndefinedIntegral integral;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                integral = new UndefinedIntegral(textBox1.Text,new UndefineIntegralEvaluator(textBox1.Text));
                textBox2.Text = integral.ReturnAnswer();
            }
            catch
            {
                MessageBox.Show("Вы ошиблись при вводе. Поправьте ошибку.");
            }
        }
    }
}