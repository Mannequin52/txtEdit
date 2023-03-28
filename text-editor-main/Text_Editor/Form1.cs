using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            rTxtBox.Clear();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(openFileDialog.FileName))
                {
                    rTxtBox.Text = reader.ReadToEnd();
                }
            }
        }
    }
}
