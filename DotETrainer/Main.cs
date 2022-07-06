using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Keystone;
using Memory;

namespace DotETrainer
{
    public partial class MainForm : Form
    {
        Mem m = new Mem();

        public MainForm()
        {
            InitializeComponent();
        }

        bool ProcOpen = false;

        private void MainForm_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess("DragonGame-Win64-Shipping");

            Thread.Sleep(100);
            BGWorker.ReportProgress(0);
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                ProcOpenLabel.ForeColor = Color.Green;
                ProcOpenLabel.Text = "Yes";
            }
            else
            {
                ProcOpenLabel.ForeColor = Color.Red;
                ProcOpenLabel.Text = "N/A";
                return; // do not continue if process is not available/open
            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void infhealth_CheckedChanged(object sender, EventArgs e)
        {
            if (infhealth.Checked)
            {
                m.FreezeValue("DragonGame-Win64-Shipping.exe+03E64C90,30,250,578", "float", "500");
            }
            else
            {
                m.UnfreezeValue("DragonGame-Win64-Shipping.exe+03E64C90,30,250,578");
            }
        }

        private void infstamina_CheckedChanged(object sender, EventArgs e)
        {
            if (infstamina.Checked)
            {
                m.FreezeValue("DragonGame-Win64-Shipping.exe+03E6EC10,0,A0,53C", "float", "1000");
            }
            else
            {
                m.UnfreezeValue("DragonGame - Win64 - Shipping.exe+03E6EC100,0,A0,53C");
            }
        }

        private void infhunger_CheckedChanged(object sender, EventArgs e)
        {
            if (infhunger.Checked)
            {
                m.FreezeValue("DragonGame-Win64-Shipping.exe+03E6EC10,0,A0,54C", "float", "1500");
            }
            else
            {
                m.UnfreezeValue("DragonGame-Win64-Shipping.exe+03E6EC10,0,A0,54C");
            }
        }

        private void infthirst_CheckedChanged(object sender, EventArgs e)
        {
            if (infthirst.Checked)
            {
                m.FreezeValue("DragonGame-Win64-Shipping.exe+03E64C90,30,250,554", "float", "500");
            }
            else
            {
                m.UnfreezeValue("DragonGame-Win64-Shipping.exe+03E64C90,30,250,554");
            }
        }

        private void inffuel_CheckedChanged(object sender, EventArgs e)
        {
            if (inffuel.Checked)
            {
                m.FreezeValue("DragonGame-Win64-Shipping.exe+03E64C90,30,250,560,4", "float", "6");
            }
            else
            {
                m.UnfreezeValue("DragonGame-Win64-Shipping.exe+03E64C90,30,250,560,4");
            }
        }
    }
}
