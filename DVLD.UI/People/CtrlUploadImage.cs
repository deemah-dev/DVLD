using System.IO;
using System.Windows.Forms;

namespace DVLD.UI
{
    public partial class CtrlUploadImage : UserControl
    {
        public CtrlUploadImage()
        {
            InitializeComponent();
        }
        public event EventHandler<string?>? SelectedImageChanged;
        public string? ImageLocation { get; private set; }

        private void GetFileDialogReady()
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select Image";
            openFileDialog1.Multiselect = false;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
        }

        private void SetImageToPicturBox(string selectedFilePath)
        {
            using (var fs = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
            {
                hopePictureBox1.Image = Image.FromStream(fs);
            }
        }

        private void LoadImageFromFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                SetImageToPicturBox(selectedFilePath);
                lblEnterToUpload.Visible = false;
                lnkLblRemove.Visible = true;
                lnkLblEdit.Visible = true;
                SelectedImageChanged?.Invoke(this, selectedFilePath);
                ImageLocation = selectedFilePath;
            }
        }

        public void LoadImage(string imagePath)
        {
            string selectedFilePath = imagePath;
            SetImageToPicturBox(selectedFilePath);
            lblEnterToUpload.Visible = false;
            lnkLblRemove.Visible = true;
            lnkLblEdit.Visible = true;
            ImageLocation = selectedFilePath;
        }

        public void Clear()
        {
            hopePictureBox1.Image?.Dispose();
            hopePictureBox1.Image = null;
            lblEnterToUpload.Visible = true;
            lnkLblEdit.Visible = false;
            lnkLblRemove.Visible = false;
            ImageLocation = "";
        }

        private void hopePictureBox1_Click(object sender, EventArgs e)
        {
            GetFileDialogReady();
            LoadImageFromFile();
        }

        private void lnkLblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            SelectedImageChanged?.Invoke(this, null);
        }

        private void lnkLblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetFileDialogReady();
            LoadImageFromFile();
        }
    }
}
