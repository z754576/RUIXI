 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RXcx03._07.List
{
    public class Common
    {
        public static List<T> ToList<T>(IEnumerable<T> data)
        {
            List<T> list = new List<T>();
            var propertys = System.ComponentModel.TypeDescriptor.GetProperties(typeof(T));
            foreach (var item in data)
            {
                T t = Activator.CreateInstance<T>();
                Type type = t.GetType();
                foreach (System.ComponentModel.PropertyDescriptor p in propertys)
                {
                    object o = p.GetValue(item);
                    t.GetType().GetProperty(p.Name).SetValue(t, o, null);
                }
                list.Add(t); 
            }
            return list;
        }
    }
}