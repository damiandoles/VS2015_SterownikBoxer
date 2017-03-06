namespace PlantMonitorV2
{
    partial class TempControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempControl));
            this.SetTemperature_btn = new System.Windows.Forms.Button();
            this.Temperature_tbx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ManualTempControl_rbtn = new System.Windows.Forms.RadioButton();
            this.irrigatemodegroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.AutoTempControl_rbtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.irrigatemodegroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // SetTemperature_btn
            // 
            this.SetTemperature_btn.Location = new System.Drawing.Point(160, 266);
            this.SetTemperature_btn.Name = "SetTemperature_btn";
            this.SetTemperature_btn.Size = new System.Drawing.Size(119, 34);
            this.SetTemperature_btn.TabIndex = 20;
            this.SetTemperature_btn.Text = "OK";
            this.SetTemperature_btn.UseVisualStyleBackColor = true;
            this.SetTemperature_btn.Click += new System.EventHandler(this.SetTemperature_btn_Click);
            // 
            // Temperature_tbx
            // 
            this.Temperature_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Temperature_tbx.Location = new System.Drawing.Point(169, 41);
            this.Temperature_tbx.Name = "Temperature_tbx";
            this.Temperature_tbx.Size = new System.Drawing.Size(65, 31);
            this.Temperature_tbx.TabIndex = 1;
            this.Temperature_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(231, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "°C";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManualTempControl_rbtn
            // 
            this.ManualTempControl_rbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManualTempControl_rbtn.AutoSize = true;
            this.ManualTempControl_rbtn.Location = new System.Drawing.Point(16, 92);
            this.ManualTempControl_rbtn.Name = "ManualTempControl_rbtn";
            this.ManualTempControl_rbtn.Size = new System.Drawing.Size(14, 13);
            this.ManualTempControl_rbtn.TabIndex = 37;
            this.ManualTempControl_rbtn.UseVisualStyleBackColor = true;
            this.ManualTempControl_rbtn.CheckedChanged += new System.EventHandler(this.ManualTempControl_rbtn_CheckedChanged);
            // 
            // irrigatemodegroup
            // 
            this.irrigatemodegroup.BackColor = System.Drawing.SystemColors.Control;
            this.irrigatemodegroup.Controls.Add(this.label2);
            this.irrigatemodegroup.Controls.Add(this.label1);
            this.irrigatemodegroup.Controls.Add(this.trackBar2);
            this.irrigatemodegroup.Controls.Add(this.trackBar1);
            this.irrigatemodegroup.Controls.Add(this.ManualTempControl_rbtn);
            this.irrigatemodegroup.Controls.Add(this.label10);
            this.irrigatemodegroup.Controls.Add(this.SetTemperature_btn);
            this.irrigatemodegroup.Controls.Add(this.Temperature_tbx);
            this.irrigatemodegroup.Controls.Add(this.label8);
            this.irrigatemodegroup.Controls.Add(this.AutoTempControl_rbtn);
            this.irrigatemodegroup.Controls.Add(this.label4);
            this.irrigatemodegroup.Location = new System.Drawing.Point(12, 3);
            this.irrigatemodegroup.Name = "irrigatemodegroup";
            this.irrigatemodegroup.Size = new System.Drawing.Size(441, 315);
            this.irrigatemodegroup.TabIndex = 45;
            this.irrigatemodegroup.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Obroty (wentylatory wyjściowe):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Obroty (wentylator wejściowy):";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 215);
            this.trackBar2.Maximum = 95;
            this.trackBar2.Minimum = 20;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(429, 45);
            this.trackBar2.TabIndex = 39;
            this.trackBar2.Value = 20;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 15;
            this.trackBar1.Location = new System.Drawing.Point(6, 144);
            this.trackBar1.Maximum = 95;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(429, 45);
            this.trackBar1.TabIndex = 38;
            this.trackBar1.Value = 20;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(36, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(401, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Sterowanie manualne (obroty wentylatora od min do max)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoTempControl_rbtn
            // 
            this.AutoTempControl_rbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoTempControl_rbtn.AutoSize = true;
            this.AutoTempControl_rbtn.Location = new System.Drawing.Point(16, 19);
            this.AutoTempControl_rbtn.Name = "AutoTempControl_rbtn";
            this.AutoTempControl_rbtn.Size = new System.Drawing.Size(14, 13);
            this.AutoTempControl_rbtn.TabIndex = 23;
            this.AutoTempControl_rbtn.UseVisualStyleBackColor = true;
            this.AutoTempControl_rbtn.CheckedChanged += new System.EventHandler(this.AutoTempControl_rbtn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(36, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Sterowanie automatyczne (temp. max.)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TempControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(464, 329);
            this.Controls.Add(this.irrigatemodegroup);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TempControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sterowanie temperaturą";
            this.irrigatemodegroup.ResumeLayout(false);
            this.irrigatemodegroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetTemperature_btn;
        private System.Windows.Forms.TextBox Temperature_tbx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton ManualTempControl_rbtn;
        private System.Windows.Forms.GroupBox irrigatemodegroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton AutoTempControl_rbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}