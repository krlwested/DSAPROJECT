using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORACTIVITY2
{
    public partial class LESSON5ACTIVITY : Form
    {
        private string picpath;
        private double basic_netincome = 0.00,
            basic_numberofhours = 0.00,
            basic_hourlyrate = 0.00,
            honorarium_netincome = 0.00,
            honorarium_numberofhours = 0.00,
            honorarium_hourlyrate = 0.00,
            other_netincome = 0.00,
            other_numberofhours = 0.00,
            other_hourlyrate = 0.00;
        private double total_netincome = 0.00,
            gross_income = 0.00,
            sss_contribution = 0.00,
            pagibig_contribution = 0.00,
            philhealth_contribution = 0.00,
            tax_contribution = 0.00;


        public LESSON5ACTIVITY()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LESSON5ACTIVITY_Load(object sender, EventArgs e)
        {
            txtbox_department.Enabled = false;
            txtbox_basicincomecutofforincome.Enabled = false;
            txtbox_honorariumincomecutofforincome.Enabled = false;
            txtbox_otherincomecutofforincome.Enabled = false;
            txtbox_summaryincomenetincome.Enabled = false;
            txtbox_firstname.Enabled = false;
            txtbox_middlename.Enabled = false;
            txtbox_surname.Enabled = false;
            txtbox_civilstatus.Enabled = false;
            txtbox_employeestatus.Enabled = false;
            txtbox_designation.Enabled = false;
            txtbox_ssscontribution.Enabled = false;
            txtbox_philhealthcontribution.Enabled = false;
            txtbox_pagibigcontribution.Enabled = false;
            txtbox_incometaxcontribution.Enabled = false;
        }
    }
}
