using QWFramework;
namespace UndefineIntegralQW
{
    public partial class Form1 : Form
    {
        private UndefinedIntegral? integral;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = new string("");
                byte[] buffer = File.ReadAllBytes("C:\\Users\\Student\\Desktop\\Test.csv");
                foreach (byte b in buffer)
                {
                    if (b == 13)
                    {
                        break;
                    }
                    s += (char)b;
                } // CSV. Перебросить в фреймворк.
                MessageBox.Show(s);
                integral = new UndefinedIntegral(s, new UndefineIntegralEvaluator(s));
                textBox2.Text = integral.ReturnAnswer();
            }
            catch
            {
                MessageBox.Show("Вы ошиблись при вводе. Поправьте ошибку.");
            }
        }
    }
}