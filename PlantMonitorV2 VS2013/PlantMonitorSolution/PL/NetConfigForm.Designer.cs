namespace PlantMonitorV2
{
    partial class NetConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetConfigForm));
            this.netConfBtn = new System.Windows.Forms.Button();
            this.portTbx = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipAddrTbx = new System.Windows.Forms.TextBox();
            this.ipAddrLabel = new System.Windows.Forms.Label();
            this.netTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.netConfGroup = new System.Windows.Forms.GroupBox();
            this.netTableLayout.SuspendLayout();
            this.netConfGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // netConfBtn
            // 
            this.netConfBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.netConfBtn.Location = new System.Drawing.Point(50, 143);
            this.netConfBtn.Name = "netConfBtn";
            this.netConfBtn.Size = new System.Drawing.Size(100, 29);
            this.netConfBtn.TabIndex = 40;
            this.netConfBtn.Text = "OK";
            this.netConfBtn.UseVisualStyleBackColor = true;
            this.netConfBtn.Click += new System.EventHandler(this.netConfBtn_Click);
            // 
            // portTbx
            // 
            this.portTbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portTbx.Location = new System.Drawing.Point(3, 108);
            this.portTbx.Name = "portTbx";
            this.portTbx.Size = new System.Drawing.Size(194, 26);
            this.portTbx.TabIndex = 39;
            this.portTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portLabel
            // 
            this.portLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portLabel.Location = new System.Drawing.Point(3, 70);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(194, 35);
            this.portLabel.TabIndex = 38;
            this.portLabel.Text = "Port nasłuchu:";
            this.portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ipAddrTbx
            // 
            this.ipAddrTbx.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddrTbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipAddrTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipAddrTbx.Location = new System.Drawing.Point(3, 38);
            this.ipAddrTbx.Name = "ipAddrTbx";
            this.ipAddrTbx.Size = new System.Drawing.Size(194, 26);
            this.ipAddrTbx.TabIndex = 37;
            this.ipAddrTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ipAddrLabel
            // 
            this.ipAddrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipAddrLabel.AutoSize = true;
            this.ipAddrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipAddrLabel.Location = new System.Drawing.Point(3, 0);
            this.ipAddrLabel.Name = "ipAddrLabel";
            this.ipAddrLabel.Size = new System.Drawing.Size(194, 35);
            this.ipAddrLabel.TabIndex = 36;
            this.ipAddrLabel.Text = "Adres IP urządzenia:";
            this.ipAddrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // netTableLayout
            // 
            this.netTableLayout.ColumnCount = 1;
            this.netTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.netTableLayout.Controls.Add(this.ipAddrLabel, 0, 0);
            this.netTableLayout.Controls.Add(this.netConfBtn, 0, 4);
            this.netTableLayout.Controls.Add(this.ipAddrTbx, 0, 1);
            this.netTableLayout.Controls.Add(this.portTbx, 0, 3);
            this.netTableLayout.Controls.Add(this.portLabel, 0, 2);
            this.netTableLayout.Location = new System.Drawing.Point(6, 10);
            this.netTableLayout.Name = "netTableLayout";
            this.netTableLayout.RowCount = 5;
            this.netTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.netTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.netTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.netTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.netTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.netTableLayout.Size = new System.Drawing.Size(200, 175);
            this.netTableLayout.TabIndex = 41;
            // 
            // netConfGroup
            // 
            this.netConfGroup.Controls.Add(this.netTableLayout);
            this.netConfGroup.Location = new System.Drawing.Point(12, 12);
            this.netConfGroup.Name = "netConfGroup";
            this.netConfGroup.Size = new System.Drawing.Size(213, 191);
            this.netConfGroup.TabIndex = 42;
            this.netConfGroup.TabStop = false;
            // 
            // NetConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(235, 214);
            this.Controls.Add(this.netConfGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NetConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia sieciowe";
            this.netTableLayout.ResumeLayout(false);
            this.netTableLayout.PerformLayout();
            this.netConfGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ipAddrTbx;
        private System.Windows.Forms.Label ipAddrLabel;
        private System.Windows.Forms.TextBox portTbx;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button netConfBtn;
        private System.Windows.Forms.TableLayoutPanel netTableLayout;
        private System.Windows.Forms.GroupBox netConfGroup;
    }
}