using System;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class ReleaseNotes : Form
    {
        public ReleaseNotes()
        {
            InitializeComponent();
        }

        private void ReleaseNotes_Load(object sender, EventArgs e)
        {
            StreamReader sr;
            sr = File.OpenText(@"C:\Users\iainm\documents\visual studio 2015\Projects\TextEditor\TextEditor\Resources\ReleaseNotes.txt");
            txt.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
