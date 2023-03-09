using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Risks
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void Selection_Load(object sender, EventArgs e)
        {

        }

        //Upload CSV and display success or failure message        
        private void upload_btn_Click(object sender, EventArgs e)
        {            
            Globals.CSV_PATHS = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();            
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Globals.CSV_PATHS = openFileDialog.FileNames.ToList();
                if (Globals.CSV_PATHS == null || Globals.CSV_PATHS.Count < 1)
                {
                    MessageBox.Show("File/files upload failed.");
                }
                else 
                {
                    MessageBox.Show("File/files uploaded successfully");
                    this.Hide();
                    Results result = new Results(((Button)sender).Name);
                    result.ShowDialog();
                }
            }
        }

        //Select Heart attack rule
        private void heart_btn_Click(object sender, EventArgs e)
        {
            if (Globals.CSV_PATHS == null || Globals.CSV_PATHS.Count < 1) 
            {
                MessageBox.Show("No data uploaded.");
            }
            else
            {
                this.Hide();
                Results result = new Results(((Button)sender).Name);
                result.ShowDialog();
            }
        }

        //Select calc2 rule
        private void calc2_btn_Click(object sender, EventArgs e)
        {            
            if (Globals.CSV_PATHS == null || Globals.CSV_PATHS.Count < 1) 
            {
                MessageBox.Show("No data uploaded.");
            }
            else
            {
                this.Hide();
                Results result = new Results(((Button)sender).Name);
                result.ShowDialog();
            }
        }

        //Select calc3 rule
        private void calc3_btn_Click(object sender, EventArgs e)
        {            
            if (Globals.CSV_PATHS == null || Globals.CSV_PATHS.Count < 1)
            {
                MessageBox.Show("No data uploaded.");
            }
            else
            {
                this.Hide();
                Results result = new Results(((Button)sender).Name);
                result.ShowDialog();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void selection_exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
