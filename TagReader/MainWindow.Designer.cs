using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TagReader.Properties;

namespace TagReader
{
    partial class FormTagReader
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTagReader));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.listView_Data = new System.Windows.Forms.ListView();
            this.columnHeader_Epc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Antenna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_TimeStamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Rssi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Phase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_TagCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chart_Rssi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_EPC = new System.Windows.Forms.Label();
            this.comboBoxEPCs = new System.Windows.Forms.ComboBox();
            this.label_Antenna = new System.Windows.Forms.Label();
            this.comboBoxAntennas = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_QuickAccess = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Connect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Settings = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel_NameReport = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_TotalReport = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_NameEvent = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_TotalEvent = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_RunTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip_ReaderSettings = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Address = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_Address = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel_Power = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_Power = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel_Frequency = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_Frequency = new System.Windows.Forms.ToolStripComboBox();
            this.Picture_Recording_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart_Phase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox_Camera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Videoecode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Rssi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip_QuickAccess.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip_ReaderSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Phase)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Data
            // 
            this.listView_Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Epc,
            this.columnHeader_Antenna,
            this.columnHeader_TimeStamp,
            this.columnHeader_Rssi,
            this.columnHeader_Phase,
            this.columnHeader_TagCount});
            this.listView_Data.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Data.GridLines = true;
            this.listView_Data.HideSelection = false;
            this.listView_Data.Location = new System.Drawing.Point(13, 62);
            this.listView_Data.Margin = new System.Windows.Forms.Padding(4);
            this.listView_Data.Name = "listView_Data";
            this.listView_Data.Size = new System.Drawing.Size(1103, 169);
            this.listView_Data.TabIndex = 2;
            this.listView_Data.UseCompatibleStateImageBehavior = false;
            this.listView_Data.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Epc
            // 
            this.columnHeader_Epc.Text = "EPC";
            this.columnHeader_Epc.Width = 112;
            // 
            // columnHeader_Antenna
            // 
            this.columnHeader_Antenna.Text = "Antenna";
            this.columnHeader_Antenna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Antenna.Width = 96;
            // 
            // columnHeader_TimeStamp
            // 
            this.columnHeader_TimeStamp.Text = "TimeStamp";
            this.columnHeader_TimeStamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_TimeStamp.Width = 139;
            // 
            // columnHeader_Rssi
            // 
            this.columnHeader_Rssi.Text = "Rssi";
            this.columnHeader_Rssi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Rssi.Width = 140;
            // 
            // columnHeader_Phase
            // 
            this.columnHeader_Phase.Text = "Phase";
            this.columnHeader_Phase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Phase.Width = 148;
            // 
            // columnHeader_TagCount
            // 
            this.columnHeader_TagCount.Text = "TagCount";
            this.columnHeader_TagCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_TagCount.Width = 120;
            // 
            // chart_Rssi
            // 
            this.chart_Rssi.BackColor = System.Drawing.Color.Transparent;
            this.chart_Rssi.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.Maximum = -20D;
            chartArea1.AxisY.Minimum = -75D;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_Rssi.ChartAreas.Add(chartArea1);
            this.chart_Rssi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend1.IsDockedInsideChartArea = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend1.MaximumAutoSize = 25F;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.chart_Rssi.Legends.Add(legend1);
            this.chart_Rssi.Location = new System.Drawing.Point(9, 257);
            this.chart_Rssi.Margin = new System.Windows.Forms.Padding(0);
            this.chart_Rssi.Name = "chart_Rssi";
            this.chart_Rssi.Size = new System.Drawing.Size(390, 284);
            this.chart_Rssi.TabIndex = 3;
            this.chart_Rssi.Text = "chart_Rssi";
            title1.Name = "Title_Rssi";
            title1.Text = "RSSI";
            this.chart_Rssi.Titles.Add(title1);
            // 
            // label_EPC
            // 
            this.label_EPC.AutoSize = true;
            this.label_EPC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EPC.Location = new System.Drawing.Point(14, 239);
            this.label_EPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_EPC.Name = "label_EPC";
            this.label_EPC.Size = new System.Drawing.Size(41, 21);
            this.label_EPC.TabIndex = 5;
            this.label_EPC.Text = "EPC:";
            // 
            // comboBoxEPCs
            // 
            this.comboBoxEPCs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEPCs.FormattingEnabled = true;
            this.comboBoxEPCs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxEPCs.Location = new System.Drawing.Point(60, 239);
            this.comboBoxEPCs.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEPCs.Name = "comboBoxEPCs";
            this.comboBoxEPCs.Size = new System.Drawing.Size(146, 23);
            this.comboBoxEPCs.TabIndex = 6;
            // 
            // label_Antenna
            // 
            this.label_Antenna.AutoSize = true;
            this.label_Antenna.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Antenna.Location = new System.Drawing.Point(214, 240);
            this.label_Antenna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Antenna.Name = "label_Antenna";
            this.label_Antenna.Size = new System.Drawing.Size(75, 21);
            this.label_Antenna.TabIndex = 7;
            this.label_Antenna.Text = "Antenna:";
            // 
            // comboBoxAntennas
            // 
            this.comboBoxAntennas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAntennas.FormattingEnabled = true;
            this.comboBoxAntennas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxAntennas.Location = new System.Drawing.Point(294, 239);
            this.comboBoxAntennas.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAntennas.Name = "comboBoxAntennas";
            this.comboBoxAntennas.Size = new System.Drawing.Size(105, 23);
            this.comboBoxAntennas.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Save,
            this.ToolStripMenuItem_Copy});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ToolStripMenuItem_Save
            // 
            this.ToolStripMenuItem_Save.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_Save.Image")));
            this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
            this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(130, 26);
            this.ToolStripMenuItem_Save.Text = "Save";
            this.ToolStripMenuItem_Save.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // ToolStripMenuItem_Copy
            // 
            this.ToolStripMenuItem_Copy.Name = "ToolStripMenuItem_Copy";
            this.ToolStripMenuItem_Copy.Size = new System.Drawing.Size(130, 26);
            this.ToolStripMenuItem_Copy.Text = "Copy";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Connect,
            this.ToolStripMenuItem_Start,
            this.ToolStripMenuItem_Stop});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // ToolStripMenuItem_Connect
            // 
            this.ToolStripMenuItem_Connect.Image = global::TagReader.Properties.Resources.ic_link;
            this.ToolStripMenuItem_Connect.Name = "ToolStripMenuItem_Connect";
            this.ToolStripMenuItem_Connect.Size = new System.Drawing.Size(153, 26);
            this.ToolStripMenuItem_Connect.Text = "Connect";
            this.ToolStripMenuItem_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // ToolStripMenuItem_Start
            // 
            this.ToolStripMenuItem_Start.Image = global::TagReader.Properties.Resources.play;
            this.ToolStripMenuItem_Start.Name = "ToolStripMenuItem_Start";
            this.ToolStripMenuItem_Start.Size = new System.Drawing.Size(153, 26);
            this.ToolStripMenuItem_Start.Text = "Start";
            this.ToolStripMenuItem_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // ToolStripMenuItem_Stop
            // 
            this.ToolStripMenuItem_Stop.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_Stop.Image")));
            this.ToolStripMenuItem_Stop.Name = "ToolStripMenuItem_Stop";
            this.ToolStripMenuItem_Stop.Size = new System.Drawing.Size(153, 26);
            this.ToolStripMenuItem_Stop.Text = "Stop";
            this.ToolStripMenuItem_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Settings,
            this.viewToolStripMenuItem,
            this.ToolStripMenuItem_Help,
            this.ToolStripMenuItem_About});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // ToolStripMenuItem_Settings
            // 
            this.ToolStripMenuItem_Settings.Image = global::TagReader.Properties.Resources.settings;
            this.ToolStripMenuItem_Settings.Name = "ToolStripMenuItem_Settings";
            this.ToolStripMenuItem_Settings.Size = new System.Drawing.Size(152, 26);
            this.ToolStripMenuItem_Settings.Text = "Settings";
            this.ToolStripMenuItem_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickAccessToolStripMenuItem,
            this.readerSettingsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // quickAccessToolStripMenuItem
            // 
            this.quickAccessToolStripMenuItem.Checked = true;
            this.quickAccessToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.quickAccessToolStripMenuItem.Name = "quickAccessToolStripMenuItem";
            this.quickAccessToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.quickAccessToolStripMenuItem.Text = "Quick Access";
            this.quickAccessToolStripMenuItem.Click += new System.EventHandler(this.quickAccessToolStripMenuItem_Click);
            // 
            // readerSettingsToolStripMenuItem
            // 
            this.readerSettingsToolStripMenuItem.Checked = true;
            this.readerSettingsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.readerSettingsToolStripMenuItem.Name = "readerSettingsToolStripMenuItem";
            this.readerSettingsToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.readerSettingsToolStripMenuItem.Text = "Reader Settings";
            this.readerSettingsToolStripMenuItem.Click += new System.EventHandler(this.readerSettingsToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(152, 26);
            this.ToolStripMenuItem_Help.Text = "Help";
            // 
            // ToolStripMenuItem_About
            // 
            this.ToolStripMenuItem_About.Image = global::TagReader.Properties.Resources.about;
            this.ToolStripMenuItem_About.Name = "ToolStripMenuItem_About";
            this.ToolStripMenuItem_About.Size = new System.Drawing.Size(152, 26);
            this.ToolStripMenuItem_About.Text = "About";
            this.ToolStripMenuItem_About.Click += new System.EventHandler(this.ToolStripMenuItem_About_Click);
            // 
            // toolStrip_QuickAccess
            // 
            this.toolStrip_QuickAccess.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_QuickAccess.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_QuickAccess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Save,
            this.toolStripSeparator1,
            this.toolStripButton_Connect,
            this.toolStripButton_Start,
            this.toolStripButton_Stop,
            this.toolStripButton_Clear,
            this.toolStripButton_Refresh,
            this.toolStripSeparator2,
            this.toolStripButton_Settings});
            this.toolStrip_QuickAccess.Location = new System.Drawing.Point(0, 28);
            this.toolStrip_QuickAccess.Name = "toolStrip_QuickAccess";
            this.toolStrip_QuickAccess.Size = new System.Drawing.Size(573, 27);
            this.toolStrip_QuickAccess.TabIndex = 10;
            this.toolStrip_QuickAccess.Text = "toolStrip1";
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Save.Image")));
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(67, 24);
            this.toolStripButton_Save.Tag = "";
            this.toolStripButton_Save.Text = "Save";
            this.toolStripButton_Save.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_Connect
            // 
            this.toolStripButton_Connect.Image = global::TagReader.Properties.Resources.ic_link;
            this.toolStripButton_Connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Connect.Name = "toolStripButton_Connect";
            this.toolStripButton_Connect.Size = new System.Drawing.Size(94, 24);
            this.toolStripButton_Connect.Text = "Connect";
            this.toolStripButton_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.Image = global::TagReader.Properties.Resources.play;
            this.toolStripButton_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Start.Name = "toolStripButton_Start";
            this.toolStripButton_Start.Size = new System.Drawing.Size(68, 24);
            this.toolStripButton_Start.Text = "Start";
            this.toolStripButton_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // toolStripButton_Stop
            // 
            this.toolStripButton_Stop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Stop.Image")));
            this.toolStripButton_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Stop.Name = "toolStripButton_Stop";
            this.toolStripButton_Stop.Size = new System.Drawing.Size(68, 24);
            this.toolStripButton_Stop.Text = "Stop";
            this.toolStripButton_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // toolStripButton_Clear
            // 
            this.toolStripButton_Clear.Image = global::TagReader.Properties.Resources.delete;
            this.toolStripButton_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Clear.Name = "toolStripButton_Clear";
            this.toolStripButton_Clear.Size = new System.Drawing.Size(70, 24);
            this.toolStripButton_Clear.Text = "Clear";
            this.toolStripButton_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // toolStripButton_Refresh
            // 
            this.toolStripButton_Refresh.Image = global::TagReader.Properties.Resources.refresh;
            this.toolStripButton_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Refresh.Name = "toolStripButton_Refresh";
            this.toolStripButton_Refresh.Size = new System.Drawing.Size(88, 24);
            this.toolStripButton_Refresh.Text = "Refresh";
            this.toolStripButton_Refresh.Click += new System.EventHandler(this.toolStripButton_Refresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_Settings
            // 
            this.toolStripButton_Settings.Image = global::TagReader.Properties.Resources.settings;
            this.toolStripButton_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Settings.Name = "toolStripButton_Settings";
            this.toolStripButton_Settings.Size = new System.Drawing.Size(93, 24);
            this.toolStripButton_Settings.Text = "Settings";
            this.toolStripButton_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Message,
            this.toolStripProgressBar,
            this.toolStripStatusLabel_NameReport,
            this.toolStripStatusLabel_TotalReport,
            this.toolStripStatusLabel_NameEvent,
            this.toolStripStatusLabel_TotalEvent,
            this.toolStripStatusLabel_RunTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 897);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1134, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Message
            // 
            this.toolStripStatusLabel_Message.Name = "toolStripStatusLabel_Message";
            this.toolStripStatusLabel_Message.Size = new System.Drawing.Size(655, 20);
            this.toolStripStatusLabel_Message.Spring = true;
            this.toolStripStatusLabel_Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(133, 18);
            // 
            // toolStripStatusLabel_NameReport
            // 
            this.toolStripStatusLabel_NameReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_NameReport.Name = "toolStripStatusLabel_NameReport";
            this.toolStripStatusLabel_NameReport.Size = new System.Drawing.Size(101, 20);
            this.toolStripStatusLabel_NameReport.Text = "Total Report";
            // 
            // toolStripStatusLabel_TotalReport
            // 
            this.toolStripStatusLabel_TotalReport.Name = "toolStripStatusLabel_TotalReport";
            this.toolStripStatusLabel_TotalReport.Size = new System.Drawing.Size(18, 20);
            this.toolStripStatusLabel_TotalReport.Text = "0";
            // 
            // toolStripStatusLabel_NameEvent
            // 
            this.toolStripStatusLabel_NameEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_NameEvent.Name = "toolStripStatusLabel_NameEvent";
            this.toolStripStatusLabel_NameEvent.Size = new System.Drawing.Size(90, 20);
            this.toolStripStatusLabel_NameEvent.Text = "Total Event";
            // 
            // toolStripStatusLabel_TotalEvent
            // 
            this.toolStripStatusLabel_TotalEvent.Name = "toolStripStatusLabel_TotalEvent";
            this.toolStripStatusLabel_TotalEvent.Size = new System.Drawing.Size(18, 20);
            this.toolStripStatusLabel_TotalEvent.Text = "0";
            // 
            // toolStripStatusLabel_RunTime
            // 
            this.toolStripStatusLabel_RunTime.Image = global::TagReader.Properties.Resources.alarm;
            this.toolStripStatusLabel_RunTime.Name = "toolStripStatusLabel_RunTime";
            this.toolStripStatusLabel_RunTime.Size = new System.Drawing.Size(97, 20);
            this.toolStripStatusLabel_RunTime.Text = "Run Time";
            // 
            // toolStrip_ReaderSettings
            // 
            this.toolStrip_ReaderSettings.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_ReaderSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_ReaderSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Address,
            this.toolStripTextBox_Address,
            this.toolStripLabel_Power,
            this.toolStripTextBox_Power,
            this.toolStripLabel_Frequency,
            this.toolStripComboBox_Frequency});
            this.toolStrip_ReaderSettings.Location = new System.Drawing.Point(584, 28);
            this.toolStrip_ReaderSettings.Name = "toolStrip_ReaderSettings";
            this.toolStrip_ReaderSettings.Size = new System.Drawing.Size(544, 28);
            this.toolStrip_ReaderSettings.TabIndex = 12;
            this.toolStrip_ReaderSettings.Text = "toolStrip2";
            // 
            // toolStripLabel_Address
            // 
            this.toolStripLabel_Address.Name = "toolStripLabel_Address";
            this.toolStripLabel_Address.Size = new System.Drawing.Size(73, 25);
            this.toolStripLabel_Address.Text = "Address:";
            // 
            // toolStripTextBox_Address
            // 
            this.toolStripTextBox_Address.Name = "toolStripTextBox_Address";
            this.toolStripTextBox_Address.Size = new System.Drawing.Size(159, 28);
            this.toolStripTextBox_Address.Click += new System.EventHandler(this.toolStripTextBox_Address_Click);
            // 
            // toolStripLabel_Power
            // 
            this.toolStripLabel_Power.Name = "toolStripLabel_Power";
            this.toolStripLabel_Power.Size = new System.Drawing.Size(59, 25);
            this.toolStripLabel_Power.Text = "Power:";
            // 
            // toolStripTextBox_Power
            // 
            this.toolStripTextBox_Power.Name = "toolStripTextBox_Power";
            this.toolStripTextBox_Power.Size = new System.Drawing.Size(65, 28);
            this.toolStripTextBox_Power.Click += new System.EventHandler(this.toolStripTextBox_Power_Click);
            // 
            // toolStripLabel_Frequency
            // 
            this.toolStripLabel_Frequency.Name = "toolStripLabel_Frequency";
            this.toolStripLabel_Frequency.Size = new System.Drawing.Size(89, 25);
            this.toolStripLabel_Frequency.Text = "Frequency:";
            // 
            // toolStripComboBox_Frequency
            // 
            this.toolStripComboBox_Frequency.Items.AddRange(new object[] {
            "920.625",
            "920.875",
            "921.125",
            "921.375",
            "921.625",
            "921.875",
            "922.125",
            "922.375",
            "922.625",
            "922.875",
            "923.125",
            "923.375",
            "923.625",
            "923.875",
            "924.125",
            "924.375"});
            this.toolStripComboBox_Frequency.Name = "toolStripComboBox_Frequency";
            this.toolStripComboBox_Frequency.Size = new System.Drawing.Size(80, 28);
            this.toolStripComboBox_Frequency.Click += new System.EventHandler(this.toolStripComboBox_Frequency_Click);
            // 
            // Picture_Recording_Button
            // 
            this.Picture_Recording_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Picture_Recording_Button.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Picture_Recording_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Picture_Recording_Button.Location = new System.Drawing.Point(951, 239);
            this.Picture_Recording_Button.Name = "Picture_Recording_Button";
            this.Picture_Recording_Button.Size = new System.Drawing.Size(165, 23);
            this.Picture_Recording_Button.TabIndex = 1;
            this.Picture_Recording_Button.TabStop = false;
            this.Picture_Recording_Button.Text = "开启摄像头";
            this.Picture_Recording_Button.UseVisualStyleBackColor = true;
            this.Picture_Recording_Button.Click += new System.EventHandler(this.Picture_Recording_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(404, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chart_Phase
            // 
            this.chart_Phase.AllowDrop = true;
            this.chart_Phase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chart_Phase.BackColor = System.Drawing.Color.Transparent;
            this.chart_Phase.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.Maximum = 6.3D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea2";
            this.chart_Phase.ChartAreas.Add(chartArea2);
            legend2.DockedToChartArea = "ChartArea2";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend2.IsDockedInsideChartArea = false;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend2.MaximumAutoSize = 25F;
            legend2.Name = "Legend1";
            legend2.TitleBackColor = System.Drawing.Color.Transparent;
            this.chart_Phase.Legends.Add(legend2);
            this.chart_Phase.Location = new System.Drawing.Point(9, 539);
            this.chart_Phase.Margin = new System.Windows.Forms.Padding(0);
            this.chart_Phase.Name = "chart_Phase";
            this.chart_Phase.Size = new System.Drawing.Size(390, 284);
            this.chart_Phase.TabIndex = 4;
            this.chart_Phase.Text = "chart_Phase";
            title2.Name = "Title_Phase";
            title2.Text = "Phase";
            this.chart_Phase.Titles.Add(title2);
            // 
            // comboBox_Camera
            // 
            this.comboBox_Camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Camera.FormattingEnabled = true;
            this.comboBox_Camera.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_Camera.Location = new System.Drawing.Point(483, 239);
            this.comboBox_Camera.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Camera.Name = "comboBox_Camera";
            this.comboBox_Camera.Size = new System.Drawing.Size(166, 23);
            this.comboBox_Camera.TabIndex = 14;
            this.comboBox_Camera.SelectedIndexChanged += new System.EventHandler(this.comboBox_Camera_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(411, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "视频源:";
            // 
            // comboBox_Videoecode
            // 
            this.comboBox_Videoecode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Videoecode.FormattingEnabled = true;
            this.comboBox_Videoecode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_Videoecode.Location = new System.Drawing.Point(754, 239);
            this.comboBox_Videoecode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Videoecode.Name = "comboBox_Videoecode";
            this.comboBox_Videoecode.Size = new System.Drawing.Size(166, 23);
            this.comboBox_Videoecode.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(672, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "视频格式:";
            // 
            // FormTagReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 923);
            this.Controls.Add(this.comboBox_Videoecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Camera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_Phase);
            this.Controls.Add(this.listView_Data);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Picture_Recording_Button);
            this.Controls.Add(this.toolStrip_ReaderSettings);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip_QuickAccess);
            this.Controls.Add(this.comboBoxAntennas);
            this.Controls.Add(this.label_Antenna);
            this.Controls.Add(this.comboBoxEPCs);
            this.Controls.Add(this.label_EPC);
            this.Controls.Add(this.chart_Rssi);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTagReader";
            this.Text = "TagReader";
            this.Resize += new System.EventHandler(this.Form_TagReader_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Rssi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip_QuickAccess.ResumeLayout(false);
            this.toolStrip_QuickAccess.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip_ReaderSettings.ResumeLayout(false);
            this.toolStrip_ReaderSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Phase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Data;

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Rssi;
        
        private System.Windows.Forms.Label label_EPC;
        private System.Windows.Forms.Label label_Antenna;
        private System.Windows.Forms.ComboBox comboBoxAntennas;
        private System.Windows.Forms.ComboBox comboBoxEPCs;
        public System.Windows.Forms.ColumnHeader columnHeader_Epc;
        public System.Windows.Forms.ColumnHeader columnHeader_Antenna;
        public System.Windows.Forms.ColumnHeader columnHeader_TimeStamp;
        public System.Windows.Forms.ColumnHeader columnHeader_Rssi;
        public System.Windows.Forms.ColumnHeader columnHeader_Phase;
        private System.Windows.Forms.ColumnHeader columnHeader_TagCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Copy;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Connect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Start;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Stop;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Settings;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_About;
        private ToolStripButton toolStripButton_Save;
        private ToolStripButton toolStripButton_Connect;
        private ToolStripButton toolStripButton_Start;
        private ToolStripButton toolStripButton_Stop;
        private ToolStripButton toolStripButton_Clear;
        private ToolStripButton toolStripButton_Refresh;
        private ToolStripButton toolStripButton_Settings;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        public ToolStrip toolStrip_QuickAccess;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripStatusLabel toolStripStatusLabel_Message;
        private ToolStrip toolStrip_ReaderSettings;
        private ToolStripLabel toolStripLabel_Address;
        private ToolStripTextBox toolStripTextBox_Address;
        private ToolStripLabel toolStripLabel_Power;
        private ToolStripTextBox toolStripTextBox_Power;
        private ToolStripLabel toolStripLabel_Frequency;
        private ToolStripComboBox toolStripComboBox_Frequency;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem quickAccessToolStripMenuItem;
        private ToolStripMenuItem readerSettingsToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel_NameReport;
        private ToolStripStatusLabel toolStripStatusLabel_NameEvent;
        private ToolStripStatusLabel toolStripStatusLabel_RunTime;
        private ToolStripStatusLabel toolStripStatusLabel_TotalEvent;
        public ToolStripStatusLabel toolStripStatusLabel_TotalReport;
        private Button Picture_Recording_Button;
        private PictureBox pictureBox1;
        private Chart chart_Phase;
        private ComboBox comboBox_Camera;
        private Label label1;
        private ComboBox comboBox_Videoecode;
        private Label label2;
    }
}

