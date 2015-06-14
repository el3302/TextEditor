using System;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace TextEditor
{
    partial class AboutComTech : Form
    {
        public AboutComTech()
        {
            InitializeComponent();
        }

        private void AboutComTech_Load(object sender, EventArgs e)
        {
            StreamReader sr;
            sr = File.OpenText(@"C:\Users\iainm\documents\visual studio 2015\Projects\TextEditor\TextEditor\Resources\AboutComTech.txt");
            aboutText.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
