using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Choose Source file";
            fileDialog.InitialDirectory = @"C:\";
            fileDialog.RestoreDirectory = true;
            fileDialog.Filter = "Text|*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
                textBoxInputFile.Text = fileDialog.FileName;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var inputFile = textBoxInputFile.Text;
            listBoxSourceFiles.Items.Add(inputFile);
        }

        private void buttonXml_Click(object sender, EventArgs e)
        {
            List<String> sourceFilesList = new List<string>();

            foreach (string file in listBoxSourceFiles.Items)
            {
                sourceFilesList.Add(file);
            }
            if (sourceFilesList.Count == 0)
            {
                MessageBox.Show("Please add any files");
            }
            else
            {
                WriterInvokerImplementation invoker = new WriterInvokerImplementation();
                invoker.getWriter("X");
                XmlWriter xml = new XmlWriter();
                xml.write(sourceFilesList, @"C:\sonia\output.xml");
                MessageBox.Show("Xml Created");
            }
        }

        private void buttonHtml_Click(object sender, EventArgs e)
        {
            List<String> sourceFilesList = new List<string>();

            foreach (string file in listBoxSourceFiles.Items)
            {

                sourceFilesList.Add(file);
            }
            if (sourceFilesList.Count == 0)
            {
                MessageBox.Show("Please add any files");
            }
            else
            {
                WriterInvokerImplementation invoker = new WriterInvokerImplementation();
                invoker.getWriter("H");
                HtmlWriter html = new HtmlWriter();
                html.write(sourceFilesList, @"C:\sonia\output.html");
                MessageBox.Show("Html Created");
            }
        }
    }
}
