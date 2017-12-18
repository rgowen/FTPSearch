using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;


namespace FTPSearch
{
    public partial class MainGUI : Form
    {
        public delegate void AddOutputCallback(string text);
           
        public void AddOutput(string line)
        {
            List<string> all = new List<String>();
            all.AddRange(textboxOutput.Lines);
            all.Add(line);
            textboxOutput.Lines = all.ToArray();
        }
        
        public MainGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FtpConnector ftp = new FtpConnector(textboxOutput);
            ftp.Connect(textboxAddresses.Lines, textBoxQuery.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void MainGUI_Load(object sender, EventArgs e)
        {

        }

        private void textboxAddresses_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
