using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        double cash_amount;
        int hours_amount;

        public Details_Window(Raport_GeneratorRAW source_object,double cash_amonut,int hours_amount)
        {
            this.source = source_object;
            this.cash_amount = cash_amount;
            this.hours_amount = hours_amount;

            InitializeComponent();
            load_window();
        }


        void load_window()
        {
            label_hours.Text = "Hours " + source.calculate_hours() + "/" + hours_amount;
            label_payment.Text = "Payment " + source.calculate_hours() * cash_amount + "PLN";
        }
    }
}
