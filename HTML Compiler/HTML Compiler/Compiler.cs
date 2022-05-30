using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_Compiler
{
    public partial class Compiler : Form
    {
        public Compiler()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string html = fastColoredTextBox1.Text;//grab HTML
            if (textBox1.Text.EndsWith(".html")) 
            {
                MessageBox.Show("URL box contains a URL, downloading.\n\nBy the way make sure it contains .html at the end!","Mr. Mike Cox");
                WebClient ccc = new WebClient();
                //made by clxyify
                webBrowser1.DocumentText = ccc.DownloadString(textBox1.Text);
                fastColoredTextBox1.Text = ccc.DownloadString(textBox1.Text);
                textBox1.Text = "";

            }
            else 
            {
                try
                {
                    webBrowser1.DocumentText = html + "<p>Developed by Clxyify! - github.com/clxyify </p>";//yep it's this simple!
                }
                catch (Exception)
                {
                    ;//my enemy

                    webBrowser1.DocumentText = "<p>HTML could not be compiled successfully.</p>";//return an error
                }
            }
        }

        private void refreshHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();//refresh browserrrrrr
        }

        private void developedByClxyifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void saveHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("HTML_saved.html", fastColoredTextBox1.Text + "<p>Developed by Clxyify - Saved HTML btw.</p>");
        }
    }
}
