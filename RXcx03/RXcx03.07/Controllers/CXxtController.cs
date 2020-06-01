using RXcx03._07.List;
using RXcx03._07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RXcx03._07.Controllers
{
    public class CXxtController : Controller
    {
        //写到这里可能不会更新信息。
        // private static Model1 db = new Model1();
        // GET: CXxt
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult CXWS(AtriclList tiaoJian)
        {
            ViewBag.queryList = queryWSXM(tiaoJian);
            ViewBag.JSSJ = tiaoJian.TJsjdw;
            return View();
        }
        public ActionResult CXDJQK(AtriclList tiaoJian)
        {
            ViewBag.queryList = queryDJXX(tiaoJian);
            // ViewBag.JSSJ = tiaoJian.TJsjdw;
            return View();
        }
        public ActionResult CXWS2(AtriclList tiaoJaian)
        {

            List<AtriclList> list = GetListws(tiaoJaian);
            ViewBag.queryList = list;
            return View();
        }
        public ActionResult CXDJ2(AtriclList tiaoJaian)
        {

            List<AtriclList> list = GETListDJ(tiaoJaian);
            //List<AtriclList> list = queryCX();
            ViewBag.queryList = list;
           
            return View();
        }
        public  ActionResult CXDW(AtriclList tiaoJaian)
        {
            List<AtriclList> list = GETListDW(tiaoJaian);
            ViewBag.queryList = list;

            return View();
        }

        /// <summary>
        /// 外送项目查询方法
        /// </summary>
        /// <param name="tiaoJian"></param>
        /// <returns></returns> 
        private List<AtriclList> queryWSXM(AtriclList tiaoJian)
        {
            Model1 db = new Model1();
            //输入或者不输入
            if (tiaoJian.JSRiQi <= DateTime.MinValue)
            {
                tiaoJian.JSRiQi = DateTime.Today.AddDays(+1);
            }
            else { tiaoJian.JSRiQi = tiaoJian.JSRiQi.AddDays(+1); }
            if (tiaoJian.KSRiQi <= DateTime.MinValue)
            {
                // new DateTime(2018, 10, 1)
                tiaoJian.KSRiQi = DateTime.Today;
            }
            //双选，单选
            string k = "01";
            string f = "02";
            if (tiaoJian.TJsjdw == k)
            {
                k = "01";
                f = "01";
            }
            else if (tiaoJian.TJsjdw == f)
            {
                f = "02";
                k = "02";
            }

            //类似SQL查询，查询值并存表格
            var query = from a in db.TJ_TJDJB
                        join b in db.TJ_TJJLB
                        on a.TJBH equals b.TJBH
                        join c in db.TJ_ZHXM_HD
                        //相同字段关联
                        on b.TJXMBH equals c.BH
                        //条件
                       // where b.LXBH == "06"
                        //这个做成选项
                        where c.ZDYM == k || c.ZDYM == f
                        where a.DJRQ >= tiaoJian.KSRiQi && a.DJRQ <= tiaoJian.JSRiQi
                        //排序
                        //orderby a.CreateTime
                        select new AtriclList { TJBH = a.TJBH, DJLSH = a.DJLSH, XM = a.XM, XB = a.XB,  HD_MC = c.MC, DJRQ = a.DJRQ, ZDYM = c.ZDYM, LXBH = b.LXBH };
            var list = Common.ToList<AtriclList>(query);

            return list;
        }
        /// <summary>
        /// 登记情况查询
        /// </summary>
        /// <returns></returns>
        private List<AtriclList> queryDJXX(AtriclList tiaoJian)
        {
            Model1 db = new Model1();
            if (tiaoJian.JSRiQi <= DateTime.MinValue)
            {
                //在结束时间上+1天
                tiaoJian.JSRiQi = DateTime.Today.AddDays(+1);
            }
            else { tiaoJian.JSRiQi = tiaoJian.JSRiQi.AddDays(+1); }
            if (tiaoJian.KSRiQi <= DateTime.MinValue)
            {
                tiaoJian.KSRiQi = DateTime.Today;
            }


            var query = from c in db.TJ_TJDJB
                            //where a.DJRQ >=  DateTime.MinValue && a.DJRQ <= DateTime.MaxValue       DWBH = c.DWBH,       TCMC = d.MC ,     
                        where c.DJRQ >= tiaoJian.KSRiQi && c.DJRQ <= tiaoJian.JSRiQi
                        select new AtriclList
                        {
                            DJLSH = c.DJLSH,
                            TJBH = c.TJBH,
                            DJRQ = c.DJRQ,
                            XM = c.XM,
                            XB = c.XB,
                            NL = c.NL,
                            TJCS = c.TJCS,
                            SUMOVER = c.SUMOVER,
                            PHONE = c.PHONE,
                            DWBH = c.DWBH
                        };

            var list = Common.ToList(query);
            // list.Distinct<DJXXList>(new Compare()).ToList().ForEach(S => Console.WriteLine(S.ToString()));
            list = list.Distinct<AtriclList>(new Compare()).ToList();
            return list;
        }
        /// <summary>
        /// 剔除重复后的查询方法
        /// </summary>
        /// <returns></returns>
        private List<AtriclList> queryCX()
        {
            Model2 db2 = new Model2();
            var query = from a in db2.VIEW_DJCX
                        select new AtriclList
                        {
                            TJBH = a.体检编号,
                            DJLSH = a.登记流水号,
                            DJRQ = a.登记日期,
                            XM = a.姓名,
                            XB = a.性别,
                            NL = a.年龄,
                            TJCS = a.体检次数,
                            SUMOVER = a.体检状态,
                            PHONE = a.联系方式,
                            DWBH = a.单位编号,
                            TCMC = a.套餐名称,
                            ZDYM = a.项目编号,
                            LXBH = a.外送项目,
                            XMDJ = a.项目单价,
                            XMMC = a.项目名称
                        };
            //对iqueryable重新组合，并查询

            var list = Common.ToList(query);
            

            return list;           
        }
        private List<AtriclList> queryDW()
        {
            Model2 db2 = new Model2();
            var query = from a in db2.VIEW_DWYYDJ
                        select new AtriclList
                        {
                            TJBH1 = a.预约编号,
                            DWBH1 = a.单位名称,
                            TCMC1 = a.分组名称,
                            DJRQ1 = a.体检时间,
                            XB1 = a.性别,
                            XM1 = a.姓名,
                            PHONE = a.电话号码,
                            SFDJ = a.是否到检
                        };

            var list = Common.ToList(query);
            return list;
        }

        private List<AtriclList> GETlistWS(AtriclList tiaoJian)
        {
            if (tiaoJian.JSRiQi <= DateTime.MinValue)
            {
                tiaoJian.JSRiQi = DateTime.Today.AddDays(+1);
            }
            else { tiaoJian.JSRiQi = tiaoJian.JSRiQi.AddDays(+1); }
            if (tiaoJian.KSRiQi <= DateTime.MinValue)
            {
                // new DateTime(2018, 10, 1)
                tiaoJian.KSRiQi = DateTime.Today;
            }
            string k = "01";
            string f = "02";
            if (tiaoJian.TJsjdw == k)
            {
                k = "01";
                f = "01";
            }
            else if (tiaoJian.TJsjdw == f)
            {
                f = "02";
                k = "02";
            }
            //重新组成表，增加查询条件
            var queryWS = queryCX().Select(a => new AtriclList { TJBH = a.TJBH, DJLSH = a.DJLSH, XM = a.XM, XB = a.XB, NL = a.NL, DJRQ = a.DJRQ, ZDYM = a.ZDYM, LXBH = a.LXBH, XMMC = a.XMMC })
                .Where(m => m.DJRQ >= tiaoJian.KSRiQi && m.DJRQ <= tiaoJian.JSRiQi);
                queryWS = queryWS.Where(m => m.LXBH == k || m.LXBH == f);
            
            var list = Common.ToList(queryWS);
            list = list.Distinct<AtriclList>(new Compare()).ToList(); //这一步好像是去重
            return list;
        }
        private List<AtriclList> GETListDJ(AtriclList tiaoJian)
        {
            if (tiaoJian.JSRiQi <= DateTime.MinValue)
            {
                tiaoJian.JSRiQi = DateTime.Today.AddDays(+1);
            }
            else { tiaoJian.JSRiQi = tiaoJian.JSRiQi.AddDays(+1); }
            if (tiaoJian.KSRiQi <= DateTime.MinValue)
            {
                // new DateTime(2018, 10, 1)
                tiaoJian.KSRiQi = DateTime.Today;
            }
            var queryDJ = queryCX().Where(m => m.DJRQ >= tiaoJian.KSRiQi && m.DJRQ <= tiaoJian.JSRiQi);

            if (null != tiaoJian.DWCX)
                queryDJ = queryDJ.Where(m => m.DWBH == tiaoJian.DWCX);
            //TOLOST
            var list = Common.ToList(queryDJ);
            //去重复
            list = list.Distinct<AtriclList>(new Compare()).ToList();
            return list;
        }
        private List<AtriclList> GETListDW(AtriclList tiaoJian)
        {
            if (tiaoJian.JSRiQi <= DateTime.MinValue)
            {
                tiaoJian.JSRiQi = DateTime.Today.AddDays(+1);
            }
            else { tiaoJian.JSRiQi = tiaoJian.JSRiQi.AddDays(+1); }
            if (tiaoJian.KSRiQi <= DateTime.MinValue)
            {
                // new DateTime(2018, 10, 1)
                tiaoJian.KSRiQi = new DateTime(2018, 10, 1);
            }
            var query = queryDW().Where(m => m.DJRQ1 >= tiaoJian.KSRiQi && m.DJRQ1 <= tiaoJian.JSRiQi  || m.DJRQ1 == null);

            if (null != tiaoJian.DWCX)
                query = query.Where(m => m.DWBH1 == tiaoJian.DWCX);
            if (null != tiaoJian.DJCX)
                query = query.Where(m => m.SFDJ == tiaoJian.DJCX);
            //TOLOST
            var list = Common.ToList(query);          
            return list;

        }


        private List<AtriclList> GetListws(AtriclList tiaoJian)//增加了第三个查询，取消了去重
        {
            if (tiaoJian.JSRiQi <= DateTime.MinValue)
            {
                tiaoJian.JSRiQi = DateTime.Today.AddDays(+1);
            }
            else { tiaoJian.JSRiQi = tiaoJian.JSRiQi.AddDays(+1); }
            if (tiaoJian.KSRiQi <= DateTime.MinValue)
            {
                // new DateTime(2018, 10, 1)
                tiaoJian.KSRiQi = DateTime.Today;
            }

            var queryWS = queryCX().Select(a => new AtriclList { TJBH = a.TJBH, DJLSH = a.DJLSH, XM = a.XM, XB = a.XB, NL = a.NL, DJRQ = a.DJRQ, ZDYM = a.ZDYM, LXBH = a.LXBH, XMMC = a.XMMC });

            //var queryWS = queryCX().Select(a => new AtriclList { TJBH = a.TJBH, DJLSH = a.DJLSH, XM = a.XM, XB = a.XB, DJRQ = a.DJRQ, ZDYM = a.ZDYM, LXBH = a.LXBH, XMMC = a.XMMC });


            if (null != tiaoJian)    
            queryWS = queryWS.Where(m => m.DJRQ >= tiaoJian.KSRiQi && m.DJRQ <= tiaoJian.JSRiQi);

            if(null != tiaoJian.TJsjdw)
            queryWS = queryWS.Where(m => m.LXBH == tiaoJian.TJsjdw);

            var list = Common.ToList(queryWS);
            return list;
        }
   
        //新增一个类来存这些条件值。。暂时不弄。。。。。
        private void TJcl(AtriclList tiaoJian)
        {
            if (tiaoJian.JSRiQi <= DateTime.MinValue)
            {
                tiaoJian.JSRiQi = DateTime.Today.AddDays(+1);
            }
            else { tiaoJian.JSRiQi = tiaoJian.JSRiQi.AddDays(+1); }
            if (tiaoJian.KSRiQi <= DateTime.MinValue)
            {
                // new DateTime(2018, 10, 1)
                tiaoJian.KSRiQi = DateTime.Today;
            }
            string k = "01";
            string f = "02";
            if (tiaoJian.TJsjdw == k)
            {
                k = "01";
                f = "01";
            }
            else if (tiaoJian.TJsjdw == f)
            {
                f = "02";
                k = "02";
            }
        }

    }
}