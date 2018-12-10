using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace 延迟线收发组件_十六通道
{
    public class SerialPort_Module
    {
        //实例化串口类
        SerialPort sp = new SerialPort();
        private RichTextBox _RichTextBox;
        //构造函数  
        public SerialPort_Module(RichTextBox richText)
        {
            sp.PortName = "COM1";
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.ReadTimeout = 15000;
            sp.WriteTimeout = 10000;

            //初始化接收
            sp.DataReceived += new SerialDataReceivedEventHandler(this.SerialPort_Recv);
            _RichTextBox = richText;
        }

        //获取所有计算机可用串口
        public string[] GetPorts { get { return SerialPort.GetPortNames(); } }

        //设置串口
        public void SerialPort_Set(string portName, int baud)
        {
            sp.PortName = portName;
            sp.BaudRate = baud;
        }

        //打开串口
        public void SerialPort_Open()
        {
            sp.Open();
        }

        //关闭串口
        public void SerialPort_Close()
        {
            sp.Close();
        }

        //串口发送数据
        public void SerialPort_Send(byte[] sendBytes)
        {
            try
            {
                sp.Write(sendBytes, 0, sendBytes.Length);
                _RichTextBox.AppendText("发送："+Function_Module.RecvProgress_STR(sendBytes) + "\n");
            }
            catch (Exception ex)
            {
                _RichTextBox.AppendText("发送：" + ex.Message + "\n");
            }
        }


        //串口接收数据
        public string[] recvArray { get; set; }
        public void SerialPort_Recv(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string recvData = "";

                byte[] recvByte = new byte[sp.BytesToRead];
                sp.Read(recvByte, 0, recvByte.Length);

                for (int i = 0; i < recvByte.Length; i++)
                {
                    recvData += recvByte[i].ToString("x2") + " ";
                }


                if (_RichTextBox.InvokeRequired)
                {
                    _RichTextBox.Invoke(new EventHandler(delegate {
                        _RichTextBox.AppendText("接收：" + recvData + "\n");
                    }));
                }
                else
                {
                    _RichTextBox.AppendText("接收：" + recvData + "\n");
                }

            }
            catch (Exception ex)
            {
                if (_RichTextBox.InvokeRequired)
                {
                    _RichTextBox.Invoke(new EventHandler(delegate {
                        _RichTextBox.AppendText("接收：" + ex.Message + "\n");
                    }));
                }
                else
                {
                    _RichTextBox.AppendText("接收：" + ex.Message + "\n");
                }
            }

       
        }

    }
}
