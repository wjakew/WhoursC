using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whours.FileConnector;
using Whours.TimeManager;

namespace Whours
{
    public partial class Main_Window : Form
    {
        String cash_amount, hour_amount;
        OpenFileDialog openFileDialog1;
        String choosen_file;
        Details_Window dw;
        FileReader fr;
        FileParser fp;

        public Main_Window()
        {
            this.CenterToScreen();
            InitializeComponent();
            load_window();
            openFileDialog1 = new OpenFileDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cash_amount = field_money.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            hour_amount = field_hours.Text;
        }

        private void button_loadfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open record file";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            load_filename(openFileDialog1.FileName);
            choosen_file = openFileDialog1.FileName;

            // loading file

            fr = new FileReader(choosen_file);

            if ( fr.validation_flag)
            {
                fp = new FileParser(fr);
                MessageBox.Show("Found " + fp.data_obj_amount + " records");
                load_component_listbox();

                button_raportgeneration.Enabled = true;
                field_hours.Enabled = true;
                field_money.Enabled = true;
                button_loadfile.Enabled = false;
                button_createtemplate.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error loading file");
            }
        }

        // function for loading data to list
        private void load_component_listbox()
        {
            foreach(TimeManager_DayPair tmdp in fp.time_objects)
            {
                list_data.Items.Add(tmdp.prepare_glance_full());
            }
        }

        // function for loading window
        private void load_window()
        {
            button_raportgeneration.Enabled = false;
            field_hours.Enabled = false;
            field_money.Enabled = false;

        }

        private void button_raportgeneration_Click(object sender, EventArgs e)
        {
            try
            {
                cash_amount = field_money.Text;
                hour_amount = field_hours.Text;
                Debug.WriteLine("Data read from field_money: "+cash_amount);
                Debug.WriteLine("Data read from field_hours: " + hour_amount);

                double cash = double.Parse(cash_amount);
                Debug.WriteLine("Converted field_money to double value: " + cash);
                int hours = Int32.Parse(hour_amount);
                dw = new Details_Window(new Raport_Generator.Raport_GeneratorRAW(fp), cash, hours);
                dw.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wrong input " + ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // function for loading file path to label
        private void load_filename(String file_name)
        {
            int SIZE = 75;

            if ( file_name.Length > 30)
            {
                file_name = file_name.Substring(0, 30) + "...";
            }
            label_filepath.Text = file_name;
        }
    }
}
