namespace PlantMonitorV2
{
    partial class Irrigation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Irrigation));
            this.SetIrrigationSettings_btn = new System.Windows.Forms.Button();
            this.IrrigationWater_tbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.freqencybox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Freq_tbx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.waterbox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ManualMode_rbtn = new System.Windows.Forms.RadioButton();
            this.SoilMode_rbtn = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeMode_rbtn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.irrigatemodegroup = new System.Windows.Forms.GroupBox();
            this.freqencybox.SuspendLayout();
            this.waterbox.SuspendLayout();
            this.irrigatemodegroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetIrrigationSettings_btn
            // 
            this.SetIrrigationSettings_btn.Location = new System.Drawing.Point(169, 370);
            this.SetIrrigationSettings_btn.Name = "SetIrrigationSettings_btn";
            this.SetIrrigationSettings_btn.Size = new System.Drawing.Size(113, 37);
            this.SetIrrigationSettings_btn.TabIndex = 42;
            this.SetIrrigationSettings_btn.Text = "OK";
            this.SetIrrigationSettings_btn.UseVisualStyleBackColor = true;
            this.SetIrrigationSettings_btn.Click += new System.EventHandler(this.Irrigation_btn_Click);
            // 
            // IrrigationWater_tbx
            // 
            this.IrrigationWater_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IrrigationWater_tbx.Location = new System.Drawing.Point(159, 36);
            this.IrrigationWater_tbx.Name = "IrrigationWater_tbx";
            this.IrrigationWater_tbx.Size = new System.Drawing.Size(85, 26);
            this.IrrigationWater_tbx.TabIndex = 26;
            this.IrrigationWater_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(250, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "[ml]";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // freqencybox
            // 
            this.freqencybox.BackColor = System.Drawing.SystemColors.Control;
            this.freqencybox.Controls.Add(this.label7);
            this.freqencybox.Controls.Add(this.label2);
            this.freqencybox.Controls.Add(this.Freq_tbx);
            this.freqencybox.Controls.Add(this.label11);
            this.freqencybox.Location = new System.Drawing.Point(10, 179);
            this.freqencybox.Name = "freqencybox";
            this.freqencybox.Size = new System.Drawing.Size(446, 102);
            this.freqencybox.TabIndex = 44;
            this.freqencybox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(264, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "dni / dzień";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(119, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 30);
            this.label2.TabIndex = 39;
            this.label2.Text = "Częstotliwość podlewania:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Freq_tbx
            // 
            this.Freq_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Freq_tbx.Location = new System.Drawing.Point(172, 50);
            this.Freq_tbx.Name = "Freq_tbx";
            this.Freq_tbx.Size = new System.Drawing.Size(85, 26);
            this.Freq_tbx.TabIndex = 10;
            this.Freq_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(140, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Co";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waterbox
            // 
            this.waterbox.BackColor = System.Drawing.SystemColors.Control;
            this.waterbox.Controls.Add(this.label4);
            this.waterbox.Controls.Add(this.IrrigationWater_tbx);
            this.waterbox.Controls.Add(this.label5);
            this.waterbox.Location = new System.Drawing.Point(10, 287);
            this.waterbox.Name = "waterbox";
            this.waterbox.Size = new System.Drawing.Size(446, 77);
            this.waterbox.TabIndex = 45;
            this.waterbox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(172, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ilość wody:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManualMode_rbtn
            // 
            this.ManualMode_rbtn.AutoSize = true;
            this.ManualMode_rbtn.Location = new System.Drawing.Point(25, 130);
            this.ManualMode_rbtn.Name = "ManualMode_rbtn";
            this.ManualMode_rbtn.Size = new System.Drawing.Size(14, 13);
            this.ManualMode_rbtn.TabIndex = 25;
            this.ManualMode_rbtn.TabStop = true;
            this.ManualMode_rbtn.UseVisualStyleBackColor = true;
            this.ManualMode_rbtn.CheckedChanged += new System.EventHandler(this.Manual_rbtn_CheckedChanged);
            // 
            // SoilMode_rbtn
            // 
            this.SoilMode_rbtn.AutoSize = true;
            this.SoilMode_rbtn.Location = new System.Drawing.Point(25, 97);
            this.SoilMode_rbtn.Name = "SoilMode_rbtn";
            this.SoilMode_rbtn.Size = new System.Drawing.Size(14, 13);
            this.SoilMode_rbtn.TabIndex = 37;
            this.SoilMode_rbtn.TabStop = true;
            this.SoilMode_rbtn.UseVisualStyleBackColor = true;
            this.SoilMode_rbtn.CheckedChanged += new System.EventHandler(this.AutoSoil_rbtn_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(45, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(395, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Automatyczne podlewanie (względem wilgotności gleby)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(156, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tryb podlewania:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeMode_rbtn
            // 
            this.TimeMode_rbtn.AutoSize = true;
            this.TimeMode_rbtn.Location = new System.Drawing.Point(25, 63);
            this.TimeMode_rbtn.Name = "TimeMode_rbtn";
            this.TimeMode_rbtn.Size = new System.Drawing.Size(14, 13);
            this.TimeMode_rbtn.TabIndex = 23;
            this.TimeMode_rbtn.TabStop = true;
            this.TimeMode_rbtn.UseVisualStyleBackColor = true;
            this.TimeMode_rbtn.CheckedChanged += new System.EventHandler(this.AutoTime_rbtn_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(45, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Manualne podlewanie";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(45, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Automatyczne podlewanie (czasowe)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // irrigatemodegroup
            // 
            this.irrigatemodegroup.BackColor = System.Drawing.SystemColors.Control;
            this.irrigatemodegroup.Controls.Add(this.SoilMode_rbtn);
            this.irrigatemodegroup.Controls.Add(this.label8);
            this.irrigatemodegroup.Controls.Add(this.label1);
            this.irrigatemodegroup.Controls.Add(this.TimeMode_rbtn);
            this.irrigatemodegroup.Controls.Add(this.label6);
            this.irrigatemodegroup.Controls.Add(this.label3);
            this.irrigatemodegroup.Controls.Add(this.ManualMode_rbtn);
            this.irrigatemodegroup.Location = new System.Drawing.Point(10, 12);
            this.irrigatemodegroup.Name = "irrigatemodegroup";
            this.irrigatemodegroup.Size = new System.Drawing.Size(446, 161);
            this.irrigatemodegroup.TabIndex = 43;
            this.irrigatemodegroup.TabStop = false;
            // 
            // Irrigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 419);
            this.Controls.Add(this.SetIrrigationSettings_btn);
            this.Controls.Add(this.freqencybox);
            this.Controls.Add(this.waterbox);
            this.Controls.Add(this.irrigatemodegroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Irrigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sterowanie nawadnianiem";
            this.freqencybox.ResumeLayout(false);
            this.freqencybox.PerformLayout();
            this.waterbox.ResumeLayout(false);
            this.waterbox.PerformLayout();
            this.irrigatemodegroup.ResumeLayout(false);
            this.irrigatemodegroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetIrrigationSettings_btn;
        private System.Windows.Forms.TextBox IrrigationWater_tbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox freqencybox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Freq_tbx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox waterbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton ManualMode_rbtn;
        private System.Windows.Forms.RadioButton SoilMode_rbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton TimeMode_rbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox irrigatemodegroup;

    }
}