namespace Medical_Risks
{
    partial class Selection
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
            upload_btn = new Button();
            heart_btn = new Button();
            calc2_btn = new Button();
            calc3_btn = new Button();
            selection_exit_btn = new Button();
            logout_btn = new Button();
            SuspendLayout();
            // 
            // upload_btn
            // 
            upload_btn.Location = new Point(116, 81);
            upload_btn.Name = "upload_btn";
            upload_btn.Size = new Size(229, 86);
            upload_btn.TabIndex = 0;
            upload_btn.Text = "Upload Data";
            upload_btn.UseVisualStyleBackColor = true;
            upload_btn.Click += upload_btn_Click;
            // 
            // heart_btn
            // 
            heart_btn.Location = new Point(449, 81);
            heart_btn.Name = "heart_btn";
            heart_btn.Size = new Size(229, 86);
            heart_btn.TabIndex = 1;
            heart_btn.Text = "Calculate Heart Failure Risk";
            heart_btn.UseVisualStyleBackColor = true;
            heart_btn.Click += heart_btn_Click;
            // 
            // calc2_btn
            // 
            calc2_btn.Location = new Point(116, 233);
            calc2_btn.Name = "calc2_btn";
            calc2_btn.Size = new Size(229, 86);
            calc2_btn.TabIndex = 2;
            calc2_btn.Text = "Calculate Diabetes Risk";
            calc2_btn.UseVisualStyleBackColor = true;
            calc2_btn.Click += calc2_btn_Click;
            // 
            // calc3_btn
            // 
            calc3_btn.Location = new Point(449, 233);
            calc3_btn.Name = "calc3_btn";
            calc3_btn.Size = new Size(229, 86);
            calc3_btn.TabIndex = 3;
            calc3_btn.Text = "Calculate Autoimmune Risk";
            calc3_btn.UseVisualStyleBackColor = true;
            calc3_btn.Click += calc3_btn_Click;
            // 
            // selection_exit_btn
            // 
            selection_exit_btn.Location = new Point(672, 401);
            selection_exit_btn.Name = "selection_exit_btn";
            selection_exit_btn.Size = new Size(116, 37);
            selection_exit_btn.TabIndex = 4;
            selection_exit_btn.Text = "Exit";
            selection_exit_btn.UseVisualStyleBackColor = true;
            selection_exit_btn.Click += selection_exit_btn_Click;
            // 
            // logout_btn
            // 
            logout_btn.Location = new Point(536, 401);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(116, 37);
            logout_btn.TabIndex = 5;
            logout_btn.Text = "Log Out";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout_btn);
            Controls.Add(selection_exit_btn);
            Controls.Add(calc3_btn);
            Controls.Add(calc2_btn);
            Controls.Add(heart_btn);
            Controls.Add(upload_btn);
            Name = "Selection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selection";
            Load += Selection_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button upload_btn;
        private Button heart_btn;
        private Button calc2_btn;
        private Button calc3_btn;
        private Button selection_exit_btn;
        private Button logout_btn;
    }
}