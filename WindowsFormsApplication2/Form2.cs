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
        public int customBaud { get; set; }
        public int customDataBits { get; set; }
        public Parity customParity { get; set; }
        public StopBits customStopBits { get; set; }
    
        public Form2()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            bool flag = false;
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
                    customStopBits = StopBits.None;
                    break;
                case 1:
                    customStopBits = StopBits.One;
                    break;
                case 2:
                    customStopBits = StopBits.OnePointFive;
                    break;
                case 3:
                    customStopBits = StopBits.Two;
                    break;
                default:
                    customStopBits = StopBits.None;
                    break;


            }
            if(!flag)
            {
                this.Hide();
            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
