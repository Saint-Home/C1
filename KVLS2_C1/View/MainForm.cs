using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;
using System.Threading;
using System.IO;




namespace KVLS2_C1
{

    public partial class MainForm : Form
    {

        System.Diagnostics.Process ps;
        public const Int64 GB = (1024 * 1024 * 1024);

        WMI_Form WMI_Form;
        static Computer _thisComputer;
        static FileStream _fs;
        
        


        #region Main Form 시작
        public MainForm()
        {
            InitializeComponent();
            
            SetControll_Init();
            
        }

        #endregion

        private void SetControll_Init()
        {
            this.Focus();

            tBox_SSD.BorderStyle = BorderStyle.None;
            tBox_SSD.Enabled = false;
            tBox_SSD.Refresh();

            tBox_SBC1.BorderStyle = BorderStyle.None;
            tBox_SBC1.Enabled = false;
            tBox_SBC1.Refresh();


            Thread worker = new Thread(UpdateUIControl);
            //Thread worker = new Thread(new ThreadStart(RunProcess));
            worker.Start();   

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ManagementObjectSearcher objdesk = new ManagementObjectSearcher("select * from Win32_DesktopMonitor");

            foreach (ManagementObject obj in objdesk.Get())
            {
                listBox1.Items.Add("Name  -  " + obj["Name"]);
                listBox1.Items.Add("DeviceID  -  " + obj["DeviceID"]);
                listBox1.Items.Add("Caption  -  " + obj["Caption"]);
                listBox1.Items.Add("Description  -  " + obj["Description"]);
                listBox1.Items.Add("MonitorManufacturer  -  " + obj["MonitorManufacturer"]);
                listBox1.Items.Add("MonitorType  -  " + obj["MonitorType"]);
                listBox1.Items.Add("ScreenHeight  -  " + obj["ScreenHeight"]);
                listBox1.Items.Add("ScreenWidth  -  " + obj["ScreenWidth"]);
                listBox1.Items.Add("ConfigManagerErrorCode  -  " + obj["ConfigManagerErrorCode"]);
            }

            WMI_Form = new WMI_Form();
            WMI_Form.Show();
         
            
        }


        private void UpdateUIControl()
        {
            try
            {
                while (true)
                {
                    SBC_CPUInfoUpdate();
                    SSD_MemoryUpdate();

                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                throw;
                ps.Kill();
                WMI_Form.Close();

            }

        }

        private void SBC_CPUInfoUpdate()
        {
            
            _thisComputer = new Computer() { CPUEnabled = true, GPUEnabled = true, MainboardEnabled = true, HDDEnabled = true };
            _thisComputer.Open();

            StringBuilder sb = new StringBuilder();

            foreach (var hardwareItem in _thisComputer.Hardware)
            {
                switch (hardwareItem.HardwareType)
                {
                    case HardwareType.CPU:
                    case HardwareType.GpuNvidia:
                    case HardwareType.HDD:
                    case HardwareType.Mainboard:
                    case HardwareType.RAM:
                        AddCpuInfo(sb, hardwareItem);
                        break;
                }
            }

            tBox_SBC1.Text = sb.ToString();
        }

        private void SSD_MemoryUpdate()
        {
            ManagementObject myDisk = new ManagementObject("Win32_LogicalDisk.DeviceID='C:'");
            string myProperty = myDisk.GetPropertyValue("Size").ToString();
            var tmp = Convert.ToInt64(myProperty);
            var SSD_size = tmp / GB;

            if (this.tBox_SSD.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.tBox_SSD.Text = Convert.ToString(SSD_size) + " GB";
                }));
            }
            else
            {
                this.tBox_SSD.Text = Convert.ToString(SSD_size) + " GB";
            }

        }


        private static void AddCpuInfo(StringBuilder sb, IHardware hardwareItem)
        {
            hardwareItem.Update();
            foreach (IHardware subHardware in hardwareItem.SubHardware)
                subHardware.Update();

            string text;

            foreach (var sensor in hardwareItem.Sensors)
            {
                string name = sensor.Name;
                string value = sensor.Value.HasValue ? sensor.Value.Value.ToString() : "-1";

                switch (sensor.SensorType)
                {
                    case SensorType.Temperature:
                        text = $"{name} Temperature = {value}";
                        sb.AppendLine(text);
                        break;

                    case SensorType.Voltage:
                        text = $"{name} Voltage = {value}";
                        sb.AppendLine(text);
                        break;

                    case SensorType.Fan:
                        text = $"{name} RPM = {value}";
                        sb.AppendLine(text);
                        break;

                    case SensorType.Load:
                        text = $"{name} % = {value}";
                        sb.AppendLine(text);
                        break;
                }
            }
        }

        private void ComportUpdate()
        {
        }



        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
 
            this.Close();
            //WMI_Form.Close();

            //if (ps == null) return;

            //ps.Kill();

        }
    }
}
