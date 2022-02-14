using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _1_RegEx_Base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfFileSearch = new OpenFileDialog();
            opfFileSearch.InitialDirectory = "c:\\";
            opfFileSearch.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            opfFileSearch.FilterIndex = 2;
            opfFileSearch.RestoreDirectory = true;

            if (opfFileSearch.ShowDialog() == DialogResult.OK) ;
            {
                txtFile.Text = opfFileSearch.FileName;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
            if (txtFile.Text.Length > 0)
            {
                foreach (string line in System.IO.File.ReadLines(txtFile.Text))
                {
                    txtResults.AppendText(line);
                    txtResults.AppendText(Environment.NewLine);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
            if ((txtFile.Text.Length > 0) && (txtPattern.Text.Length > 0))
            {
                Regex r = new Regex(txtPattern.Text, RegexOptions.IgnoreCase);
                foreach (string line in System.IO.File.ReadLines(txtFile.Text))
                {
                    if (r.IsMatch(line)) 
                    {
                        txtResults.AppendText(line);
                        txtResults.AppendText(Environment.NewLine);
                    }
                    
                }
            }
        }
    }
}
