using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Memory;

namespace DotETrainer
{
    public partial class MainForm : Form
    {
        Mem m = new Mem();

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool VirtualFreeEx(IntPtr hProcess, UIntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);

        public bool DeAllocRegion(UIntPtr codecavebase, IntPtr openedHandle)
        {
            // maybe check if codecavebase is uintptr.zero and openedhandle is intptr.zero etc

            return VirtualFreeEx(openedHandle, codecavebase, (UIntPtr)0, 0x00008000);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        bool ProcOpen = false;
        private UIntPtr codeCaveHealth;

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

        private void experimentalHealth_CheckedChanged(object sender, EventArgs e)
        {
            if (experimentalHealth.Checked)
            {
                byte[] newBytes =
                {
                   0xC7, 0x83, 0x78, 0x05, 0x00, 0x00, 0x00, 0x40, 0x9C, 0x45
                };
                codeCaveHealth = m.CreateCodeCave("DragonGame-Win64-Shipping.exe+95B549", newBytes, 8, 2048);
                Debug.WriteLine("Address: " + codeCaveHealth.ToString());
                m.FreezeValue("DragonGame-Win64-Shipping.exe+03E6EC10,0,20,618", "float", "1");
            }
            else
            {
                DeAllocRegion(codeCaveHealth, m.mProc.Handle);
                m.WriteMemory("DragonGame-Win64-Shipping.exe+95B549", "bytes", "F3 0F 11 B3 78 05 00 00");
                m.UnfreezeValue("DragonGame-Win64-Shipping.exe+03E6EC10,0,20,618");
            }
        }
    }
}
