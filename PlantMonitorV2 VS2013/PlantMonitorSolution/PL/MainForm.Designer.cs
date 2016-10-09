namespace PlantMonitorV2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.exit_btn = new System.Windows.Forms.Button();
            this.receivedConsole_tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.receivedConsole_gbx = new System.Windows.Forms.GroupBox();
            this.receivedConsole_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.programMenu = new System.Windows.Forms.MenuStrip();
            this.ShowData_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualSettings_SubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrimarySettings_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightControl_SubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Irrigation_SubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Temp_SubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetDevice_SubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetDate_SubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaSiecioweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Calibration_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalibrateWaterpH_SubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalibrateSoilpH_SubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Information_SubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_SubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.tray_btn = new System.Windows.Forms.Button();
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowApp_TrayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseApp_TrayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedConsole_gbx.SuspendLayout();
            this.receivedConsole_tlp.SuspendLayout();
            this.programMenu.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(12, 465);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(119, 47);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.Text = "Zakończ program";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // receivedConsole_tbx
            // 
            this.receivedConsole_tbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.receivedConsole_tbx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.receivedConsole_tlp.SetColumnSpan(this.receivedConsole_tbx, 2);
            this.receivedConsole_tbx.Cursor = System.Windows.Forms.Cursors.No;
            this.receivedConsole_tbx.Enabled = false;
            this.receivedConsole_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.receivedConsole_tbx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.receivedConsole_tbx.Location = new System.Drawing.Point(15, 40);
            this.receivedConsole_tbx.Multiline = true;
            this.receivedConsole_tbx.Name = "receivedConsole_tbx";
            this.receivedConsole_tbx.ReadOnly = true;
            this.receivedConsole_tbx.Size = new System.Drawing.Size(417, 357);
            this.receivedConsole_tbx.TabIndex = 0;
            this.receivedConsole_tbx.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.receivedConsole_tlp.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(132, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "PARAMETRY UPRAWY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receivedConsole_gbx
            // 
            this.receivedConsole_gbx.BackColor = System.Drawing.SystemColors.Control;
            this.receivedConsole_gbx.Controls.Add(this.receivedConsole_tlp);
            this.receivedConsole_gbx.Location = new System.Drawing.Point(12, 39);
            this.receivedConsole_gbx.Name = "receivedConsole_gbx";
            this.receivedConsole_gbx.Size = new System.Drawing.Size(460, 420);
            this.receivedConsole_gbx.TabIndex = 9;
            this.receivedConsole_gbx.TabStop = false;
            // 
            // receivedConsole_tlp
            // 
            this.receivedConsole_tlp.BackColor = System.Drawing.SystemColors.Control;
            this.receivedConsole_tlp.ColumnCount = 2;
            this.receivedConsole_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.receivedConsole_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.receivedConsole_tlp.Controls.Add(this.label3, 0, 0);
            this.receivedConsole_tlp.Controls.Add(this.receivedConsole_tbx, 0, 1);
            this.receivedConsole_tlp.Location = new System.Drawing.Point(6, 10);
            this.receivedConsole_tlp.Name = "receivedConsole_tlp";
            this.receivedConsole_tlp.RowCount = 2;
            this.receivedConsole_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.226221F));
            this.receivedConsole_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.77378F));
            this.receivedConsole_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.receivedConsole_tlp.Size = new System.Drawing.Size(448, 404);
            this.receivedConsole_tlp.TabIndex = 0;
            // 
            // programMenu
            // 
            this.programMenu.BackColor = System.Drawing.SystemColors.Control;
            this.programMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowData_MenuItem,
            this.PrimarySettings_MenuItem,
            this.Calibration_MenuItem,
            this.AboutProgram_MenuItem});
            this.programMenu.Location = new System.Drawing.Point(0, 0);
            this.programMenu.Name = "programMenu";
            this.programMenu.Size = new System.Drawing.Size(484, 24);
            this.programMenu.TabIndex = 23;
            this.programMenu.Text = "menuStrip1";
            // 
            // ShowData_MenuItem
            // 
            this.ShowData_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActualSettings_SubMenuItem});
            this.ShowData_MenuItem.Name = "ShowData_MenuItem";
            this.ShowData_MenuItem.Size = new System.Drawing.Size(66, 20);
            this.ShowData_MenuItem.Text = "Wyświetl";
            // 
            // ActualSettings_SubMenuItem
            // 
            this.ActualSettings_SubMenuItem.Name = "ActualSettings_SubMenuItem";
            this.ActualSettings_SubMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ActualSettings_SubMenuItem.Text = "Zadane ustawienia";
            this.ActualSettings_SubMenuItem.Click += new System.EventHandler(this.ActualSettings_submenuitem_Click);
            // 
            // PrimarySettings_MenuItem
            // 
            this.PrimarySettings_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LightControl_SubMenuItem,
            this.Irrigation_SubMenuItem,
            this.Temp_SubMenuItem,
            this.ResetDevice_SubMenuItem,
            this.SetDate_SubMenuItem,
            this.ustawieniaSiecioweToolStripMenuItem});
            this.PrimarySettings_MenuItem.Name = "PrimarySettings_MenuItem";
            this.PrimarySettings_MenuItem.Size = new System.Drawing.Size(146, 20);
            this.PrimarySettings_MenuItem.Text = "Ustawienia podstawowe";
            // 
            // LightControl_SubMenuItem
            // 
            this.LightControl_SubMenuItem.Name = "LightControl_SubMenuItem";
            this.LightControl_SubMenuItem.Size = new System.Drawing.Size(205, 22);
            this.LightControl_SubMenuItem.Text = "Lampa sodowa";
            this.LightControl_SubMenuItem.Click += new System.EventHandler(this.LightControl_submenuitem_Click);
            // 
            // Irrigation_SubMenuItem
            // 
            this.Irrigation_SubMenuItem.Name = "Irrigation_SubMenuItem";
            this.Irrigation_SubMenuItem.Size = new System.Drawing.Size(205, 22);
            this.Irrigation_SubMenuItem.Text = "Nawadnianie";
            this.Irrigation_SubMenuItem.Click += new System.EventHandler(this.Irrigation_submenuitem_Click);
            // 
            // Temp_SubMenuItem
            // 
            this.Temp_SubMenuItem.Name = "Temp_SubMenuItem";
            this.Temp_SubMenuItem.Size = new System.Drawing.Size(205, 22);
            this.Temp_SubMenuItem.Text = "Temperatura";
            this.Temp_SubMenuItem.Click += new System.EventHandler(this.Temp_submenuitem_Click);
            // 
            // ResetDevice_SubMenuItem
            // 
            this.ResetDevice_SubMenuItem.Name = "ResetDevice_SubMenuItem";
            this.ResetDevice_SubMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ResetDevice_SubMenuItem.Text = "Reset sterownika";
            this.ResetDevice_SubMenuItem.Click += new System.EventHandler(this.ResetDevice_submenuitem_Click);
            // 
            // SetDate_SubMenuItem
            // 
            this.SetDate_SubMenuItem.Name = "SetDate_SubMenuItem";
            this.SetDate_SubMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SetDate_SubMenuItem.Text = "Ustaw datę w sterowniku";
            this.SetDate_SubMenuItem.Click += new System.EventHandler(this.SetDate_submenuitem_Click);
            // 
            // ustawieniaSiecioweToolStripMenuItem
            // 
            this.ustawieniaSiecioweToolStripMenuItem.Name = "ustawieniaSiecioweToolStripMenuItem";
            this.ustawieniaSiecioweToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ustawieniaSiecioweToolStripMenuItem.Text = "Ustawienia sieciowe";
            this.ustawieniaSiecioweToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaSiecioweToolStripMenuItem_Click);
            // 
            // Calibration_MenuItem
            // 
            this.Calibration_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalibrateWaterpH_SubMenuItem,
            this.CalibrateSoilpH_SubMenuItem});
            this.Calibration_MenuItem.Name = "Calibration_MenuItem";
            this.Calibration_MenuItem.Size = new System.Drawing.Size(89, 20);
            this.Calibration_MenuItem.Text = "Kalibracja pH";
            // 
            // CalibrateWaterpH_SubMenuItem
            // 
            this.CalibrateWaterpH_SubMenuItem.Name = "CalibrateWaterpH_SubMenuItem";
            this.CalibrateWaterpH_SubMenuItem.Size = new System.Drawing.Size(158, 22);
            this.CalibrateWaterpH_SubMenuItem.Text = "Sonda pH wody";
            this.CalibrateWaterpH_SubMenuItem.Click += new System.EventHandler(this.CalibrateWaterpH_submenuitem_Click);
            // 
            // CalibrateSoilpH_SubMenuItem
            // 
            this.CalibrateSoilpH_SubMenuItem.Name = "CalibrateSoilpH_SubMenuItem";
            this.CalibrateSoilpH_SubMenuItem.Size = new System.Drawing.Size(158, 22);
            this.CalibrateSoilpH_SubMenuItem.Text = "Sonda pH gleby";
            this.CalibrateSoilpH_SubMenuItem.Click += new System.EventHandler(this.CalibrateSoilpH_submenuitem_Click);
            // 
            // AboutProgram_MenuItem
            // 
            this.AboutProgram_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Information_SubMenuItem,
            this.Help_SubMenuItem});
            this.AboutProgram_MenuItem.Name = "AboutProgram_MenuItem";
            this.AboutProgram_MenuItem.Size = new System.Drawing.Size(86, 20);
            this.AboutProgram_MenuItem.Text = "O programie";
            // 
            // Information_SubMenuItem
            // 
            this.Information_SubMenuItem.Name = "Information_SubMenuItem";
            this.Information_SubMenuItem.Size = new System.Drawing.Size(131, 22);
            this.Information_SubMenuItem.Text = "Informacje";
            this.Information_SubMenuItem.Click += new System.EventHandler(this.Information_submenuitem_Click);
            // 
            // Help_SubMenuItem
            // 
            this.Help_SubMenuItem.Name = "Help_SubMenuItem";
            this.Help_SubMenuItem.Size = new System.Drawing.Size(131, 22);
            this.Help_SubMenuItem.Text = "Pomoc";
            this.Help_SubMenuItem.Click += new System.EventHandler(this.Help_submenuitem_Click);
            // 
            // tray
            // 
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "Aplikacja dostępowa sterownika uprawy roślin";
            this.tray.Visible = true;
            // 
            // tray_btn
            // 
            this.tray_btn.Location = new System.Drawing.Point(353, 465);
            this.tray_btn.Name = "tray_btn";
            this.tray_btn.Size = new System.Drawing.Size(119, 47);
            this.tray_btn.TabIndex = 25;
            this.tray_btn.Text = "Schowaj do tray\'a";
            this.tray_btn.UseVisualStyleBackColor = true;
            this.tray_btn.Click += new System.EventHandler(this.tray_btn_Click);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowApp_TrayMenu,
            this.CloseApp_TrayMenu});
            this.trayMenu.Name = "traymenu";
            this.trayMenu.Size = new System.Drawing.Size(168, 48);
            // 
            // ShowApp_TrayMenu
            // 
            this.ShowApp_TrayMenu.Name = "ShowApp_TrayMenu";
            this.ShowApp_TrayMenu.Size = new System.Drawing.Size(167, 22);
            this.ShowApp_TrayMenu.Text = "Pokaż program";
            this.ShowApp_TrayMenu.Click += new System.EventHandler(this.ShowProgram_traymenu_Click);
            // 
            // CloseApp_TrayMenu
            // 
            this.CloseApp_TrayMenu.Name = "CloseApp_TrayMenu";
            this.CloseApp_TrayMenu.Size = new System.Drawing.Size(167, 22);
            this.CloseApp_TrayMenu.Text = "Zakończ program";
            this.CloseApp_TrayMenu.Click += new System.EventHandler(this.CloseProgram_traymenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 524);
            this.Controls.Add(this.tray_btn);
            this.Controls.Add(this.receivedConsole_gbx);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.programMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.programMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOXER - Interfejs użytkownika";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.receivedConsole_gbx.ResumeLayout(false);
            this.receivedConsole_tlp.ResumeLayout(false);
            this.receivedConsole_tlp.PerformLayout();
            this.programMenu.ResumeLayout(false);
            this.programMenu.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit_btn;
        public  System.Windows.Forms.TextBox receivedConsole_tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox receivedConsole_gbx;
        private System.Windows.Forms.TableLayoutPanel receivedConsole_tlp;
        private System.Windows.Forms.MenuStrip programMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowData_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActualSettings_SubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrimarySettings_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightControl_SubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Temp_SubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetDevice_SubMenuItem;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.Button tray_btn;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowApp_TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseApp_TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem SetDate_SubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Information_SubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help_SubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Calibration_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalibrateWaterpH_SubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalibrateSoilpH_SubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Irrigation_SubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaSiecioweToolStripMenuItem;
    }
}