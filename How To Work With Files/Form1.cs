namespace How_To_Work_With_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtDisplayFilePath.Text = openFileDialog1.FileName;
            txtFileName.Text = openFileDialog1.SafeFileName;

            string s = System.IO.File.ReadAllText(openFileDialog1.FileName);
            txtDisplayFile.Text = s;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(txtDisplayFilePath.Text, txtDisplayFile.Text);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (RbtnFile.Checked == true)
                System.IO.File.Create(txtCreate.Text);

            else if (RbtnDirectory.Checked == true)
                System.IO.Directory.CreateDirectory(txtCreate.Text);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string[] s = System.IO.Directory.GetFiles(folderBrowserDialog1.SelectedPath);
            for (int i = 0; i < s.Length; i++)
            {
                listBox1.Items.Add(s[i]).ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDisplayFile.Text = System.IO.File.ReadAllText(listBox1.Items[listBox1.SelectedIndex].ToString());
        }
    }
}
