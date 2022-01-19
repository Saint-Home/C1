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

namespace KVLS2_C1
{
    public partial class WMI_Form : Form
    {
        public WMI_Form()
        {
            InitializeComponent();

            Load += Form_Load;
            this.wmiComboBox.SelectedIndexChanged += wmiComboBox_SelectedIndexChanged;
        }

        #region WMI List 
        private void Form_Load(object sender, EventArgs e)
        {
            this.wmiComboBox.Items.Add("Win32_BaseBoard");
            this.wmiComboBox.Items.Add("Win32_Battery");
            this.wmiComboBox.Items.Add("Win32_BIOS");
            this.wmiComboBox.Items.Add("Win32_Bus");
            this.wmiComboBox.Items.Add("Win32_CDROMDrive");
            this.wmiComboBox.Items.Add("Win32_DiskDrive");
            this.wmiComboBox.Items.Add("Win32_DMAChannel");
            this.wmiComboBox.Items.Add("Win32_Fan");
            this.wmiComboBox.Items.Add("Win32_FloppyController");
            this.wmiComboBox.Items.Add("Win32_FloppyDrive");
            this.wmiComboBox.Items.Add("Win32_IDEController");
            this.wmiComboBox.Items.Add("Win32_IRQResource");
            this.wmiComboBox.Items.Add("Win32_Keyboard");
            this.wmiComboBox.Items.Add("Win32_MemoryDevice");
            this.wmiComboBox.Items.Add("Win32_NetworkAdapter");
            this.wmiComboBox.Items.Add("Win32_NetworkAdapterConfiguration");
            this.wmiComboBox.Items.Add("Win32_OnBoardDevice");
            this.wmiComboBox.Items.Add("Win32_ParallelPort");
            this.wmiComboBox.Items.Add("Win32_PCMCIAController");
            this.wmiComboBox.Items.Add("Win32_PhysicalMedia");
            this.wmiComboBox.Items.Add("Win32_PhysicalMemory");
            this.wmiComboBox.Items.Add("Win32_PortConnector");
            this.wmiComboBox.Items.Add("Win32_PortResource");
            this.wmiComboBox.Items.Add("Win32_Processor");
            this.wmiComboBox.Items.Add("Win32_SCSIController");
            this.wmiComboBox.Items.Add("Win32_SerialPort");
            this.wmiComboBox.Items.Add("Win32_SerialPortConfiguration");
            this.wmiComboBox.Items.Add("Win32_SoundDevice");
            this.wmiComboBox.Items.Add("Win32_SystemEnclosure");
            this.wmiComboBox.Items.Add("Win32_TapeDrive");
            this.wmiComboBox.Items.Add("Win32_TemperatureProbe");
            this.wmiComboBox.Items.Add("Win32_UninterruptiblePowerSupply");
            this.wmiComboBox.Items.Add("Win32_USBController");
            this.wmiComboBox.Items.Add("Win32_USBHub");
            this.wmiComboBox.Items.Add("Win32_VideoController");
            this.wmiComboBox.Items.Add("Win32_VoltageProbe");
            this.wmiComboBox.Items.Add("Win32_LogicalDisk");

            this.wmiComboBox.SelectedIndex = 0;
        }
        #endregion

        #region Combobox Index 변경에 대한 H/W Info
        private void wmiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.wmiComboBox.SelectedItem != null)
            {
                this.listView.Items.Clear();

                SelectQuery selectQuery = new SelectQuery(this.wmiComboBox.SelectedItem as string);

                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(selectQuery);

                foreach (ManagementObject managementObject in managementObjectSearcher.Get())
                {
                    this.listView.Groups.Add(managementObject.ToString(), managementObject.Properties["Name"].Value.ToString());

                    foreach (PropertyData propertyData in managementObject.Properties)
                    {
                        string valueString = null;

                        if (propertyData.Value != null)
                        {
                            valueString = propertyData.Value.ToString();
                        }

                        string[] itemArray = { propertyData.Name, valueString };

                        ListViewItem listViewItem = new ListViewItem(itemArray);

                        listViewItem.Group = listView.Groups[managementObject.ToString()] as ListViewGroup;

                        listView.Items.Add(listViewItem);
                    }
                }
            }
        }
        #endregion



    }
}
