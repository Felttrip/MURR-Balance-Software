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
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using Microsoft.VisualBasic;


namespace WindowsFormsApplication2
{

    public partial class Form1 : Form
    {
        //Create a new serial port with default params
        public SerialPort port = new SerialPort("COM1");
        private bool flag = false;
        delegate void SetTextCallback(string text);
        Form2 customForm = new Form2();

        //custom settings
       
        public Form1()
        {
            InitializeComponent();
        }

        //load the form initialy
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //old balance radio button logic
        //sets the values for the old balances
        private void oldBalanceRbtn_CheckedChanged(object sender, EventArgs e)
        {
            port.BaudRate = 2400;
            port.Parity = Parity.None;
            port.DataBits = 7;
            port.StopBits = StopBits.One;
            port.DataReceived += port_DataReceived;
        }

        //new balance logic
        //sets the values for the new balances
        private void newBalanceRbtn_CheckedChanged(object sender, EventArgs e)
        {
            port.BaudRate = 9600;
            port.Parity = Parity.None;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            port.DataReceived += port_DataReceived;
        }


        //runBtn_Click(object sender, EventArgs e)
        //runBtn starts up the listening on the serial port
        private void runBtn_Click(object sender, EventArgs e)
        {
            //check flag for if button was last pressed
            if(customRbtn.Checked)
            {
                try 
                {
                    port.BaudRate = customForm.customBaud;
                    port.DataBits = customForm.customDataBits;
                    port.Parity = customForm.customParity;
                    port.StopBits = customForm.customStopBits;
                    port.DataReceived += port_DataReceived;
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Custom values not accepted", "Error");
                    customForm.Show();
                }
                
            }
            if (flag)
            {
                port.Close();
                flag = false;
                if (!port.IsOpen)
                    checkBox1.CheckState = CheckState.Unchecked;
            }
            else
            {
                port.Open();
                flag = true;
                if (port.IsOpen)
                    checkBox1.CheckState = CheckState.Checked;
            }
         }

        //port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //This event will occur when the serial port recieves data, it will then 
        //parse the data and send it to the SetText(str) function
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort spL = (SerialPort)sender;
            string str = null;
            str = spL.ReadTo("\r\n");   //Read until \r\n the designated EOS for the balances
            str = str.Replace(" ", ""); //Remove all spaces
            str = str.Replace("\n", "");//Remove all newline characters
            str = str.Replace("\r", "");//Remove all return characters
            SetText(str);
            
        }


        //SetText(string text)
        //This function handles moving the text collected from
        //the balance's thread and passes it to the richTextBox1 thread
        //and sned the data to the excel function
        private void SetText(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                richTextBox1.Text += text + "\r\n";
                string rawNum = text.Replace("g", "");
                excel(Convert.ToDouble(rawNum));
            }


        }
        //  excel(double data)
        //  This function will take the parsed data
        //  from the scale and place it in the currently
        //  opened excel document in the currently activated
        //  cell. 
        private void excel(double data)
        {
            //define Excel Objects
            Excel.Application xlApp = null;
            Excel.Worksheet activeWorksheet = null;
            Excel.Range activeCell = null;

            try //attempt to open current excel doc
            {
                xlApp = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            }
            catch (System.Runtime.InteropServices.COMException ex) //if excel doc is not open then open a doc
            {
                xlApp = new Excel.Application();
            }

            //grab active worksheet and active cell
            activeWorksheet = (Excel.Worksheet)xlApp.ActiveWorkbook.ActiveSheet;
            activeCell = (Excel.Range)xlApp.Application.ActiveCell;

            //input data in cell
            activeCell.Value2 = data;


            //THIS CODE WOULD ALLOW THE PROGRAM TO CHANGE CELLS
            //BUT WAS DETERMINED TO BE UNNECESSARY

                //Change currently selected cell
                /*column = activeCell.Column;
                row = activeCell.Row;
                activeCell = (Excel.Range)activeWorksheet.Cells[row + 1, column];
                activeCell.Select();*/
        }

        //saveBtn_Click(object sender, EventArgs e)
        //This function will begin the save dialog process 
        //when the saveBtn is clicked
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the text
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.Title = "Save a text File";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string str = richTextBox1.Text;
                string fixedString = str.Replace("\n", "\r\n");
                System.IO.File.WriteAllText(saveFileDialog1.FileName, fixedString);
                return;
            }
        }

        //custom radio button for custom values
        private void customRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if(customRbtn.Checked)
            {
                customForm.Show();
            }
            
        }

        

    }
}     
