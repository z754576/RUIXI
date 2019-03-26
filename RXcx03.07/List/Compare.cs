using RXcx03._07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RXcx03._07.List
{
    /// <summary>
    /// LIST剔重
    /// </summary>
    public class Compare : IEqualityComparer<AtriclList>
    {
        public bool Equals(AtriclList x, AtriclList y)
        {
            return x.DJLSH.ToUpper() == y.DJLSH.ToUpper();//可以自定义去重规则，此处将Id相同的就作为重复记录，不管学生的爱好是什么
        }
        public int GetHashCode(AtriclList obj)
        {
            return obj.DJLSH.GetHashCode();
        }
    }
}