
namespace CloudUpload
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Home = new System.Windows.Forms.Label();
            this.Upload = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.OuputBuffer = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Home.Location = new System.Drawing.Point(24, 30);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(59, 34);
            this.Home.TabIndex = 3;
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
            this.Upload.TabIndex = 4;
            this.Upload.Text = "Upload";
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Output.Location = new System.Drawing.Point(24, 75);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(74, 34);
            this.Output.TabIndex = 5;
            this.Output.Text = "Output";
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // OuputBuffer
            // 
            this.OuputBuffer.AcceptsTab = true;
            this.OuputBuffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.OuputBuffer.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OuputBuffer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.OuputBuffer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OuputBuffer.Location = new System.Drawing.Point(106, -1);
            this.OuputBuffer.Multiline = true;
            this.OuputBuffer.Name = "OuputBuffer";
            this.OuputBuffer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OuputBuffer.Size = new System.Drawing.Size(745, 517);
            this.OuputBuffer.TabIndex = 6;
            this.OuputBuffer.TextChanged += new System.EventHandler(this.OuputBuffer_TextChanged);
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Reset.Location = new System.Drawing.Point(24, 465);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(63, 34);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Update.Location = new System.Drawing.Point(24, 425);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 34);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update";
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(846, 508);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.OuputBuffer);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Home);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(862, 547);
            this.MinimumSize = new System.Drawing.Size(862, 547);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CloudUpload | Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.Label Upload;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.TextBox OuputBuffer;
        private System.Windows.Forms.Label Reset;
        private System.Windows.Forms.Label Update;
    }
}