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

        //Class level variables for form
        private bool flag = false;
        delegate void SetTextCallback(string text);
        Form2 customForm = new Form2();
       
        public Form1()
        {
            //used for debuging
            //Properties.Settings.Default.Reset();
            InitializeComponent();
        }

        //load the form initialy
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //runBtn_Click(object sender, EventArgs e)
        //runBtn starts up the listening on the serial port
        private void runBtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.BaudRate = Properties.Settings.Default.baud_rate;
                serialPort1.DataBits = Properties.Settings.Default.data_bits;
                serialPort1.Parity = Properties.Settings.Default.parity;
                serialPort1.StopBits = Properties.Settings.Default.stop_bits;
                serialPort1.DataReceived += serialPort1_DataReceived;
                

            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Configuration not accepted.", "Error");
                customForm.Show();
                flag = true;
            }
            if (flag)
            {
                serialPort1.Close();
                flag = false;
                if (!serialPort1.IsOpen)
                    checkBox1.CheckState = CheckState.Unchecked;
            }
            else
            {
                serialPort1.Open();
                flag = true;
                if (serialPort1.IsOpen)
                    checkBox1.CheckState = CheckState.Checked;
            }
        }

        //port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //This event will occur when the serial port recieves data, it will then 
        //parse the data and send it to the SetText(str) function
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort spL = (SerialPort)sender;
                string str = null;
                str = spL.ReadTo("\r\n");   //Read until \r\n the designated EOS for the balances
                str = str.Replace(" ", ""); //Remove all spaces
                str = str.Replace("\n", "");//Remove all newline characters
                str = str.Replace("\r", "");//Remove all return characters
                SetText(str);
            }
            catch(System.IO.IOException ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
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
                string str = richTextBox1.Text;                                       //copy contents of the RTB
                string fixedString = str.Replace("\n", "\r\n");                       //replace \n with \r\n for windows
                fixedString = "Saved on: " + DateTime.Now.ToLongDateString() + "\r\n" + fixedString; //add current date to string
                System.IO.File.WriteAllText(saveFileDialog1.FileName, fixedString);   //write the string to the specified file
                File.SetAttributes(saveFileDialog1.FileName,FileAttributes.ReadOnly); //Set file as read only
                return;
            }
        }


        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customForm.Show();
        }

        

    }
}     
