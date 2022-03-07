using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoMobileRepair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //initialization
            Double ttlparts, ttlsup, hreq, hrate, ttllabcost, ttlcost,vatparts,vatsupplies,vatlab,totalvat,ttlamt;

            // Getting Values from textbox
            ttlparts = Convert.ToDouble(txt_repairparts.Text);
            ttlsup = Convert.ToDouble(txt_supplies.Text);
            hreq = Convert.ToDouble(txt_timereq.Text);
            hrate = Convert.ToDouble(txt_hourrate.Text);

            //Calculate total Cost and display in label
            ttllabcost = hreq * hrate;
            ttlcost = ttllabcost + ttlsup + ttlparts;

            lbl_ttlcost.Text = "$ " + ttlcost.ToString("N2");

            // calculate vat

            vatparts = ttlparts * 5 / 100;
            vatsupplies = ttlsup * 7 / 100;
            vatlab = ttllabcost * 5 / 100;
            totalvat = vatparts + vatsupplies + vatlab;

            //Display vat and total amount

            lbl_ttlpartsvat.Text = "$ " + vatparts.ToString("N2");
            lbl_ttlsuppliesvat.Text = "$ " + vatsupplies.ToString("N2");
            lbl_ttllabourvat.Text = "$ " + vatlab.ToString("N2");
            lbl_ttlvat.Text = "$ " + totalvat.ToString("N2");
            ttlamt = ttlcost + totalvat;
            lbl_grandamt.Text = "$ " + ttlamt.ToString("N2");

        }

        // Reset all values

        private void btn_reset_Click(object sender, EventArgs e)
        {
           txt_repairparts.Text = "";
           txt_supplies.Text = "";
           txt_timereq.Text = "";
           txt_hourrate.Text = "";
           lbl_ttlpartsvat.Text = "0";
           lbl_ttlsuppliesvat.Text = "0";
           lbl_ttllabourvat.Text = "0";
           lbl_ttlvat.Text = "0";
           lbl_ttlcost.Text = "0";
           lbl_grandamt.Text = "0";

        }

        // Exit Application

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
           

        }

       

       
       

       
    }
}
