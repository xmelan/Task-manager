using System;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateProcessList();
            labelProccessCount.Text = "Procesos Actuales: " + lstProccess.Items.Count.ToString();

            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                NameProcessor.Text = "Name  -  " + obj["Name"];
                NumberOfCores.Text = "Cores  -  " + obj["NumberOfCores"];
                NumberOfEnabledCore.Text = "Enabled Core  -  " + obj["NumberOfEnabledCore"];
                NumberOfLogicalProcessors.Text = "Processors  -  " + obj["NumberOfLogicalProcessors"];
            }
        }

        private void UpdateProcessList()
        {
            lstProccess.Items.Clear();
            lstThreads.Items.Clear();
            int id = 1;

            foreach (Process itemProcess in Process.GetProcesses())
            {
                lstProccess.Items.Add(id + ":" + itemProcess.ProcessName + ": " + itemProcess.MainWindowTitle);
                lstThreads.Items.Add(id + ":" + itemProcess.Threads.Count);
                id += 1;
                Threads.Text = "Threads: "+itemProcess.Threads.Count.ToString();
            }
            labelProccessCount.Text = "Procesos Actuales: " + lstProccess.Items.Count.ToString();

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process itemProcess in Process.GetProcesses())
                {
                    string array = lstProccess.SelectedItem.ToString();
                    string[] proccess = array.Split(':');

                    if (itemProcess.ProcessName == proccess[1])
                    {
                        itemProcess.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Error al eliminar" + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnInformation_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
