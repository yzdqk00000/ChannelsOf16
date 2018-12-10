using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 延迟线收发组件_十六通道.Modules.Model
{
    public class TestModel2
    {
        public string 通道号 { get; set; }
        public string 衰减 { get; set; } = "0dB";
        public string 移相 { get;set;}= "0°";
        public bool 通道开关 { get; set; } = false;
    }
}
