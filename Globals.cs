using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Risks
{
    public class Globals
    {
        /// <summary>
        /// Variables to call between frontend and backend
        /// </summary>
        public static string? CSV_PATH { get; set; }
        public static List<string>? CSV_PATHS { get; set; }

        public double? RISK { get; set; }
        
     

        /// <summary>
        /// static constants
        /// </summary>
        public static DirectoryInfo MEDICAL_RISKS_DIR { get => medical_risks_directory;}
        public static string HEART_RISK1 { get => HeartRisk1;}
        public static string HEART_RISK2 { get => HeartRisk2; }
        public static string DIABETES_FILE1 { get => DiabetesFile1; }
        public static string DIABETES_FILE2 { get => DiabetesFile2; }
        public static string AUTOIMMUNEE_FILE1 { get => AutoimmuneFile1; }
        public static string AUTOIMMUNEE_FILE2 { get => AutoimmuneFile2; }



        public enum RULE { HeartAttack, Diabetes, Autoimmune } 
        public static Dictionary<RULE, List<string>> ATTRIBUTES { get => attributes; }


        private static DirectoryInfo medical_risks_directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent;
        private static string HeartRisk1 =
            Path.Combine(MEDICAL_RISKS_DIR.FullName, "Medical_Risks\\Resources\\HeartAttackRisk1.csv");
        private static string HeartRisk2 =
            Path.Combine(MEDICAL_RISKS_DIR.FullName, "Medical_Risks\\Resources\\HeartAttackRisk2.csv");
        private static string DiabetesFile1 =
            Path.Combine(MEDICAL_RISKS_DIR.FullName, "Medical_Risks\\Resources\\DiabetesRisk1.csv");
        private static string DiabetesFile2 =
            Path.Combine(MEDICAL_RISKS_DIR.FullName, "Medical_Risks\\Resources\\DiabetesRisk2.csv");
        private static string AutoimmuneFile1 =
            Path.Combine(MEDICAL_RISKS_DIR.FullName, "Medical_Risks\\Resources\\AutoimmuneRisk1.csv");
        private static string AutoimmuneFile2 =
            Path.Combine(MEDICAL_RISKS_DIR.FullName, "Medical_Risks\\Resources\\AutoimmuneRisk2.csv");

        private static Dictionary<RULE, List<string>> attributes = 
            new Dictionary<RULE, List<string>>()
            {
                { RULE.HeartAttack, new List<string>(){ "Age", "Sex", "Weight"} },
                { RULE.Diabetes, new List<string>(){ "Weight", "Cholesterol", "Blood Pressure", "Glucose" } },
                { RULE.Autoimmune, new List<string>(){ "Weight", "WB", "RB"} }
            };

    }
}
