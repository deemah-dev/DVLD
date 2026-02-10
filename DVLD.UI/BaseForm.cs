using ReaLTaiizor.Child.Material;
using System.ComponentModel;

namespace DVLD.UI
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        protected void ShowFormDialog(Form form)
        {
            Hide();
            form.ShowDialog();
            Show();
        }
        protected void TextBox_EmptyValidating(object sender, CancelEventArgs e)
        {
            MaterialBaseTextBox textBox = ((MaterialBaseTextBox)sender);
            string text = textBox.Text.Trim();
            if (Validation.Empty(text))
            {
                e.Cancel = true;
                textBox.Focus();
            }
        }
        protected void TextBox_CharsValidating(object sender, CancelEventArgs e)
        {
            var textBox = ((MaterialBaseTextBox)sender);
            string text = textBox.Text.Trim();
            if (Validation.Empty(text) || Validation.HasNumbers(text))
            {
                e.Cancel = true;
                textBox.Focus();
            }
        }
        protected void TextBox_EmailValidating(object sender, CancelEventArgs e)
        {
            var textBox = ((MaterialBaseTextBox)sender);
            string text = textBox.Text.Trim();
            if (!Validation.Empty(text) && !Validation.IsValidEmail(text))
            {
                e.Cancel = true;
                textBox.Focus();
            }
        }
        protected void TextBox_NumberValidating(object sender, CancelEventArgs e)
        {
            var textBox = ((MaterialBaseTextBox)sender);
            string text = textBox.Text.Trim();
            if (Validation.Empty(text) || !Validation.IsNumber(text))
            {
                e.Cancel = true;
                textBox.Focus();
            }
        }
        protected void TextBox_PasswordValidating(object sender, CancelEventArgs e)
        {
            var textBox = ((MaterialBaseTextBox)sender);
            string text = textBox.Text.Trim();
            if (Validation.Empty(text) || !Validation.IsValidPassword(text))
            {
                e.Cancel = true;
                textBox.Focus();
            }
        }
    }
}
