using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RXcx03._07.Models
{
    public class AtriclList
    {
        public string TJBH { get; set; }
        public string DJLSH { get; set; }
        public string XM { get; set; }
        public string XB { get; set; }
        public int? NL { get; set; }
        public string HD_MC { get; set; }
        public DateTime? DJRQ { get; set; }
        public string ZDYM { get; set; }
        public string LXBH { get; set; }
        public int? TJCS { get; set; }
        //条件
        public string XiangMu { get; set; }
        public string Gongsi { get; set; }
        public DateTime KSRiQi { get; set; }
        public DateTime JSRiQi { get; set; }
        public string TJsjdw { get; set; }

        // public Tuple<string,string> TJSJDW { get; set; }
        public string SUMOVER { get; set; }
        public string PHONE { get; set; }
        public string DWBH { get; set; }
        public decimal XMDJ { get; set; }
        public string XMMC { get; set; }
        public string TCMC { get; set; }
  
    }
}