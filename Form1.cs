using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Depreciation_Calculator
{
    public partial class Form1 : Form
    {
        double initialCost, salvageValue, depreciation, currentValue = 0;
        int usefulLife;
        int sumOfYears = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateScheduleButton_Click(object sender, EventArgs e)
        {
            //input
            initialCost = Convert.ToDouble(InitialCostTextBox.Text);
            salvageValue = Convert.ToDouble(SalvageValueTextBox.Text);
            usefulLife = Convert.ToInt16(UsefulLifeComboBox.Text);
            currentValue = initialCost;
            sumOfYears = 0;

            //process
            OutputListBox.Items.Clear();
            const string formatString = "{0, -20}{1, -40:0.00}{2, -25:0.00}{3, -20:0.00}";
            const string formatString1 = "{0, -35}{1, -35:0.00}{2, -30:0.00}{3, -20:0.00}";
            OutputListBox.Items.Add(string.Format(formatString, "Year", "Book Value (Beginning of Year)", "Depreciation", "Book Value (End of Year)"));
            if (StraightLineComboBox.Checked)
            {
                depreciation = (initialCost - salvageValue) / usefulLife;
                //output
                for (int i = 0; i < usefulLife; i++)
                {
                    OutputListBox.Items.Add(string.Format(formatString1, i + 1, currentValue, depreciation, CalculateStraightLine(initialCost, depreciation).ToString("F2")));
                }
            }
            else
            {
                for(int i = 0; i <= usefulLife; i++)
                {
                    sumOfYears += i;
                }
                int tempYear = usefulLife;
                currentValue = initialCost - salvageValue;
                for (int i = 0; i < usefulLife; i++)
                {
                    depreciation =  ((double) tempYear / (double) sumOfYears);
                    OutputListBox.Items.Add(string.Format(formatString1, i + 1, currentValue, tempYear + "/" + sumOfYears, CalculateSumOfYears().ToString("F2")));
                    tempYear--;
                }
            }
        }

        private double CalculateStraightLine(double initialCost, double depreciation)
        {
            currentValue -= depreciation;
            return currentValue;
        }

        private double CalculateSumOfYears()
        {
            double expense = depreciation * currentValue;
            currentValue -= Convert.ToInt32(expense);
            return expense;        
        }
    }
}
