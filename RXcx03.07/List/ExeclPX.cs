using RXcx03._07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RXcx03._07.List
{
    public class ExeclPX
    {
       public Model1 db = new Model1();

        public List<AtriclList> getlist0(AtriclList tiaoJian)
        {
            
            if (tiaoJian.JSRiQi == null)
            {
                tiaoJian.JSRiQi = DateTime.Now;
            }
            if(tiaoJian.KSRiQi == null)
            {
                tiaoJian.KSRiQi = new DateTime(2018,10,1);
            }
            
            string[] TJdw = new string[2] { "01", "02" };
            if(tiaoJian.TJsjdw != null)
            {
                if(tiaoJian.TJsjdw == TJdw[0]) { TJdw[1] = TJdw[0]; }
                else { TJdw[0] = TJdw[1]; }
            }

            //类似SQL查询，查询值并存表格
            var query = from a in db.TJ_TJDJB
                        join b in db.TJ_TJJLB
                        on a.TJBH equals b.TJBH
                        join c in db.TJ_ZHXM_HD
                        //相同字段关联
                        on b.TJXMBH equals c.BH
                        //条件
                        where b.LXBH == "06"
                        //这个做成选项
                        where c.ZDYM == TJdw[0] || c.ZDYM == TJdw[1]
                        where a.DJRQ >= tiaoJian.KSRiQi && a.DJRQ <= tiaoJian.JSRiQi
                        //排序
                        //orderby a.CreateTime
                        select new AtriclList { TJBH = a.TJBH, DJLSH = a.DJLSH, XM = a.XM, XB = a.XB, NL = a.NL, HD_MC = c.MC, DJRQ = a.DJRQ, ZDYM = c.ZDYM, LXBH = b.LXBH };
            var list = Common.ToList<AtriclList>(query);
            return list;
        }
    }
}