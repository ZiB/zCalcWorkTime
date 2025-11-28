using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zCalcWorkTime
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TextBox_TimeTx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar) == false) && (e.KeyChar != ',') && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBox_TimeTx_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(TextBox_TimeTx.Text, out var timeTx) == false)
                return;

            if (double.TryParse(TextBox_TimeRx.Text, out var timeRx) == false)
                return;

            if (double.TryParse(TextBox_TimeWork.Text, out var timeWork) == false)
                return;

            if (double.TryParse(TextBox_TimeWait.Text, out var timeWait) == false)
                return;

            if (double.TryParse(TextBox_CurrentTx.Text, out var currentTx) == false)
                return;

            if (double.TryParse(TextBox_CurrentRx.Text, out var currentRx) == false)
                return;

            if (double.TryParse(TextBox_CurrentWork.Text, out var currentWork) == false)
                return;

            if (double.TryParse(TextBox_CurrentWait.Text, out var currentWait) == false)
                return;

            if (double.TryParse(TextBox_CurrentSleep.Text, out var currentSleep) == false)
                return;

            if (double.TryParse(TextBox_ErrorPercent.Text, out var errorPercent) == false)
                return;

            if (double.TryParse(TextBox_TxWithACK.Text, out var txWithACK) == false)
                return;

            if (double.TryParse(TextBox_TxWithoutACK.Text, out var txWithoutACK) == false)
                return;

            if (double.TryParse(TextBox_BatteryCapacity.Text, out var batteryCapacity) == false)
                return;

            if (double.TryParse(TextBox_RxTimeout.Text, out var rxTimeout) == false)
                return;

            double current = 0;

            errorPercent = 1.0 + errorPercent / 100.0;

            current += (currentTx * timeTx / (3600.0 * 1000.0)) * (txWithACK * errorPercent + txWithoutACK);
            current += (currentRx * timeRx / (3600.0 * 1000.0)) * txWithACK * errorPercent;
            current += (currentRx * rxTimeout / (3600.0 * 1000.0)) * txWithACK * (errorPercent - 1.0);
            current += (currentWork * timeWork / (3600.0 * 1000.0)) * (txWithACK * errorPercent + txWithoutACK);
            current += (currentWait * timeWait / (3600.0 * 1000.0)) * txWithACK * errorPercent;
            current += currentSleep;

            TextBox_Current.Text = (current * 1000).ToString("0.0");

            TextBox_TimeHours.Text = (batteryCapacity / (current)).ToString("0");
            TextBox_TimeDays.Text = (batteryCapacity / (current * 24)).ToString("0");
            TextBox_TimeMonth.Text = (batteryCapacity / (current * 24 * 31)).ToString("0.0");
            TextBox_TimeYears.Text = (batteryCapacity / (current * 24 * 365)).ToString("0.00");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TextBox_TxWithACK.Text = "0";
        }
    }
}
