using System;
using System.Windows.Forms;

namespace LongDistanceService.View.CustomerView
{
    public partial class FormCustomerMenu : Form
    {
        private Form _form;
        public FormCustomerMenu(FormLogIn _form)
        {
            InitializeComponent();

            this._form = _form;

            this._form.Hide();
            FormClosed += FormCustomerMenu_FormClosed;
        }

        private void FormCustomerMenu_FormClosed(object sender, FormClosedEventArgs e) => 
            _form.Visible = true;

        public static DialogResult Show(FormLogIn form) => new FormCustomerMenu(form).ShowDialog();

        private void FormCustomerMenu_Load(object sender, EventArgs e) =>
            FormPlacer.ToScreenCenter(this);
        
        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            FormMakeOrder form = new FormMakeOrder();
            form.ShowDialog();
        }
    }
}
