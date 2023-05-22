using QWFramework;
using QWFramework.Export;
using QWFramework.Import;

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
            integral = new UndefinedIntegral(textBox1.Text, new UndefineIntegralEvaluator(textBox1.Text));
            textBox2.Text = integral.ReturnAnswer();
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
            saveFileDialog.Filter = "XLSX (*.xlsx)|*.XLSX";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XLSX rtf = new XLSX(saveFileDialog.FileName, textBox2.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XLSX (*.xlsx)|*.XLSX";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XLSXImporter importer = new XLSXImporter();
                importer.Import(openFileDialog.FileName);
                textBox1.Text = importer.ReturnOutput();
            }
        }
    }
}