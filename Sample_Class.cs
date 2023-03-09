using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Risks
{
    public class Sample_Class
    {
        public static void SampleMethod()
        {
            Debug.WriteLine("sample method run");
        }

        public static string SampleFunction(string str) => str.ToUpper();

        public static string ExtractAllMale(string str)
        {
            return str.ToUpper();
        }

        public static double CalculateRiskSampleOutput()
        {
            return 55.23;
        }
    }
}
