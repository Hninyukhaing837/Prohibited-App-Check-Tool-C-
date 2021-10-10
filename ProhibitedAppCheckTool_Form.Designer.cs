namespace Prohibited_App_Check_Tool
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
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.rdEng = new System.Windows.Forms.RadioButton();
            this.rdJp = new System.Windows.Forms.RadioButton();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtApp = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnInputFileSelect = new System.Windows.Forms.Button();
            this.btnOutputSelect = new System.Windows.Forms.Button();
            this.rdPartial = new System.Windows.Forms.RadioButton();
            this.rdBeginning = new System.Windows.Forms.RadioButton();
            this.rdPerfect = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(35, 27);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(104, 15);
            this.lblMachineName.TabIndex = 0;
            this.lblMachineName.Text = "Machine Name:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(399, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 15);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time:";
            // 
            // rdEng
            // 
            this.rdEng.AutoSize = true;
            this.rdEng.Checked = true;
            this.rdEng.Location = new System.Drawing.Point(553, 55);
            this.rdEng.Name = "rdEng";
            this.rdEng.Size = new System.Drawing.Size(46, 19);
            this.rdEng.TabIndex = 2;
            this.rdEng.TabStop = true;
            this.rdEng.Text = "EN";
            this.rdEng.UseVisualStyleBackColor = true;
            this.rdEng.CheckedChanged += new System.EventHandler(this.rdEng_CheckedChanged);
            // 
            // rdJp
            // 
            this.rdJp.AutoSize = true;
            this.rdJp.Location = new System.Drawing.Point(605, 55);
            this.rdJp.Name = "rdJp";
            this.rdJp.Size = new System.Drawing.Size(45, 19);
            this.rdJp.TabIndex = 3;
            this.rdJp.Text = "JP";
            this.rdJp.UseVisualStyleBackColor = true;
            this.rdJp.CheckedChanged += new System.EventHandler(this.rdJp_CheckedChanged);
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(35, 102);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(101, 15);
            this.lblApp.TabIndex = 4;
            this.lblApp.Text = "Prohibited App:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(35, 164);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(131, 15);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output Destination:";
            // 
            // txtApp
            // 
            this.txtApp.Location = new System.Drawing.Point(180, 99);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(354, 22);
            this.txtApp.TabIndex = 6;
            this.txtApp.TextChanged += new System.EventHandler(this.txtApp_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(180, 159);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(354, 22);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // btnInputFileSelect
            // 
            this.btnInputFileSelect.Location = new System.Drawing.Point(554, 98);
            this.btnInputFileSelect.Name = "btnInputFileSelect";
            this.btnInputFileSelect.Size = new System.Drawing.Size(95, 23);
            this.btnInputFileSelect.TabIndex = 8;
            this.btnInputFileSelect.Text = "Select";
            this.btnInputFileSelect.UseVisualStyleBackColor = true;
            this.btnInputFileSelect.Click += new System.EventHandler(this.btnInputFileSelect_Click);
            // 
            // btnOutputSelect
            // 
            this.btnOutputSelect.Location = new System.Drawing.Point(556, 160);
            this.btnOutputSelect.Name = "btnOutputSelect";
            this.btnOutputSelect.Size = new System.Drawing.Size(95, 23);
            this.btnOutputSelect.TabIndex = 9;
            this.btnOutputSelect.Text = "Select";
            this.btnOutputSelect.UseVisualStyleBackColor = true;
            this.btnOutputSelect.Click += new System.EventHandler(this.btnOutputSelect_Click);
            // 
            // rdPartial
            // 
            this.rdPartial.AutoSize = true;
            this.rdPartial.Location = new System.Drawing.Point(3, 16);
            this.rdPartial.Name = "rdPartial";
            this.rdPartial.Size = new System.Drawing.Size(248, 19);
            this.rdPartial.TabIndex = 10;
            this.rdPartial.Text = "Partial Match      (xxxappnamexxx)";
            this.rdPartial.UseVisualStyleBackColor = true;
            this.rdPartial.CheckedChanged += new System.EventHandler(this.rdPartial_CheckedChanged);
            // 
            // rdBeginning
            // 
            this.rdBeginning.AutoSize = true;
            this.rdBeginning.Checked = true;
            this.rdBeginning.Location = new System.Drawing.Point(3, 64);
            this.rdBeginning.Name = "rdBeginning";
            this.rdBeginning.Size = new System.Drawing.Size(225, 19);
            this.rdBeginning.TabIndex = 11;
            this.rdBeginning.TabStop = true;
            this.rdBeginning.Text = "Beginning Match (appnamexxx)";
            this.rdBeginning.UseVisualStyleBackColor = true;
            this.rdBeginning.CheckedChanged += new System.EventHandler(this.rdBeginning_CheckedChanged);
            // 
            // rdPerfect
            // 
            this.rdPerfect.AutoSize = true;
            this.rdPerfect.Location = new System.Drawing.Point(3, 115);
            this.rdPerfect.Name = "rdPerfect";
            this.rdPerfect.Size = new System.Drawing.Size(205, 19);
            this.rdPerfect.TabIndex = 12;
            this.rdPerfect.Text = "Perfect Match    (appname)\r\n";
            this.rdPerfect.UseVisualStyleBackColor = true;
            this.rdPerfect.CheckedChanged += new System.EventHandler(this.rdPerfect_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(38, 371);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 36);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdPerfect);
            this.panel1.Controls.Add(this.rdBeginning);
            this.panel1.Controls.Add(this.rdPartial);
            this.panel1.Location = new System.Drawing.Point(38, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 158);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOutputSelect);
            this.Controls.Add(this.btnInputFileSelect);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtApp);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.rdJp);
            this.Controls.Add(this.rdEng);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMachineName);
            this.Name = "Form1";
            this.Text = "Prohibited App Check Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RadioButton rdEng;
        private System.Windows.Forms.RadioButton rdJp;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtApp;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnInputFileSelect;
        private System.Windows.Forms.Button btnOutputSelect;
        private System.Windows.Forms.RadioButton rdPartial;
        private System.Windows.Forms.RadioButton rdBeginning;
        private System.Windows.Forms.RadioButton rdPerfect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
    }
}

