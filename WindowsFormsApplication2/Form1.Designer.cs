namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.oldBalanceRbtn = new System.Windows.Forms.RadioButton();
            this.newBalanceRbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.customRbtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // oldBalanceRbtn
            // 
            this.oldBalanceRbtn.AutoSize = true;
            this.oldBalanceRbtn.Location = new System.Drawing.Point(12, 12);
            this.oldBalanceRbtn.Name = "oldBalanceRbtn";
            this.oldBalanceRbtn.Size = new System.Drawing.Size(83, 17);
            this.oldBalanceRbtn.TabIndex = 0;
            this.oldBalanceRbtn.TabStop = true;
            this.oldBalanceRbtn.Text = "Old Balance";
            this.oldBalanceRbtn.UseVisualStyleBackColor = true;
            this.oldBalanceRbtn.CheckedChanged += new System.EventHandler(this.oldBalanceRbtn_CheckedChanged);
            // 
            // newBalanceRbtn
            // 
            this.newBalanceRbtn.AutoSize = true;
            this.newBalanceRbtn.Location = new System.Drawing.Point(101, 12);
            this.newBalanceRbtn.Name = "newBalanceRbtn";
            this.newBalanceRbtn.Size = new System.Drawing.Size(89, 17);
            this.newBalanceRbtn.TabIndex = 1;
            this.newBalanceRbtn.TabStop = true;
            this.newBalanceRbtn.Text = "New Balance";
            this.newBalanceRbtn.UseVisualStyleBackColor = true;
            this.newBalanceRbtn.CheckedChanged += new System.EventHandler(this.newBalanceRbtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data From Scale";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(262, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Connected";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // runBtn
            // 
            this.runBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.runBtn.Location = new System.Drawing.Point(12, 293);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(75, 23);
            this.runBtn.TabIndex = 7;
            this.runBtn.Text = "Start/Stop";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 231);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveBtn.Location = new System.Drawing.Point(297, 293);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // customRbtn
            // 
            this.customRbtn.AutoSize = true;
            this.customRbtn.Location = new System.Drawing.Point(196, 12);
            this.customRbtn.Name = "customRbtn";
            this.customRbtn.Size = new System.Drawing.Size(60, 17);
            this.customRbtn.TabIndex = 15;
            this.customRbtn.TabStop = true;
            this.customRbtn.Text = "Custom";
            this.customRbtn.UseVisualStyleBackColor = true;
            this.customRbtn.CheckedChanged += new System.EventHandler(this.customRbtn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 328);
            this.Controls.Add(this.customRbtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newBalanceRbtn);
            this.Controls.Add(this.oldBalanceRbtn);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "Form1";
            this.Text = "MURR Balance Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton oldBalanceRbtn;
        private System.Windows.Forms.RadioButton newBalanceRbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RadioButton customRbtn;

    }
}

