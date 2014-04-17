using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public string customPort { get; set; }
        public int customBaud { get; set; }
        public int customDataBits { get; set; }
        public Parity customParity { get; set; }
        public StopBits customStopBits { get; set; }

        public Form2()
        {

            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            int i = 0;
            int index=0;
            foreach (string port in ports)
            {
                portNameCmbBox.Items.Add(port);
                if(port == Properties.Settings.Default.port_name)
                {
                    index = i;
                }
                i++;
            }
            portNameCmbBox.SelectedIndex = index;
            baudRateTxtbox.Text = Properties.Settings.Default.baud_rate.ToString();
            dataBitsTxtbox.Text = Properties.Settings.Default.data_bits.ToString();
            stopBitsCmbBox.Text = Properties.Settings.Default.stop_bits.ToString();
            parityCmbBox.Text = Properties.Settings.Default.parity.ToString();

          
           
        }

        private void save_Click(object sender, EventArgs e)
        {
            bool flag = false;
            portNameCmbBox.Focus();
            customPort = portNameCmbBox.SelectedText;
            try
            {
                customBaud = Convert.ToInt32(baudRateTxtbox.Text);
                customDataBits = Convert.ToInt32(dataBitsTxtbox.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please use Integers in the Baude Rate and Data Bits fields", "Error");
                flag = true;

            }
            switch (parityCmbBox.SelectedIndex)
            {
                case 0:
                    customParity = Parity.Odd;
                    break;
                case 1:
                    customParity = Parity.Even;
                    break;
                case 2:
                    customParity = Parity.Space;
                    break;
                case 3:
                    customParity = Parity.Mark;
                    break;
                case 4:
                    customParity = Parity.None;
                    break;
                default :
                    customParity = Parity.None;
                    break;
            }

            switch(stopBitsCmbBox.SelectedIndex)
            {
                case 0:
                    customStopBits = StopBits.One;
                    break;
                case 1:
                    customStopBits = StopBits.OnePointFive;
                    break;
                case 2:
                    customStopBits = StopBits.Two;
                    break;
                default:
                    customStopBits = StopBits.One;
                    break;
            }
           
            
            if(!flag)
            {
                save_settings();
                this.Hide();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void save_settings()
        {
            Properties.Settings.Default.port_name = customPort;
            Properties.Settings.Default.baud_rate = customBaud;
            Properties.Settings.Default.data_bits = customDataBits;
            Properties.Settings.Default.stop_bits = customStopBits;
            Properties.Settings.Default.parity = customParity;
            Properties.Settings.Default.Save();
        }

        private void portNameCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
