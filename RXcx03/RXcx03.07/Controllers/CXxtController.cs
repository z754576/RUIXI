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

        public ActionResult CXWS2(AtriclList tiaoJaian)
        {

            List<AtriclList> list = GetListws(tiaoJaian);
            ViewBag.queryList = list;
            return View();
        }

        public ActionResult CXWS3(AtriclList tiaoJaian)
        {
            tiaoJaian.TJsjdw = "10";
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

        public ActionResult CXXJ(AtriclList tiaoJaian)
        {

            List<AtriclList> list = GETListXJ(tiaoJaian);
            ViewBag.queryList = list;
            return View();
        }

        /// <summary>
        /// 剔除重复后的查询方法
        /// </summary>
        /// <returns></returns>
        private List<AtriclList> queryCX()
        {
            Model2 db2 = new Model2();
            var query = from a in db2.VIEW_DJCX123
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
                            SFZH = a.身份证号,
                            DWBH = a.单位编号,
                            TCMC = a.套餐名称,
                            FZMC = a.单位分组,
                            ZDYM = a.项目编号,
                            TJXJ = a.体检小结,
                            KS = a.科室,
                            LXBH = a.外送项目,
                            XMDJ = a.项目单价,
                            XMMC = a.项目名称,
                            JSR = a.介绍人,
                            JCZT = a.检查状态,
                            BZ = a.备注
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
                            DJRQ1 = a.预登记时间,
                            DJRQ = a.体检时间,
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
        private List<AtriclList> GETListXJ(AtriclList tiaoJian)
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

            var queryWS = queryCX().Select(a => new AtriclList
            {
                TJBH = a.TJBH,
                DJLSH = a.DJLSH,
                XM = a.XM,
                XB = a.XB,
                NL = a.NL,
                DJRQ = a.DJRQ,
                ZDYM = a.ZDYM,
                LXBH = a.LXBH,
                XMMC = a.XMMC,
                TJXJ = a.TJXJ,
                KS = a.KS,
                SFZH = a.SFZH,
                PHONE = a.PHONE,
                DWBH = a.DWBH,
                JCZT = a.JCZT,
                BZ = a.BZ
            });

            queryWS = queryWS.Where(m => m.KS != "54    ");

            if (null != tiaoJian)
                queryWS = queryWS.Where(m => m.DJRQ >= tiaoJian.KSRiQi && m.DJRQ <= tiaoJian.JSRiQi);

            if (null != tiaoJian.TJsjdw)
                queryWS = queryWS.Where(m => m.KS == tiaoJian.TJsjdw);

            if (null != tiaoJian.DJCX)
            {
                if (tiaoJian.DJCX == "0" || tiaoJian.DJCX == "2")
                {
                    queryWS = queryWS.Where(m => m.TJXJ == null);
                    if (tiaoJian.DJCX == "0")
                    {
                        queryWS = queryWS.Where(m => m.JCZT == "未检");
                    }
                    else
                    {
                        queryWS = queryWS.Where(m => m.JCZT == "拒检");
                    }
                }
                else
                {
                    queryWS = queryWS.Where(m => m.TJXJ != null);
                }
            }

            if (null != tiaoJian.XB1)
            {

                queryWS = queryWS.Where(m => m.XB == tiaoJian.XB1);
            }

            var list = Common.ToList(queryWS);
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

            var queryWS = queryCX().Select(a => new AtriclList { TJBH = a.TJBH, DJLSH = a.DJLSH, XM = a.XM, XB = a.XB, NL = a.NL, DJRQ = a.DJRQ, ZDYM = a.ZDYM, LXBH = a.LXBH, XMMC = a.XMMC,
            SFZH = a.SFZH,PHONE = a.PHONE,DWBH = a.DWBH ,JCZT = a.JCZT});

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