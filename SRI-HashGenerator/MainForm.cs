using System;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;
using SRIHashGenerator.Properties;

namespace SRIHashGenerator
{
    public partial class MainForm : Form
    {

        private readonly string js = "<script src=\"{0}\" integrity=\"{1}-{2}\" crossorigin=\"anonymous\"></script>";
        private readonly string css = "<link rel=\"stylesheet\" href=\"{0}\" integrity=\"{1}-{2}\" crossorigin=\"anonymous\">";

        public MainForm()
        {
            InitializeComponent();
        }

        private async void generateButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();

            if (string.IsNullOrWhiteSpace(inputTextBox.Text))
            {
                MessageBox.Show(Resources.MainForm_generateButton_Click_Input_URLs_list_cannot_be_empty, Resources.MainForm_generateButton_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var wc = new WebClient())
            {
                foreach (var line in inputTextBox.Lines)
                {
                    var trimmedLine = line.Trim();
                    if (Uri.IsWellFormedUriString(trimmedLine, UriKind.Absolute))
                    {
                        byte[] fileData = await wc.DownloadDataTaskAsync(trimmedLine);

                        HashType hashAlg = GetHashAlgo();
                        string hash = GenerateSRIHash(fileData, hashAlg);

                        if (trimmedLine.EndsWith(".css"))
                        {
                            outputTextBox.AppendText(string.Format(css, trimmedLine, hashAlg.ToString().ToLower(), hash));

                        }
                        else if (line.EndsWith(".js"))
                        {
                            outputTextBox.AppendText(string.Format(js, trimmedLine, hashAlg.ToString().ToLower(), hash));
                        }
                        else
                        {
                            outputTextBox.AppendText($"{hashAlg.ToString().ToLower()}-{hash}{Environment.NewLine}");
                        }
                        outputTextBox.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        outputTextBox.AppendText($"⚠️ INVALID URL: {trimmedLine}");
                    }
                }
            }
        }

        private HashType GetHashAlgo()
        {
            if (sha256Radio.Checked)
            {
                return HashType.SHA256;
            }
            if (sha384Radio.Checked)
            {
                return HashType.SHA384;
            }
            if (sha512Radio.Checked)
            {
                return HashType.SHA512;
            }

            return HashType.SHA384;
        }

        enum HashType
        {
            SHA256,
            SHA384,
            SHA512
        }

        private string GenerateSRIHash(byte[] inputBytes, HashType hashType)
        {
            HashAlgorithm hasher = null;

            switch (hashType)
            {
                case HashType.SHA256:
                    hasher = SHA256.Create();
                    break;
                case HashType.SHA384:
                    hasher = SHA384.Create();
                    break;
                case HashType.SHA512:
                    hasher = SHA512.Create();
                    break;
                default:
                    hasher = SHA384.Create();
                    break;
            }
            var hashedBytes = hasher.ComputeHash(inputBytes);
            return Convert.ToBase64String(hashedBytes);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                inputTextBox.AppendText($"{file}{Environment.NewLine}");
            }
        }
    }
}
