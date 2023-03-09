namespace Medical_Risks
{
    partial class Results
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.result_TxtBox = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.result_Exit_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // result_TxtBox
            // 
            this.result_TxtBox.Location = new System.Drawing.Point(26, 292);
            this.result_TxtBox.Multiline = true;
            this.result_TxtBox.Name = "result_TxtBox";
            this.result_TxtBox.ReadOnly = true;
            this.result_TxtBox.Size = new System.Drawing.Size(485, 128);
            this.result_TxtBox.TabIndex = 1;
            this.result_TxtBox.Text = "Default Text";
            this.result_TxtBox.VisibleChanged += new System.EventHandler(this.Results_Load);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(588, 292);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(158, 53);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // result_Exit_Btn
            // 
            this.result_Exit_Btn.Location = new System.Drawing.Point(588, 367);
            this.result_Exit_Btn.Name = "result_Exit_Btn";
            this.result_Exit_Btn.Size = new System.Drawing.Size(158, 53);
            this.result_Exit_Btn.TabIndex = 3;
            this.result_Exit_Btn.Text = "Exit";
            this.result_Exit_Btn.UseVisualStyleBackColor = true;
            this.result_Exit_Btn.Click += new System.EventHandler(this.result_Exit_Btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(720, 244);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.Results_Load);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.result_Exit_Btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.result_TxtBox);
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox result_TxtBox;
        private Button back_btn;
        private Button result_Exit_Btn;
        private DataGridView dataGridView1;
    }
}