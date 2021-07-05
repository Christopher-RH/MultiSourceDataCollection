using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using TagReader.RFIDReader;
using System.Windows.Forms.DataVisualization.Charting;
using TagReader.Properties;
using System.Drawing;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Controls;

namespace TagReader
{
    public partial class FormTagReader : Form
    {
        #region 变量声明

        private static bool _isConnected2Reader;
        private static bool _isStartButtonClicked;
        public  static bool IsStopButtonClicked;
        private static bool _isClearButtonClicked;
        public  static bool IsSettingsButtonClicked;
        public  static bool IsSettigsWindowShowing;
        private static bool _showQuickAccessToolStrip = true;
        private static bool _showReaderSettingsToolStrip = true;
        private static bool _isFirstClickStart = true;   //判断是不是第一次点击Start按钮
        private RotateFlipType rft = RotateFlipType.RotateNoneFlipX; //设置图像水平翻转
        public FilterInfoCollection Cameras = null;//视频输入设备（摄像头）的集合
        public VideoCaptureDevice Cam = null;      //本程序使用的那个摄像头

        #endregion

        #region 构造函数
        public FormTagReader()
        {
            this.Load += Form_Load;    //初始化界面状态，导入视频设备
            this.FormClosed += Form_Closed;
        }
        #endregion

        #region 界面初始化及摄像头调用
        ///<summary>
        ///窗体构造函数的Load事件处理程序
        ///用于获取摄像头设备，初始化界面状态
        ///</summary>
        ///<paramname="sender"></param>
        ///<paramname="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            ReaderWrapper.MainForm = this;
            ReaderWrapper.Initialize_Configuration();

            Picture_Recording_Button.Enabled = false;

            toolStripButton_Save.Enabled = false;
            toolStripButton_Connect.Enabled = true;
            toolStripButton_Start.Enabled = false;
            toolStripButton_Stop.Enabled = false;
            toolStripButton_Clear.Enabled = false;
            toolStripButton_Refresh.Enabled = false;
            toolStripButton_Settings.Enabled = true;

            ToolStripMenuItem_Save.Enabled = false;
            ToolStripMenuItem_Connect.Enabled = true;
            ToolStripMenuItem_Start.Enabled = false;
            ToolStripMenuItem_Stop.Enabled = false;
            ToolStripMenuItem_Settings.Enabled = true;

            toolStripTextBox_Address.Text = ReaderWrapper.ReaderParameters.Ip;
            toolStripTextBox_Power.Text = Convert.ToString(
                ReaderWrapper.ReaderParameters.TransmitPower, CultureInfo.InvariantCulture);
            toolStripComboBox_Frequency.Text = Convert.ToString(
                ReaderSettings.Channal2Frequency(ReaderWrapper.ReaderParameters.ChannelIndex), CultureInfo.InvariantCulture);

            try
            {
                //1、获取并枚举所有摄像头设备
                Cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                //2、判断设备个数，选择某一设备
                if (Cameras.Count > 0)
                {
                    Picture_Recording_Button.Enabled = true;
                    //Cam = new VideoCaptureDevice(Cameras[1].MonikerString);
                    foreach (FilterInfo device in Cameras)
                    {
                        this.comboBox_Camera.Items.Add(device.Name);
                    }
                    this.comboBox_Camera.SelectedIndex = 1;   // 默认先使用第二个摄像头
                    //Cam.NewFrame += Cam_NewFrame;
                }
                else
                {
                    MessageBox.Show("未找到视频输入设备！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        ///<summary>
        ///摄像头设备Cam的NewFrame事件处理程序
        ///用于实时显示捕获的视频流
        ///</summary>
        ///<paramname="sender"></param>
        ///<paramname="eventArgs"></param>
        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            eventArgs.Frame.RotateFlip(rft);
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }


        ///<summary>
        ///点击开启摄像头按钮的事件处理程序
        ///用于控制摄像头的开启、关闭
        ///</summary>
        ///<paramname="sender"></param>
        ///<paramname="e"></param>
        private void Picture_Recording_Button_Click(object sender, EventArgs e)
        {
            if (Picture_Recording_Button.Text.Trim() == "开启摄像头")
            {
                Picture_Recording_Button.Text = "关闭摄像头";
                Cam.Start();
                comboBox_Camera.Enabled = false;   //开启摄像头后不可更改视频源
            }
            else
            {
                Picture_Recording_Button.Text = "开启摄像头";
                Cam.Stop();
                comboBox_Camera.Enabled = true;    //关闭摄像头后可更改视频源
            }
        }

        ///<summary>
        ///点击视频源下拉菜单的事件处理程序
        ///用于选择摄像头源
        ///</summary>
        ///<paramname="sender"></param>
        ///<paramname="e"></param>
        private void comboBox_Camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_index = this.comboBox_Camera.SelectedIndex;
            Cam = new VideoCaptureDevice(Cameras[selected_index].MonikerString);
            Cam.NewFrame += Cam_NewFrame;
        }

        ///<summary>
        ///在关闭窗体的事件处理程序中，释放摄像头
        ///</summary>
        ///<paramname="sender"></param>
        ///<paramname="e"></param>
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            if (Cam != null && Cam.IsRunning)
            {
                Cam.Stop();
            }
        }

        #endregion

        #region 更新组件

        public ulong _startTime;
        public DateTime _startTimeDateTime;
        public int ConvertTime(ulong time)
        {
            var ts = time - _startTime;
            return (int) (ts / 1000000);
        }


        private static HashSet<TagInfos.Key> _keySet = new HashSet<TagInfos.Key>();
        public void AddListItem(ref TagStatus tagStatus)
        {
            var epc = tagStatus.Epc;
            var antenna = tagStatus.Antenna;
            var channel = tagStatus.ChannelIndex;
            var key = new TagInfos.Key(epc, antenna, channel);
            
            if (_keySet.Contains(key))
            {
                foreach (ListViewItem item in listView_Data.Items)
                {
                    if (item.SubItems[0].Text != epc || Convert.ToUInt16(item.SubItems[1].Text) != antenna)
                        continue;
                    //item.SubItems[2].Text = ConvertTime(tagStatus.TimeStamp).ToString(); // time
                    item.SubItems[2].Text = tagStatus.TimeStamp.ToString(); // time
                    item.SubItems[3].Text = tagStatus.Rssi.ToString(CultureInfo.InvariantCulture); // rssi
                    item.SubItems[4].Text = tagStatus.PhaseRadian.ToString(CultureInfo.InvariantCulture);// phase
                    item.SubItems[5].Text = tagStatus.TagSeenCount.ToString();// count
                }
            }
            else
            {
                var lvi = new ListViewItem(epc);
                lvi.SubItems.Add(antenna.ToString());
                lvi.SubItems.Add(ConvertTime(tagStatus.TimeStamp).ToString());
                lvi.SubItems.Add(tagStatus.Rssi.ToString(CultureInfo.InvariantCulture));
                lvi.SubItems.Add(tagStatus.PhaseRadian.ToString(CultureInfo.InvariantCulture));
                //lvi.SubItems.Add(tagStatus.DopplerShift.ToString());
                //lvi.SubItems.Add(tagStatus.Velocity.ToString(CultureInfo.InvariantCulture));
                lvi.SubItems.Add(tagStatus.TagSeenCount.ToString());

                listView_Data.Items.Add(lvi);
                _keySet.Add(key);
            }
        }

        private static Dictionary<TagInfos.Key, int> _map = new Dictionary<TagInfos.Key, int>(); 
        public void UpdateChart(ref TagStatus tagStatus)
        {
            var epc = tagStatus.Epc;
            var antenna = tagStatus.Antenna;
            var channel = tagStatus.ChannelIndex;
            var key = new TagInfos.Key(epc, antenna, channel);
            var time = tagStatus.TimeStamp;

            if (!_map.ContainsKey(key))
            {
                _isClearButtonClicked = false;
                if (_startTime == 0)
                {
                    _startTime = time;
                    var dt = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                    _startTimeDateTime = dt.AddSeconds(Convert.ToDouble(_startTime / 1000000)).ToLocalTime();
                }
                    
                var s = new Series
                {
                    ChartType = SeriesChartType.FastLine,
                    Name = epc + "_" + antenna
                };
                chart_Rssi.Series.Add(s);


                var s1 = new Series
                {
                    ChartType = SeriesChartType.FastLine,
                    Name = epc + "_" + antenna
                };
                chart_Phase.Series.Add(s1);

                var s2 = new Series
                {
                    ChartType = SeriesChartType.FastLine,
                    Name = epc + "_" + antenna
                };
                _map.Add(key, _map.Count); // save index
            }
            var seriesId = _map[key];

            chart_Rssi.Series[seriesId].Points.AddXY(ConvertTime(time), tagStatus.Rssi);
            chart_Rssi.Series[seriesId].LegendText = epc.Substring(epc.Length - 4, 4) + "_" + antenna;

            chart_Phase.Series[seriesId].Points.AddXY(ConvertTime(time), tagStatus.PhaseRadian);
            chart_Phase.Series[seriesId].LegendText = epc.Substring(epc.Length - 4, 4) + "_" + antenna;

            if (SettingsWindow.IsTimerModeActied)
            {
                var t = ConvertTime(time);
                Invoke(new Action(() =>
                {
                    UpdateStatusBar_ProgressBar(ref t);
                }));

                if (t < ReaderWrapper.ReaderParameters.Duration) return;
                StopReceive();

                if (!SettingsWindow.IsAutoSaveChecked) return;
                var fpath = @"C:\Users\Lab\Desktop\";
                if (!Directory.Exists(fpath))
                    Directory.CreateDirectory(fpath);

                var dt = DateTime.Now;
                var strCurrentTime = dt.ToString("yyyyMMdd_HHmmss");
                var fname = strCurrentTime + ".csv";
                var csvWriter = new CsvStreamWriter(fpath + fname);
                ReaderWrapper.SaveData(csvWriter);
            }
        }

        public void UpdateStatusBar_ProgressBar(ref int val)
        {
            toolStripProgressBar.Value = val;
            if (toolStripProgressBar.Value < toolStripProgressBar.Maximum)
            {
                toolStripProgressBar.PerformStep();
            }
            else
            {
                SettingsWindow.IsAutoSaveChecked = false;
            }
        }

        public void UpdateStatusBar_Message(ref string str)
        {
            toolStripStatusLabel_Message.Text = str;
        }

        public void UpdateStatusBar_Event()
        {
            toolStripStatusLabel_TotalEvent.Text = ReaderWrapper.TotalEvent.ToString();
        }

        public void UpdateStatusBar_Report()
        {
            toolStripStatusLabel_TotalReport.Text = ReaderWrapper.TotalReport.ToString();
        }

        public void UpdateStatusBar_Time(ulong timestamp)
        {
                System.DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                dt = dt.AddSeconds(Convert.ToDouble(timestamp / 1000000)).ToLocalTime();

                TimeSpan time = dt - _startTimeDateTime;
                toolStripStatusLabel_RunTime.Text = time.Hours + @" : " + time.Minutes + @" : " + time.Seconds;          
        }

        private void Form_TagReader_Resize(object sender, EventArgs e)       //设置图表大小，以及位置对齐
        {
            //var h = Height/2;
            //chart_Rssi.Height = h;
            //chart_Phase.Height = h;
                
            //var w = Width/3;
            chart_Rssi.Left = 0;
            chart_Phase.Left = 0;

            //chart_Rssi.Width = w;
            //chart_Phase.Width = w;

        }

        #endregion

        #region 按钮点击事件响应

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (IsSettingsButtonClicked)
            {
                toolStripTextBox_Address.Text = ReaderWrapper.ReaderParameters.Ip;
                toolStripTextBox_Power.Text =
                    ReaderWrapper.ReaderParameters.TransmitPower.ToString(CultureInfo.InvariantCulture);
                toolStripComboBox_Frequency.Text =
                    Convert.ToString(ReaderSettings.Channal2Frequency(ReaderWrapper.ReaderParameters.ChannelIndex),
                        CultureInfo.InvariantCulture);
                //  Convert.ToString(920.625 + ReaderWrapper.ReaderParameters.ChannelIndex*0.25,
                //      CultureInfo.InvariantCulture);
            }
            else
            {
                var ipAddress = toolStripTextBox_Address.Text;
                var txPower = Convert.ToDouble(toolStripTextBox_Power.Text);
                var frequency = toolStripComboBox_Frequency.SelectedItem.ToString();

                if (ipAddress == string.Empty)
                {
                    MessageBox.Show("IP Address Cannot be Empty");
                }
                if (txPower < 10 || txPower > 32.5)
                {
                    MessageBox.Show("Invalid Power!");
                }   

                ReaderWrapper.ReaderParameters.Ip = ipAddress;
                ReaderWrapper.ReaderParameters.TransmitPower = txPower;
                ReaderWrapper.ReaderParameters.ChannelIndex = ReaderSettings.Frequency2Channal(Convert.ToDouble(frequency));
                //   Convert.ToUInt16((Convert.ToDouble(frequency) - 920.625)/0.25);
            }

            _isConnected2Reader = ReaderWrapper.ConnectToReader();

            //MessageBox.Show(_isConnected2Reader ? "Successfully Connected!" : "Connect Failed!");

            if (_isConnected2Reader)
            {
                toolStripButton_Settings.Enabled = false;
                ToolStripMenuItem_Settings.Enabled = false;

                toolStripButton_Connect.Enabled = false;
                ToolStripMenuItem_Connect.Enabled = false;

                toolStripButton_Start.Enabled = true;
                ToolStripMenuItem_Start.Enabled = true;

                toolStripTextBox_Address.Enabled = false;
                toolStripTextBox_Power.Enabled = false;
                toolStripComboBox_Frequency.Enabled = false;
                Picture_Recording_Button.Enabled = false;
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {


            if (_isConnected2Reader)
            {
                if (_isFirstClickStart)     //判断是否为第一次点击Start，可用于无需关掉程序，多次记录数据
                {
                    _isFirstClickStart = false;
                }
                else
                {
                    //toolStripButton_Connect.PerformClick();
                    //stopTimeSpan.Stop();
                }
                
                Picture_Recording_Button_Click(sender, e);  //调用开启摄像头按钮处理事件
                StartReceive();

                if (SettingsWindow.IsTimerModeActied)
                {
                    toolStripProgressBar.Maximum = ReaderWrapper.ReaderParameters.Duration;
                    toolStripProgressBar.Step = 1;
                }
            }
        }

        private void StartReceive()
        {
            ReaderWrapper.Start();
            if (_isFirstClickStart)     //判断是否为第一次点击Start，可用于无需关掉程序，多次记录数据
            {
                _startTime = 0;
            }


            //_startTime = 0;
            _isStartButtonClicked = true;
            IsStopButtonClicked = false;

            toolStripButton_Start.Enabled = false;
            ToolStripMenuItem_Start.Enabled = false;

            toolStripButton_Stop.Enabled = true;
            ToolStripMenuItem_Stop.Enabled = true;

            toolStripButton_Clear.Enabled = false;

            toolStripButton_Settings.Enabled = false;
            ToolStripMenuItem_Settings.Enabled = false;

            comboBox_Camera.Enabled = false;
        }


        private void button_Stop_Click(object sender, EventArgs e)
        {
            if (_isConnected2Reader && _isStartButtonClicked)
            {             
                //stopTimeSpan.Start();
                Picture_Recording_Button_Click(sender, e); //调用关闭摄像头按钮处理事件
                StopReceive();
            }
        }

        private void StopReceive()
        {
            IsStopButtonClicked = true;
            IsSettingsButtonClicked = false;
            _isClearButtonClicked = false;

            ReaderWrapper.Stop();

            chart_Rssi.EndInit();
            chart_Phase.EndInit();


            toolStripButton_Stop.Enabled = false;
            ToolStripMenuItem_Stop.Enabled = false;

            // 
            toolStripButton_Start.Enabled = true;
            ToolStripMenuItem_Start.Enabled = true;

            toolStripButton_Save.Enabled = true;
            ToolStripMenuItem_Save.Enabled = true;
            toolStripButton_Settings.Enabled = true;
            ToolStripMenuItem_Settings.Enabled = true;

            toolStripButton_Clear.Enabled = true;

            toolStripTextBox_Address.Enabled = true;
            toolStripTextBox_Power.Enabled = true;
            toolStripComboBox_Frequency.Enabled = true;
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "csv file|*.csv",
                FilterIndex = 1,
                RestoreDirectory = true,
                DefaultExt = ".csv"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var fpath = sfd.FileName;
                CsvStreamWriter csvWriter = new CsvStreamWriter(fpath);
                ReaderWrapper.SaveData(csvWriter);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            if (IsStopButtonClicked)
            {
                listView_Data.Items.Clear(); // clean up the Reader

                chart_Rssi.Dispose();
                chart_Phase.Dispose();
                pictureBox1.Dispose();

                toolStripStatusLabel_TotalEvent.Text = "0";
                toolStripStatusLabel_NameReport.Text = "0";
                var a = 0;
                UpdateStatusBar_ProgressBar(ref a);
                _isClearButtonClicked = true;
                comboBox_Camera.Enabled = true;
            }
        }

        private void toolStripButton_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            if (!IsSettigsWindowShowing)
            {
                var x = new SettingsWindow();
                x.Show();

                IsSettingsButtonClicked = true;
                IsSettigsWindowShowing = true;
            }
        }

        private void ToolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            var x = new AboutBox();
            x.Show();
        }
        
        private void quickAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_showQuickAccessToolStrip)
            {
                _showQuickAccessToolStrip = false;
                quickAccessToolStripMenuItem.Checked = false;
                toolStrip_QuickAccess.Visible = false;

                if (_showReaderSettingsToolStrip)
                {
                    toolStrip_ReaderSettings.Left = toolStrip_QuickAccess.Left;
                }
                else
                {
                    listView_Data.Top = toolStrip_QuickAccess.Top;
                    listView_Data.Height += toolStrip_QuickAccess.Height;
                }
            }
            else
            {
                _showQuickAccessToolStrip = true;
                quickAccessToolStripMenuItem.Checked = true;
                toolStrip_QuickAccess.Visible = true;
                if (_showReaderSettingsToolStrip)
                {
                    toolStrip_ReaderSettings.Left = toolStrip_QuickAccess.Right;
                }
                else
                {
                    listView_Data.Top += toolStrip_QuickAccess.Height;
                    listView_Data.Height -= toolStrip_QuickAccess.Height;
                }
            }
        }

        private void readerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_showReaderSettingsToolStrip)
            {
                _showReaderSettingsToolStrip = false;
                readerSettingsToolStripMenuItem.Checked = false;
                toolStrip_ReaderSettings.Visible = false;
                if (!_showQuickAccessToolStrip)
                {
                    listView_Data.Top = toolStrip_QuickAccess.Top;
                    listView_Data.Height += toolStrip_QuickAccess.Height;
                }
            }
            else
            {
                _showReaderSettingsToolStrip = true;
                readerSettingsToolStripMenuItem.Checked = true;
                toolStrip_ReaderSettings.Visible = true;
                if (_showQuickAccessToolStrip)
                {
                    toolStrip_ReaderSettings.Left = toolStrip_QuickAccess.Right;
                }
                else
                {
                    listView_Data.Top = toolStrip_QuickAccess.Bottom;
                    listView_Data.Height -= toolStrip_QuickAccess.Height;
                }
            }
        }

        #endregion

        #region 快捷栏设置信息填写

        private void toolStripTextBox_Power_Click(object sender, EventArgs e)
        {
            IsSettingsButtonClicked = false;
            IsSettigsWindowShowing = false;
        }

        private void toolStripTextBox_Address_Click(object sender, EventArgs e)
        {
            IsSettingsButtonClicked = false;
            IsSettigsWindowShowing = false;
        }

        private void toolStripComboBox_Frequency_Click(object sender, EventArgs e)
        {
            IsSettingsButtonClicked = false;
            IsSettigsWindowShowing = false;
        }
        #endregion

    } // end FormTagReader
} // end namespace
