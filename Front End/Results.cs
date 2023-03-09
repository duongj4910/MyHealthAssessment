using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Medical_Risks.Back_End;

namespace Medical_Risks
{
    public partial class Results : Form
    {
        private string buttonName;
        public Results(string buttonName)
        {
            InitializeComponent();
            this.buttonName = buttonName;
        }

        private void Results_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            foreach (string path in Globals.CSV_PATHS)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line = sr.ReadLine();
                    if (line == null)
                    {
                        continue;
                    }
                    string[] columns = line.Split(',');
                    foreach (string col in columns)
                    {
                        if (!dataTable.Columns.Contains(col))
                        {
                            dataTable.Columns.Add(col);
                        }
                    }
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        DataRow row = dataTable.NewRow();
                        for (int i = 0; i < fields.Length; i++)
                        {
                            if (i < dataTable.Columns.Count)
                            {
                                if (fields[i] != "")
                                {
                                    row[dataTable.Columns[i]] = fields[i];
                                }
                                else
                                {
                                    row[dataTable.Columns[i]] = 0;
                                }
                            }
                        }
                        dataTable.Rows.Add(row);
                    }
                }
            }
            dataGridView1.DataSource = dataTable;

            //Display result of rule based on what button was clicked
            Selection selection = new Selection();        
            
            if (buttonName == "upload_btn")
            {
                result_TxtBox.Text = "";
            }
            if (buttonName == "heart_btn")
            {
                result_TxtBox.Text = HeartRiskCalculator.CalculateRisk(Globals.CSV_PATHS); 
            }                
            if (buttonName == "calc2_btn")
            {
                result_TxtBox.Text = DiabetesCalculator.findDiabetesPrediction(Globals.CSV_PATHS);                    
            }            
            if (buttonName == "calc3_btn")
            {
                result_TxtBox.Text = AutoimmuneCalculator.findAutoImmuneRisk(Globals.CSV_PATHS);                    
            }               
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selection selection = new Selection();
            selection.ShowDialog();
        }

        private void result_Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
