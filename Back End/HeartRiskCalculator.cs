using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IronXL;

namespace Medical_Risks.Back_End

{
    public static class HeartRiskCalculator
    {
        //insert calculateRisk (main method)
        // var rows = ws.Rows;
        //CSV PATH 

        public static string CalculateRisk(List<string> CSV_PATHS)
        {

            //var CSV_PATH = "C:\\Users\\18328\\Desktop\\MedicalRiskData\\HeartAttackRisk1.xlsx";
            var ws = Utilities.ReadMultipleFiles(CSV_PATHS);

            var AGE_COL = 1;
            var GENDER_COL = 2;
            var WEIGHT_COL = 3;
            var rows = ws.Rows;

            var riskList = new List<double>();


            foreach (DataRow row in rows)
            {
                var age = Convert.ToDouble(row.ItemArray[AGE_COL]);
                if (age > 45)
                {
                    var risk = CalculateHeartAttackRisk(row, GENDER_COL, WEIGHT_COL, AGE_COL);
                    riskList.Add(risk);
                }
            }

            double averageHeartAttackRisk = FindAverageHeartAttackRisk(riskList);
            return $"From this dataset, there is a {averageHeartAttackRisk} % of an indiviual over 45 years to experience heart failure. ";

        }


        private static double CalculateHeartAttackRisk(DataRow row, int GENDER_COL, int WEIGHT_COL, int AGE_COL)
        {
            var age = Convert.ToDouble(row.ItemArray[AGE_COL]);
            var gender = Convert.ToDouble(row.ItemArray[GENDER_COL]);
            var weight = Convert.ToDouble(row.ItemArray[WEIGHT_COL]);

            var ageCal = age + gender + weight;
            return ageCal;
        }

        private static double FindAverageHeartAttackRisk(List<double> riskList)
        {
            return riskList.Average();
        }

        private static DataTable ReadPath(string CSV_PATH)
        {
            var wb = WorkBook.Load(CSV_PATH);
            var ws = wb.DefaultWorkSheet.ToDataTable(true).AsEnumerable()
                .Where(row => !row.ItemArray.All(value => value.Equals(string.Empty))).CopyToDataTable();

            var ds = wb.ToDataSet(true);
            return ws;
        }


    }
}