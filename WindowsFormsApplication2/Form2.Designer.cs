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
            this.stopBitsCmbBox = new System.Windows.Forms.ComboBox();
            this.dataBitsTxtbox = new System.Windows.Forms.TextBox();
            this.baudRateTxtbox = new System.Windows.Forms.TextBox();
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
            this.parityCmbBox.Location = new System.Drawing.Point(76, 84);
            this.parityCmbBox.Name = "parityCmbBox";
            this.parityCmbBox.Size = new System.Drawing.Size(100, 21);
            this.parityCmbBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stop Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 132);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(160, 132);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // stopBitsCmbBox
            // 
            this.stopBitsCmbBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication2.Properties.Settings.Default, "StopBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stopBitsCmbBox.FormattingEnabled = true;
            this.stopBitsCmbBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopBitsCmbBox.Location = new System.Drawing.Point(76, 57);
            this.stopBitsCmbBox.Name = "stopBitsCmbBox";
            this.stopBitsCmbBox.Size = new System.Drawing.Size(100, 21);
            this.stopBitsCmbBox.TabIndex = 10;
            this.stopBitsCmbBox.Text = global::WindowsFormsApplication2.Properties.Settings.Default.StopBits;
            // 
            // dataBitsTxtbox
            // 
            this.dataBitsTxtbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication2.Properties.Settings.Default, "DataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataBitsTxtbox.Location = new System.Drawing.Point(76, 32);
            this.dataBitsTxtbox.Name = "dataBitsTxtbox";
            this.dataBitsTxtbox.Size = new System.Drawing.Size(100, 20);
            this.dataBitsTxtbox.TabIndex = 2;
            this.dataBitsTxtbox.Text = global::WindowsFormsApplication2.Properties.Settings.Default.DataBits;
            // 
            // baudRateTxtbox
            // 
            this.baudRateTxtbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApplication2.Properties.Settings.Default, "baudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baudRateTxtbox.Location = new System.Drawing.Point(76, 6);
            this.baudRateTxtbox.Name = "baudRateTxtbox";
            this.baudRateTxtbox.Size = new System.Drawing.Size(100, 20);
            this.baudRateTxtbox.TabIndex = 0;
            this.baudRateTxtbox.Text = global::WindowsFormsApplication2.Properties.Settings.Default.baudRate;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 167);
            this.Controls.Add(this.stopBitsCmbBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataBitsTxtbox);
            this.Controls.Add(this.parityCmbBox);
            this.Controls.Add(this.baudRateTxtbox);
            this.Name = "Form2";
            this.Text = "Custom Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}