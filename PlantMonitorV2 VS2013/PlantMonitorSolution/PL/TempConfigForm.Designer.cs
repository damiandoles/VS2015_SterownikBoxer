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
            this.TurnONTempControlling_rbtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.irrigatemodegroup = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TurnOFFTempControlling_rbtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.irrigatemodegroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetTemperature_btn
            // 
            this.SetTemperature_btn.Location = new System.Drawing.Point(117, 145);
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
            this.Temperature_tbx.Location = new System.Drawing.Point(117, 108);
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
            this.label10.Location = new System.Drawing.Point(201, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "°C";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TurnONTempControlling_rbtn
            // 
            this.TurnONTempControlling_rbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnONTempControlling_rbtn.AutoSize = true;
            this.TurnONTempControlling_rbtn.Location = new System.Drawing.Point(16, 48);
            this.TurnONTempControlling_rbtn.Name = "TurnONTempControlling_rbtn";
            this.TurnONTempControlling_rbtn.Size = new System.Drawing.Size(14, 13);
            this.TurnONTempControlling_rbtn.TabIndex = 37;
            this.TurnONTempControlling_rbtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Domyślna wartość dla obu trybów: 25 °C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // irrigatemodegroup
            // 
            this.irrigatemodegroup.BackColor = System.Drawing.SystemColors.Control;
            this.irrigatemodegroup.Controls.Add(this.TurnONTempControlling_rbtn);
            this.irrigatemodegroup.Controls.Add(this.label10);
            this.irrigatemodegroup.Controls.Add(this.SetTemperature_btn);
            this.irrigatemodegroup.Controls.Add(this.Temperature_tbx);
            this.irrigatemodegroup.Controls.Add(this.label8);
            this.irrigatemodegroup.Controls.Add(this.TurnOFFTempControlling_rbtn);
            this.irrigatemodegroup.Controls.Add(this.label4);
            this.irrigatemodegroup.Controls.Add(this.label3);
            this.irrigatemodegroup.Location = new System.Drawing.Point(12, 12);
            this.irrigatemodegroup.Name = "irrigatemodegroup";
            this.irrigatemodegroup.Size = new System.Drawing.Size(349, 187);
            this.irrigatemodegroup.TabIndex = 45;
            this.irrigatemodegroup.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(36, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Włącz sterowanie (pętla histerezy)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TurnOFFTempControlling_rbtn
            // 
            this.TurnOFFTempControlling_rbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnOFFTempControlling_rbtn.AutoSize = true;
            this.TurnOFFTempControlling_rbtn.Checked = true;
            this.TurnOFFTempControlling_rbtn.Location = new System.Drawing.Point(16, 19);
            this.TurnOFFTempControlling_rbtn.Name = "TurnOFFTempControlling_rbtn";
            this.TurnOFFTempControlling_rbtn.Size = new System.Drawing.Size(14, 13);
            this.TurnOFFTempControlling_rbtn.TabIndex = 23;
            this.TurnOFFTempControlling_rbtn.TabStop = true;
            this.TurnOFFTempControlling_rbtn.UseVisualStyleBackColor = true;
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
            this.label4.Size = new System.Drawing.Size(302, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Wyłącz sterowanie (tryb temperatury max.)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TempControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(373, 208);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetTemperature_btn;
        private System.Windows.Forms.TextBox Temperature_tbx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton TurnONTempControlling_rbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox irrigatemodegroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton TurnOFFTempControlling_rbtn;
        private System.Windows.Forms.Label label4;
    }
}