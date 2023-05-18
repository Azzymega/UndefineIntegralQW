using QWFramework;
using QWFramework.Export;

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
                //string s = new string("");
                //byte[] buffer = File.ReadAllBytes("C:\\Users\\Student\\Desktop\\Test.csv");
                //foreach (byte b in buffer)
                //{
                //    if (b == 13)
                //    {
                //        break;
                //    }
                //    s += (char)b;
                //} // CSV. Перебросить в фреймворк.
                //MessageBox.Show(s);
                integral = new UndefinedIntegral(textBox1.Text, new UndefineIntegralEvaluator(textBox1.Text));
                textBox2.Text = integral.ReturnAnswer();
            }
            catch
            {
                MessageBox.Show("Вы ошиблись при вводе. Поправьте ошибку.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(QWFramework.Instruction.Instruction.ReturnInstructionText());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "RTF (*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RTF rtf = new RTF(saveFileDialog.FileName, textBox2.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                CSV rtf = new CSV(saveFileDialog.FileName, textBox2.Text);
            }
        }
    }
}