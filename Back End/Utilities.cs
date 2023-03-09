using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronXL;


namespace Medical_Risks.Back_End
{
    public static class Utilities
    {
        /// <summary>
        ///  Reads multiple files with the same format
        /// </summary>
        /// <param name="CSV_PATHS"></param>
        public static DataTable ReadMultipleFiles(List<string> CSV_PATHS)
        {
            DataTable dt = new DataTable();
            foreach (var file in CSV_PATHS)
            {
                var ws = ReadPath(file);
                dt.Merge(ws);
            }
            return dt;
        }

        public static DataTable ReadPath(string CSV_PATH)
        {
            var wb = WorkBook.Load(CSV_PATH);
            var ws = wb.DefaultWorkSheet.ToDataTable(true).AsEnumerable()
                .Where(row => !row.ItemArray.All(value => value.Equals(string.Empty))).CopyToDataTable();

            var ds = wb.ToDataSet(true);
            return ws;
        }
    }
}
