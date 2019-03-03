using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var excel = new NetOffice.ExcelApi.Application();
            var word = new NetOffice.WordApi.Application();
            var outlook = new NetOffice.OutlookApi.Application();
            var powerpoint = new NetOffice.PowerPointApi.Application();
        }
    }
}
