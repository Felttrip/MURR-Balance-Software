namespace WindowsFormsApplication2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.parityCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.portNameCmbBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.row_offset_drop = new System.Windows.Forms.NumericUpDown();
            this.column_offset_drop = new System.Windows.Forms.NumericUpDown();
            this.baudRateTxtbox = new System.Windows.Forms.TextBox();
            this.stopBitsCmbBox = new System.Windows.Forms.ComboBox();
            this.dataBitsTxtbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.row_offset_drop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.column_offset_drop)).BeginInit();
            this.SuspendLayout();
            // 
            // parityCmbBox
            // 
            this.parityCmbBox.FormattingEnabled = true;
            this.parityCmbBox.Items.AddRange(new object[] {
            "Odd",
            "Even",
            "Space",
            "Mark",
            "None"});
            this.parityCmbBox.Location = new System.Drawing.Point(70, 126);
            this.parityCmbBox.Name = "parityCmbBox";
            this.parityCmbBox.Size = new System.Drawing.Size(100, 21);
            this.parityCmbBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stop Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 271);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(126, 271);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Com Port";
            // 
            // portNameCmbBox
            // 
            this.portNameCmbBox.FormattingEnabled = true;
            this.portNameCmbBox.Location = new System.Drawing.Point(70, 22);
            this.portNameCmbBox.Name = "portNameCmbBox";
            this.portNameCmbBox.Size = new System.Drawing.Size(100, 21);
            this.portNameCmbBox.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.portNameCmbBox);
            this.groupBox1.Controls.Add(this.baudRateTxtbox);
            this.groupBox1.Controls.Add(this.parityCmbBox);
            this.groupBox1.Controls.Add(this.stopBitsCmbBox);
            this.groupBox1.Controls.Add(this.dataBitsTxtbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 159);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.column_offset_drop);
            this.groupBox2.Controls.Add(this.row_offset_drop);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 78);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excel Offset";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Row";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Column";
            // 
            // row_offset_drop
            // 
            this.row_offset_drop.Location = new System.Drawing.Point(70, 19);
            this.row_offset_drop.Name = "row_offset_drop";
            this.row_offset_drop.Size = new System.Drawing.Size(100, 20);
            this.row_offset_drop.TabIndex = 2;
            // 
            // column_offset_drop
            // 
            this.column_offset_drop.Location = new System.Drawing.Point(70, 45);
            this.column_offset_drop.Name = "column_offset_drop";
            this.column_offset_drop.Size = new System.Drawing.Size(100, 20);
            this.column_offset_drop.TabIndex = 3;
            // 
            // baudRateTxtbox
            // 
            this.baudRateTxtbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication2.Properties.Settings.Default, "baudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baudRateTxtbox.Location = new System.Drawing.Point(70, 48);
            this.baudRateTxtbox.Name = "baudRateTxtbox";
            this.baudRateTxtbox.Size = new System.Drawing.Size(100, 20);
            this.baudRateTxtbox.TabIndex = 0;
            this.baudRateTxtbox.Text = global::WindowsFormsApplication2.Properties.Settings.Default.baudRate;
            // 
            // stopBitsCmbBox
            // 
            this.stopBitsCmbBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication2.Properties.Settings.Default, "StopBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stopBitsCmbBox.FormattingEnabled = true;
            this.stopBitsCmbBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopBitsCmbBox.Location = new System.Drawing.Point(70, 99);
            this.stopBitsCmbBox.Name = "stopBitsCmbBox";
            this.stopBitsCmbBox.Size = new System.Drawing.Size(100, 21);
            this.stopBitsCmbBox.TabIndex = 10;
            this.stopBitsCmbBox.Text = global::WindowsFormsApplication2.Properties.Settings.Default.StopBits;
            // 
            // dataBitsTxtbox
            // 
            this.dataBitsTxtbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication2.Properties.Settings.Default, "DataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataBitsTxtbox.Location = new System.Drawing.Point(70, 74);
            this.dataBitsTxtbox.Name = "dataBitsTxtbox";
            this.dataBitsTxtbox.Size = new System.Drawing.Size(100, 20);
            this.dataBitsTxtbox.TabIndex = 2;
            this.dataBitsTxtbox.Text = global::WindowsFormsApplication2.Properties.Settings.Default.DataBits;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 319);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Name = "Form2";
            this.Text = "Custom Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.row_offset_drop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.column_offset_drop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox baudRateTxtbox;
        private System.Windows.Forms.ComboBox parityCmbBox;
        private System.Windows.Forms.TextBox dataBitsTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox stopBitsCmbBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox portNameCmbBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown column_offset_drop;
        private System.Windows.Forms.NumericUpDown row_offset_drop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}