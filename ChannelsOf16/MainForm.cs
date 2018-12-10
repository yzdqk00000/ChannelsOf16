using 延迟线收发组件_十六通道.Modules;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 延迟线收发组件_十六通道
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public BaseModule _Module;
        public SerialPort_Module SerialPort;
        public MainForm()
        {
            InitializeComponent();
    
            dockPanel.ClosingPanel += DockPanel_ClosingPanel;

            textEdit_串口号.Text = Function_Module.GetConfig("串口号");
            SerialPort = new SerialPort_Module(richTextBox1);
            SerialPortControl(true);

            ucStartTest2 ucstart = CreateModule("延迟线收发组件_十六通道.Modules.ucStartTest2") as ucStartTest2;

        }
        public static bool IsShowMsg = false;
        private void DockPanel_ClosingPanel(object sender, DevExpress.XtraBars.Docking.DockPanelCancelEventArgs e)
        {
            IsShowMsg = false;
        }

        /// <summary>
        /// 创建模块
        /// </summary>
        /// <param name="ModuleType"></param>
        /// <returns></returns>
        private BaseModule CreateModule(string ModuleType)
        {
            //添加视图
            _Module = Activator.CreateInstance(typeof(MainForm).Assembly.GetType(ModuleType)) as BaseModule;
            panelControl_Modules.Controls.Clear();
            panelControl_Modules.Controls.Add(_Module);
            _Module.Dock = DockStyle.Fill;
            return _Module;
        }

        /// <summary>
        /// 控制栏按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "打开串口(Q)":
                    SerialPortControl(true);
                    break;
                case "关闭串口(Q)":
                    SerialPortControl(false);
                    break;
                case "重置参数(R)":
                    //(_Module as ucStartTest2).ResetTestView();
                    break;
                case "发送指令(Space)":
                    SendCommands();
                    break;
                case "消息展示(E)":
                    DockPanelShowControl();
                    break;
                default:
                    break;
            }
           
        }

        /// <summary>
        /// 开关串口视图控制
        /// </summary>
        /// <param name="Open"></param>
        private void SerialPortControl(bool Open)
        {
            try
            {
                if (Open)
                {
                    SerialPort.SerialPort_Set(textEdit_串口号.Text, Convert.ToInt32(Function_Module.GetConfig("波特率")));
                    SerialPort.SerialPort_Open();
                    windowsUIButtonPanel1.Buttons.FindFirst(m => m.Properties.Caption == "打开串口(Q)").Properties.Image = global::延迟线收发组件_十六通道.Properties.Resources.squeeze_32x32;
                    windowsUIButtonPanel1.Buttons.FindFirst(m => m.Properties.Caption == "打开串口(Q)").Properties.Caption = "关闭串口(Q)";
                }
                else
                {
                    SerialPort.SerialPort_Close();
                    windowsUIButtonPanel1.Buttons.FindFirst(m => m.Properties.Caption == "关闭串口(Q)").Properties.Image = global::延迟线收发组件_十六通道.Properties.Resources.stretch_32x32;
                    windowsUIButtonPanel1.Buttons.FindFirst(m => m.Properties.Caption == "关闭串口(Q)").Properties.Caption = "打开串口(Q)";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 控制台显示控制
        /// </summary>
        private void DockPanelShowControl()
        {
            if (IsShowMsg == false)
            {
                dockPanel.Show();

                IsShowMsg = true;
            }
            else
            {
                dockPanel.Hide();
                IsShowMsg = false;
            }
        }

        /// <summary>
        /// 发送指令
        /// </summary>
        private void SendCommands()
        {
            (_Module as ucStartTest2).gridView1.CloseEditor();
            (_Module as ucStartTest2).gridView2.CloseEditor();
            SerialPort.SerialPort_Send(CommandAnalyzier.Writer((_Module as ucStartTest2).ListTestModel, (_Module as ucStartTest2).List子阵Model));
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.E:
                    DockPanelShowControl();
                    break;
                case Keys.W:
                    richTextBox1.Clear();
                    break;
                case Keys.Q:
                    if (windowsUIButtonPanel1.Buttons.FindFirst(m => m.Properties.Caption == "打开串口(Q)") != null)
                    {
                        SerialPortControl(true);
                    }
                    else
                    {
                        SerialPortControl(false);
                    }
                    break;
                case Keys.Space:
                    SendCommands();
                    break;
                case Keys.R:
                    //(_Module as ucStartTest2).ResetTestView();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 添加文本
        /// </summary>
        /// <param name="style"></param>
        /// <param name="content"></param>
        public void AppendTexxt(string style,string content)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new EventHandler(delegate {
                    richTextBox1.AppendText(style + "：" + content + "\n");
                    if (richTextBox1.Lines.Count() > 1000)
                    {
                        richTextBox1.Clear();
                    }
                }));
            }
            else
            {
                richTextBox1.AppendText(style + "：" + content + "\n");
                if (richTextBox1.Lines.Count()>1000)
                {
                    richTextBox1.Clear();
                }
            }          

        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", Application.StartupPath + "\\" + "延迟线收发组件-十六通道测试软件.exe.config");
        }
    }
}
