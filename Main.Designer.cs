﻿
namespace CloudUpload
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Output = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Label();
            this.Upload = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Output.Location = new System.Drawing.Point(24, 75);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(74, 34);
            this.Output.TabIndex = 0;
            this.Output.Text = "Output";
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Home.Location = new System.Drawing.Point(24, 30);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(59, 34);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Upload
            // 
            this.Upload.AutoSize = true;
            this.Upload.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Upload.Location = new System.Drawing.Point(24, 120);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(71, 34);
            this.Upload.TabIndex = 2;
            this.Upload.Text = "Upload";
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Settings
            // 
            this.Settings.AutoSize = true;
            this.Settings.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Settings.Location = new System.Drawing.Point(24, 165);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(83, 34);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(846, 508);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(862, 547);
            this.MinimumSize = new System.Drawing.Size(862, 547);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloudUpload";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.Label Upload;
        private System.Windows.Forms.Label Settings;
    }
}
