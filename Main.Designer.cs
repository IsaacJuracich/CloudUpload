
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
            this.Ram = new System.Windows.Forms.Label();
            this.Cpu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // Ram
            // 
            this.Ram.AutoSize = true;
            this.Ram.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Ram.Location = new System.Drawing.Point(650, 440);
            this.Ram.Name = "Ram";
            this.Ram.Size = new System.Drawing.Size(80, 42);
            this.Ram.TabIndex = 4;
            this.Ram.Text = "RAM:";
            // 
            // Cpu
            // 
            this.Cpu.AutoSize = true;
            this.Cpu.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Cpu.Location = new System.Drawing.Point(650, 395);
            this.Cpu.Name = "Cpu";
            this.Cpu.Size = new System.Drawing.Size(74, 42);
            this.Cpu.TabIndex = 5;
            this.Cpu.Text = "CPU:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(-5, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "________________________________________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Chiller", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(-3, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 111);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(846, 508);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cpu);
            this.Controls.Add(this.Ram);
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
        private System.Windows.Forms.Label Ram;
        private System.Windows.Forms.Label Cpu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

