using System;
using System.Windows.Forms;

namespace LongDistanceService.View
{
    public partial class LDSMessageBox : Form
    {
        private LDSMessageBox(string text, string caption)
        {
            InitializeComponent();

            labelMessage.Text = text;
            this.Text = caption;
            this.DialogResult = DialogResult.Cancel;
        }

        public static DialogResult Show(string text, string caption) =>
            new LDSMessageBox(text, caption).ShowDialog();


        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LDSMessageBox_Load(object sender, EventArgs e) =>
            FormPlacer.ToScreenCenter(this);
    }
}
