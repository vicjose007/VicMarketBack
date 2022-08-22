using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VicMarket.Application.Extensions
{
    public static class StringExtensions
    {
        public static string GetPropertyName(this string name)
        {
            if (name == null)
                return null;

            if (name.Contains("."))
                return name.Split('.').LastOrDefault().GetPropertyName();

            return name;
        }
    }
}
