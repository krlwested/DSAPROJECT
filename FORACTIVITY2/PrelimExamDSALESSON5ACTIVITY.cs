﻿using System;
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
    public partial class PrelimExamDSALESSON5ACTIVITY : Form
    {
        public PrelimExamDSALESSON5ACTIVITY()
        {
            InitializeComponent();
        }

        private void PrelimExamDSALESSON5ACTIVITY_Load(object sender, EventArgs e)
        {
            textbox_company.Enabled = false;
            textbox_employeecode.Enabled = false;
            textbox_employeename.Enabled = false;
            textbox_department.Enabled = false;
            textbox_cutoff.Enabled = false;
            textbox_payperiod.Enabled = false;

            textbox_basicincome.Enabled = false;
            textbox_overtime.Enabled = false;
            textbox_honorarium.Enabled = false;
            textbox_honorariumadjustment.Enabled = false;
            textbox_substitution.Enabled = false;
            textbox_tardy.Enabled = false;

            textbox_withholdingtax.Enabled = false;
            textbox_ssscontribution.Enabled = false;
            textbox_philhealthcontribution.Enabled = false;
            textbox_hdmfcontribution.Enabled = false;
            textbox_ssswispcontribution.Enabled = false;

            textbox_earnings.Enabled = false;
            textbox_deductions.Enabled = false;
            textbox_overtime_2.Enabled = false;

            textbox_grossearnings.Enabled = false;
            textbox_deductions_2.Enabled = false;
            textbox_netpay.Enabled = false;
        }
    }
}
