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
    public static class AutoimmuneCalculator
    {
        public static string findAutoImmuneRisk(List<string> CSV_PATHS)
        {
            //var CSV_PATH = "C:\\Users\\18328\\Desktop\\MedicalRiskData\\HeartAttackRisk1.xlsx"; //*todo
            //var ws = ReadPath(CSV_PATH);
            var ws = Utilities.ReadMultipleFiles(CSV_PATHS); 

            var WEIGHT_COL = 1;
            var WB_COL = 3;
            var RB_COL = 4;


            var rows = ws.Rows;
            var autoimmuneRiskList = new List<double>();
            foreach (DataRow row in rows)
            {
                var weight = Convert.ToDouble(row.ItemArray[WEIGHT_COL]);
                if (weight > 45)   // //TODO:need to change values inside the dataset to reflect real data
                {
                    var autoimmuneRisk = AutoimmunePrediction(row, WEIGHT_COL, WB_COL, RB_COL);

                    autoimmuneRiskList.Add(autoimmuneRisk);

                }
            }
            double averageAutoimmuneRisk = FindAutoimmuneAverage(autoimmuneRiskList);

            return ($"From this dataset, there is a {averageAutoimmuneRisk} % risk of indiviuals developing an autoimmune disease within their lifetime ");
        }
        private static DataTable ReadPath(string CSV_PATH)
        {
            var wb = WorkBook.Load(CSV_PATH);
            var ws = wb.DefaultWorkSheet.ToDataTable(true).AsEnumerable()
                .Where(row => !row.ItemArray.All(value => value.Equals(string.Empty))).CopyToDataTable();

            var ds = wb.ToDataSet(true);
            return ws;
        }


        private static double AutoimmunePrediction(DataRow row, int WEIGHT_COL, int WB_COL, int RB_COL)
        {

            var weight = Convert.ToDouble(row.ItemArray[WEIGHT_COL]);
            var whiteBloodCellCount = Convert.ToDouble(row.ItemArray[WB_COL]);
            var redBloodCellCount = Convert.ToDouble(row.ItemArray[RB_COL]);

            var autoimmuneCal = (whiteBloodCellCount + redBloodCellCount) / weight * 10;
            return autoimmuneCal; //maybe return age here also 

        }
        private static double FindAutoimmuneAverage(List<double> autoimmuneList)
        {
            return autoimmuneList.Average();
        }
    }
}
