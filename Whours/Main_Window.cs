using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whours
{
    public partial class Main_Window : Form
    {
        String cash_amount, hour_amount;
        OpenFileDialog openFileDialog1;
        String choosen_file;

        public Main_Window()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_loadfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open record file";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            label_filepath.Text = openFileDialog1.FileName;
            choosen_file = openFileDialog1.FileName;
        }

        // function for loading window
        private void load_window()
        {

        }
    }
}
