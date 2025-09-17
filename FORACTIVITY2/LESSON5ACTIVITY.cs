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


        private void btn_netincome_Click(object sender, EventArgs e)
        {
            double gross_income, sss_contribution, philhealth_contribution,
            pagibig_contribution = 200.00,
            income_tax_contribution;
            double sss_loan, pagibig_loan, faculty_savings_deposit,
            faculty_savings_loan, salary_loan, other_loan,
                                total_deduction, net_income;

            gross_income = Convert.ToDouble(txtbox_summaryincomegrossincome.Text);

            if (gross_income <= 5249)
            {
                sss_contribution = 760.00;
            }
            else if (gross_income >= 5250 && gross_income <= 5749.99)
            {
                sss_contribution = 835.00;
            }
            else if (gross_income >= 5750 && gross_income <= 6249.99)
            {
                sss_contribution = 910.00;
            }
            else if (gross_income >= 6250 && gross_income <= 6749.99)
            {
                sss_contribution = 985.00;
            }
            else if (gross_income >= 6750 && gross_income <= 7249.99)
            {
                sss_contribution = 1060.00;
            }
            else if (gross_income >= 7250 && gross_income <= 7749.99)
            {
                sss_contribution = 1135.00;
            }
            else if (gross_income >= 7750 && gross_income <= 8249.99)
            {
                sss_contribution = 1210.00;
            }
            else if (gross_income >= 8250 && gross_income <= 8749.99)
            {
                sss_contribution = 1285.00;
            }
            else if (gross_income >= 8750 && gross_income <= 9249.99)
            {
                sss_contribution = 1360.00;
            }
            else if (gross_income >= 9250 && gross_income <= 9749.99)
            {
                sss_contribution = 1435.00;
            }
            else if (gross_income >= 9750 && gross_income <= 10249.99)
            {
                sss_contribution = 1510.00;
            }
            else if (gross_income >= 10250 && gross_income <= 10749.99)
            {
                sss_contribution = 1585.00;
            }
            else if (gross_income >= 10750 && gross_income <= 11249.99)
            {
                sss_contribution = 1660.00;
            }
            else if (gross_income >= 11250 && gross_income <= 11749.99)
            {
                sss_contribution = 1735.00;
            }
            else if (gross_income >= 11750 && gross_income <= 12249.99)
            {
                sss_contribution = 1810.00;
            }
            else if (gross_income >= 12250 && gross_income <= 12749.99)
            {
                sss_contribution = 1885.00;
            }
            else if (gross_income >= 12750 && gross_income <= 13249.99)
            {
                sss_contribution = 1960.00;
            }
            else if (gross_income >= 13250 && gross_income <= 13749.99)
            {
                sss_contribution = 2035.00;
            }
            else if (gross_income >= 13750 && gross_income <= 14249.99)
            {
                sss_contribution = 2110.00;
            }
            else if (gross_income >= 14250 && gross_income <= 14749.99)
            {
                sss_contribution = 2185.00;
            }
            else if (gross_income >= 14750 && gross_income <= 15249.99)
            {
                sss_contribution = 2280.00;
            }
            else if (gross_income >= 15250 && gross_income <= 15749.99)
            {
                sss_contribution = 2355.00;
            }
            else if (gross_income >= 15750 && gross_income <= 16249.99)
            {
                sss_contribution = 2430.00;
            }
            else if (gross_income >= 16250 && gross_income <= 16749.99)
            {
                sss_contribution = 2505.00;
            }
            else if (gross_income >= 16750 && gross_income <= 17249.99)
            {
                sss_contribution = 2580.00;
            }
            else if (gross_income >= 17250 && gross_income <= 17749.99)
            {
                sss_contribution = 2655.00;
            }
            else if (gross_income >= 17750 && gross_income <= 18249.99)
            {
                sss_contribution = 2730.00;
            }
            else if (gross_income >= 18250 && gross_income <= 18749.99)
            {
                sss_contribution = 2805.00;
            }
            else if (gross_income >= 18750 && gross_income <= 19249.99)
            {
                sss_contribution = 2880.00;
            }
            else if (gross_income >= 19250 && gross_income <= 19749.99)
            {
                sss_contribution = 2955.00;
            }
            else if (gross_income >= 19750 && gross_income <= 20249.99)
            {
                sss_contribution = 3030.00;
            }
            else if (gross_income >= 20250 && gross_income <= 20749.99)
            {
                sss_contribution = 3105.00;
            }
            else if (gross_income >= 20750 && gross_income <= 21249.99)
            {
                sss_contribution = 3180.00;
            }
            else if (gross_income >= 21250 && gross_income <= 21749.99)
            {
                sss_contribution = 3255.00;
            }
            else if (gross_income >= 21750 && gross_income <= 22249.99)
            {
                sss_contribution = 3330.00;
            }
            else if (gross_income >= 22250 && gross_income <= 22749.99)
            {
                sss_contribution = 3405.00;
            }
            else if (gross_income >= 22750 && gross_income <= 23249.99)
            {
                sss_contribution = 3480.00;
            }
            else if (gross_income >= 23250 && gross_income <= 23749.99)
            {
                sss_contribution = 3555.00;
            }
            else if (gross_income >= 23750 && gross_income <= 24249.99)
            {
                sss_contribution = 3630.00;
            }
            else if (gross_income >= 24250 && gross_income <= 24749.99)
            {
                sss_contribution = 3705.00;
            }
            else if (gross_income >= 24750 && gross_income <= 25249.99)
            {
                sss_contribution = 3780.00;
            }
            else if (gross_income >= 25250 && gross_income <= 25749.99)
            {
                sss_contribution = 3855.00;
            }
            else if (gross_income >= 25750 && gross_income <= 26249.99)
            {
                sss_contribution = 3930.00;
            }
            else if (gross_income >= 26250 && gross_income <= 26749.99)
            {
                sss_contribution = 4005.00;
            }
            else if (gross_income >= 26750 && gross_income <= 27249.99)
            {
                sss_contribution = 4080.00;
            }
            else if (gross_income >= 27250 && gross_income <= 27749.99)
            {
                sss_contribution = 4155.00;
            }
            else if (gross_income >= 27750 && gross_income <= 28249.99)
            {
                sss_contribution = 4230.00;
            }
            else if (gross_income >= 28250 && gross_income <= 28749.99)
            {
                sss_contribution = 4305.00;
            }
            else if (gross_income >= 28750 && gross_income <= 29249.99)
            {
                sss_contribution = 4380.00;
            }
            else if (gross_income >= 29250 && gross_income <= 29749.99)
            {
                sss_contribution = 4455.00;
            }
            else if (gross_income >= 29750 && gross_income <= 30249.99)
            {
                sss_contribution = 4530.00;
            }
            else if (gross_income >= 30250 && gross_income <= 30749.99)
            {
                sss_contribution = 4605.00;
            }
            else if (gross_income >= 30750 && gross_income <= 31249.99)
            {
                sss_contribution = 4680.00;
            }
            else if (gross_income >= 31250 && gross_income <= 31749.99)
            {
                sss_contribution = 4755.00;
            }
            else if (gross_income >= 31750 && gross_income <= 32249.99)
            {
                sss_contribution = 4830.00;
            }
            else if (gross_income >= 32250 && gross_income <= 32749.99)
            {
                sss_contribution = 4905.00;
            }
            else if (gross_income >= 32750 && gross_income <= 33249.99)
            {
                sss_contribution = 4980.00;
            }
            else if (gross_income >= 33250 && gross_income <= 33749.99)
            {
                sss_contribution = 5055.00;
            }
            else if (gross_income >= 33750 && gross_income <= 34249.99)
            {
                sss_contribution = 5130.00;
            }
            else if (gross_income >= 34250 && gross_income <= 34749.99)
            {
                sss_contribution = 5205.00;
            }
            else
            {
                sss_contribution = 5280.00;
            }

            philhealth_contribution = gross_income * 0.05;

            if (gross_income <= 250000)
            {
                income_tax_contribution = 0;
            }
            else if (gross_income <= 400000)
            {
                income_tax_contribution = 0.15 * (gross_income - 250000);
            }
            else if (gross_income <= 800000)
            {
                income_tax_contribution = 22500 + 0.20 * (gross_income - 400000);
            }
            else if (gross_income <= 2000000)
            {
                income_tax_contribution = 102500 + 0.25 * (gross_income - 800000);
            }
            else if (gross_income <= 8000000)
            {
                income_tax_contribution = 402500 + 0.30 * (gross_income - 2000000);
            }
            else
            {
                income_tax_contribution = 2202500 + 0.35 * (gross_income - 8000000);
            }

            sss_loan = Convert.ToDouble(txtbox_sssloans.Text);
            pagibig_loan = Convert.ToDouble(txtbox_pagibigloan.Text);
            faculty_savings_deposit =
            Convert.ToDouble(txtbox_facultysavingsdeposit.Text);
            faculty_savings_loan =
            Convert.ToDouble(txtbox_facultysavingsloan.Text);
            salary_loan = Convert.ToDouble(txtbox_salaryloan.Text);
            other_loan = Convert.ToDouble(txtbox_otherloans.Text);

            total_deduction = sss_contribution + philhealth_contribution +
            pagibig_contribution + income_tax_contribution +
                sss_loan + pagibig_loan + faculty_savings_deposit +
            faculty_savings_loan + salary_loan + other_loan;

            net_income = gross_income - total_deduction;

            txtbox_ssscontribution.Text =
            sss_contribution.ToString("0.00");
            txtbox_philhealthcontribution.Text =
            philhealth_contribution.ToString("0.00");
            txtbox_pagibigcontribution.Text =
            pagibig_contribution.ToString("0.00");
            txtbox_incometaxcontribution.Text =
            income_tax_contribution.ToString("0.00");

            txtbox_totaldeductions.Text = total_deduction.ToString("0.00");

            txtbox_summaryincomenetincome.Text = net_income.ToString("0.00");
        }


        public LESSON5ACTIVITY()
        {
            InitializeComponent();
            txtbox_basicincomecutofforincome.Enabled = false;
            txtbox_honorariumincomecutofforincome.Enabled = false;
            txtbox_otherincomecutofforincome.Enabled = false;
            txtbox_ssscontribution.Enabled = false;
            txtbox_philhealthcontribution.Enabled = false;
            txtbox_pagibigcontribution.Enabled = false;
            txtbox_incometaxcontribution.Enabled = false;
            txtbox_totaldeductions.Enabled = false;
            txtbox_summaryincomenetincome.Enabled = false;
            txtbox_summaryincomegrossincome.Enabled = false;



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LESSON5ACTIVITY_Load(object sender, EventArgs e)
        {

        }

        private void btn_grossincome_Click(object sender, EventArgs e)
        {
            // --- BASIC INCOME ---
           double basicrateperhour = Convert.ToDouble(txtbox_basicincomerateperhour.Text);
           double basicnumberofhour = Convert.ToInt32(txtbox_basicincomenumberofhours.Text);
           double basicincomecutoff = basicrateperhour * basicnumberofhour;

           // --- HONORARIUM INCOME ---
            double rate_honor = Convert.ToDouble(txtbox_honorariumincomerateperhour.Text);
            double hours_honor = Convert.ToInt32(txtbox_honorariumincomenumberofhours.Text);
            double honorariumincomecutoff = rate_honor * hours_honor;
            

            // --- OTHER INCOME ---
            double rate_other = Convert.ToDouble(txtbox_otherincomerateperhour.Text);
            double hours_other = Convert.ToInt32(txtbox_otherincomenumberofhours.Text);
            double otherincomecutoff = rate_other * hours_other;
            

            // --- GROSS INCOME (sum of all three) ---
            double grossincome = basicincomecutoff+ honorariumincomecutoff + otherincomecutoff;

            txtbox_summaryincomegrossincome.Text = grossincome.ToString("0.00");
            txtbox_basicincomecutofforincome.Text = basicincomecutoff.ToString("0.00");
            txtbox_honorariumincomecutofforincome.Text = honorariumincomecutoff.ToString("0.00");
            txtbox_otherincomecutofforincome.Text = otherincomecutoff.ToString("0.00");

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txtbox_basicincomecutofforincome.Clear();
            txtbox_basicincomenumberofhours.Clear();
            txtbox_basicincomerateperhour.Clear();
            txtbox_civilstatus.Clear();
            txtbox_department.Clear();
            txtbox_designation.Clear();
            txtbox_employeenumber.Clear();
            txtbox_employeestatus.Clear();
            txtbox_facultysavingsdeposit.Clear();
            txtbox_facultysavingsloan.Clear();
            txtbox_honorariumincomecutofforincome.Clear();
            txtbox_honorariumincomenumberofhours.Clear();
            txtbox_honorariumincomerateperhour.Clear();
            txtbox_incometaxcontribution.Clear();
            txtbox_otherincomecutofforincome.Clear();
            txtbox_otherincomenumberofhours.Clear();
            txtbox_otherincomerateperhour.Clear();
            txtbox_otherloans.Clear();
            txtbox_pagibigcontribution.Clear();
            txtbox_pagibigloan.Clear();
            txtbox_philhealthcontribution.Clear();
            txtbox_qualifieddependentstatus.Clear();
            txtbox_salaryloan.Clear();
            txtbox_ssscontribution.Clear();
            txtbox_sssloans.Clear();
            txtbox_summaryincomegrossincome.Clear();
            txtbox_summaryincomenetincome.Clear();
            txtbox_totaldeductions.Clear();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            PrelimExamDSALESSON5ACTIVITY printForm = new PrelimExamDSALESSON5ACTIVITY();

            printForm.textbox_company.Text = "Lyceum of the Philippines University - Cavite";
            printForm.textbox_employeecode.Text = txtbox_employeenumber.Text;
            printForm.textbox_department.Text = txtbox_department.Text;
            printForm.textbox_employeename.Text = txtbox_firstname.Text + " " + txtbox_middlename.Text + " " + txtbox_surname.Text;
            printForm.textbox_payperiod.Text = datetimepickerpaydate.Text;
            printForm.textbox_cutoff.Text = datetimepickerpaydate.Text;

            printForm.textbox_basicincome.Text = txtbox_basicincomecutofforincome.Text;
            printForm.textbox_overtime.Text = txtbox_honorariumincomecutofforincome.Text;
            printForm.textbox_honorarium.Text = txtbox_otherincomecutofforincome.Text;
            printForm.textbox_honorariumadjustment.Text = "0.00";
            printForm.textbox_substitution.Text = "0.00";
            printForm.textbox_tardy.Text = "0.00";

            printForm.textbox_withholdingtax.Text = txtbox_incometaxcontribution.Text;
            printForm.textbox_ssscontribution.Text = txtbox_ssscontribution.Text;
            printForm.textbox_philhealthcontribution.Text = txtbox_philhealthcontribution.Text;
            printForm.textbox_hdmfcontribution.Text = txtbox_pagibigcontribution.Text;
            printForm.textbox_ssswispcontribution.Text = "750.00";

            printForm.textbox_earnings.Text = txtbox_summaryincomegrossincome.Text;
            printForm.textbox_deductions.Text = txtbox_totaldeductions.Text;
            printForm.textbox_overtime_2.Text = txtbox_otherincomecutofforincome.Text;

            printForm.textbox_grossearnings.Text = txtbox_summaryincomegrossincome.Text;
            printForm.textbox_deductions_2.Text = txtbox_totaldeductions.Text;
            printForm.textbox_netpay.Text = txtbox_summaryincomenetincome.Text;

            printForm.Show();
        }
    }
}
