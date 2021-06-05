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
using Whours.Raport_Generator;

namespace Whours
{
    public partial class Details_Window : Form
    {
        Raport_GeneratorRAW source;
        double cash;
        int hours_amount;

        public Details_Window(Raport_GeneratorRAW source_object,double cash_amonut,int hours_amount)
        {
            this.source = source_object;
            this.cash = cash_amonut;
            this.hours_amount = hours_amount;

            InitializeComponent();
            load_window();
        }

        // function for loading window
        void load_window()
        {
            double cash_data = source.calculate_hours() * cash;
            Debug.WriteLine("calculated hours: " + source.calculate_hours());
            Debug.WriteLine("cash: " + cash);
            label_hours.Text = "Hours " + source.calculate_hours() + "/" + hours_amount;
            label_payment.Text = "Payment " + cash_data + "PLN";
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
