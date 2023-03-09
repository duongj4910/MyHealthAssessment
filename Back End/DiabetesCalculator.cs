using IronXL;
using Medical_Risks.Back_End;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Risks.Back_End
{
    public static class DiabetesCalculator
    {
        public static string findDiabetesPrediction(List<string> CSV_PATHS)
        {

            //var ws = ReadPath(CSV_PATH);
            var ws = Utilities.ReadMultipleFiles(CSV_PATHS);

            var WEIGHT_COL = 9;
            var CHOLESTROL_COL = 10 ;
            var BP_COL = 2;
            var GLUCOSE_COL = 1;

            var rows = ws.Rows;
            var diabetesRiskList = new List<double>();

            foreach (DataRow row in rows)
            {

                var diabetesRisk = diabetesPrediction(row, WEIGHT_COL, CHOLESTROL_COL, BP_COL, GLUCOSE_COL);

                diabetesRiskList.Add(diabetesRisk);


            }
            var diabetesAverageRisk = FindDiabetesRiskAverage(diabetesRiskList);

            return ($"From this dataset, there is a  {diabetesAverageRisk} % risk of individuals developing diabetes within their lifetime ");

        }
        private static double diabetesPrediction(DataRow row, int WEIGHT_COL, int CHOLESTROL_COL, int BP_COL, int GLUCOSE_COL)
        {
            var weight = Convert.ToDouble(row.ItemArray[WEIGHT_COL]);
            var cholestrol = Convert.ToDouble(row.ItemArray[CHOLESTROL_COL]);
            var bloopressure = Convert.ToDouble(row.ItemArray[BP_COL]);
            var gluclose = Convert.ToDouble(row.ItemArray[GLUCOSE_COL]);

            var diabetesCal = (cholestrol + bloopressure + weight) * gluclose / 1000;
            return diabetesCal;
        }

        private static double FindDiabetesRiskAverage(List<double> diabetesRiskList)
        {
            return diabetesRiskList.Average();
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
