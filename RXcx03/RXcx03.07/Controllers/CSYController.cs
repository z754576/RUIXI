using RXcx03._07.List;
using RXcx03._07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RXcx03._07.Controllers
{
    public class CSYController : Controller
    {
        // GET: CSY
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CXDJ3(AtriclList tiaoJaian)
        {           
            List<AtriclList> list = queryCX();
            ViewBag.queryList = list;

            return View();
        }

              
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
                            //DWBH = a.单位编号,
                            //TCMC = a.套餐名称,
                            //ZDYM = a.项目编号,
                            //LXBH = a.外送项目,
                            //XMDJ = a.项目单价,
                            //XMMC = a.项目名称
                        };
            //对iqueryable重新组合，并查询

            var list = Common.ToList(query);

            return list;
        }
    }
}