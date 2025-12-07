using Tyuiu.MatveevaAA.Sprint6.Task0.V17.Lib;

namespace Tyuiu.MatveevaAA.Sprint6.Task0.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBoxCond_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRes_SAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX_SAA.Text)));
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxX_SAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê âûïîëíèë ñòóäåíò ãðóïïû ÀÑÎèÓá-24-1 Ñîñíèí Ô¸äîð Ìèõàéëîâè÷", "Cîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxX_SAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxInPutData_SAA_Enter(object sender, EventArgs e)
        {

        }
    }
}