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
using System.Drawing.Printing;


namespace WindowsFormsApplication2
{
    

    public partial class Form1 : Form
    {
        
        //Class level variables for form
        delegate void SetTextCallback(string text);
        Form2 customForm = new Form2();
        Excel.Workbook xlwkbook;
        Excel.Worksheet xlsheet;
        Excel.Application xlApp;
       
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
            //Start up serial port connection
            
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                serialPort1.Dispose();
                if (!serialPort1.IsOpen)
                    checkBox1.CheckState = CheckState.Unchecked;
            }
            else
            {
                connectToCOM();
                serialPort1.Open();
                if (serialPort1.IsOpen)
                    checkBox1.CheckState = CheckState.Checked;
            }
            if(excel_CheckBox.Checked && checkBox1.Checked)
            {
                
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Excel File|*.*";
                openFileDialog1.Title = "Open an Excel File";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        string xlFileName = openFileDialog1.FileName;
                        xlwkbook = (Excel.Workbook)System.Runtime.InteropServices.Marshal.BindToMoniker(xlFileName);
                        string sFile = xlFileName.Substring(xlFileName.LastIndexOf("\\") + 1);
                        xlwkbook.Application.Windows[sFile].Visible = true;
                        xlwkbook.Application.Visible = true;
                        xlsheet = (Excel.Worksheet)xlwkbook.ActiveSheet;
                        xlsheet.Visible = Excel.XlSheetVisibility.xlSheetVisible;
                    }
                    catch ( System.ArgumentException ex)
                    {
                        MessageBox.Show("Please try again and select a valid Excel file.\n","Error");
                    }
                    catch ( System.InvalidCastException ex)
                    {
                        MessageBox.Show("Please try again and select a valid Excel file.\n","Error");
                    }
                    catch(System.Runtime.InteropServices.COMException ex)
                    {
                        MessageBox.Show("Please try again and select a valid Excel file.\n", "Error");
                    }
                    
                }
            }
            if(excel_CheckBox.Checked && !checkBox1.Checked)
            {
                xlwkbook = null;
                xlsheet = null;	
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
                str = spL.ReadLine();       //Read until \r\n the designated EOS for the balances
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
        //and send the data to the excel function
        private void SetText(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                //add text to text box
                richTextBox1.Text += text + "\r\n";
                
                //keep bottom of text box in focus
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();

                //add to excel doc
                if(excel_CheckBox.Checked)
                {
                    string rawNum = text.Replace("g", "");
                    excel(Convert.ToDouble(rawNum));
                } 
            }
        }
        //  excel(double data)
        //  This function will take the parsed data
        //  from the scale and place it in the currently
        //  opened excel document in the currently activated
        //  cell. 
        private void excel(double data)
        {

            try //attempt to open current excel doc
            {
                xlApp = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
                xlApp.ActiveCell.Value2 = data;

                //Change currently selected cell

                Excel.Range activeCell = xlApp.ActiveCell;
                int column = activeCell.Column;
                int row = activeCell.Row;
                int row_offset = Properties.Settings.Default.row_offset;
                int column_offset = Properties.Settings.Default.column_offset;
                activeCell = (Excel.Range)xlApp.ActiveSheet.Cells[row + row_offset, column + column_offset];
                activeCell.Select();

            }
            catch (System.Runtime.InteropServices.COMException ex) //if excel doc is not open then open a doc
            {

            }
            catch(System.NullReferenceException ex)
            {
                MessageBox.Show("Data failed to send to Excel.\n Uncheck the \"Open Excel\" box, or open a new Excel document", "Error");   
            }
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


        //Connecting to COM function
        //sets all of the values to start a COM port connection
        private void connectToCOM()
        {
            try
            {
                serialPort1.PortName = Properties.Settings.Default.port_name;
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
                serialPort1.Dispose();
            }
        }

        //About toolstrip
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Murr Balance Software is distributed under the GNU General Public License.", "About Murr Balance Software");
        }

        //file->settings toolstrip
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customForm.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pDialog = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDialog.AllowPrintToFile = true;
            pDialog.AllowSelection = true;
            pDialog.AllowSomePages = true;
            pDoc.DocumentName = "Printing Document";
            pDoc.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString("Printed on: " + DateTime.Now.ToLongDateString() + "\r\n" + richTextBox1.Text, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(50, 50, pDoc.DefaultPageSettings.PrintableArea.Width, pDoc.DefaultPageSettings.PrintableArea.Height));

            };
            if (pDialog.ShowDialog() == DialogResult.OK)
                pDoc.Print();
        }
        

    }
}     
