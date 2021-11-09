
namespace CloudUpload
{
    partial class Upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload));
            this.Home = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Label();
            this.OuputBuffer = new System.Windows.Forms.TextBox();
            this.FileUpload = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Url = new System.Windows.Forms.Label();
            this.URLLINK = new System.Windows.Forms.TextBox();
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
            this.Home.TabIndex = 4;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Output.Location = new System.Drawing.Point(24, 75);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(74, 34);
            this.Output.TabIndex = 6;
            this.Output.Text = "Output";
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // Settings
            // 
            this.Settings.AutoSize = true;
            this.Settings.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Settings.Location = new System.Drawing.Point(24, 120);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(83, 34);
            this.Settings.TabIndex = 7;
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Login.Location = new System.Drawing.Point(24, 425);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(60, 34);
            this.Login.TabIndex = 8;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Logout.Location = new System.Drawing.Point(24, 465);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(72, 34);
            this.Logout.TabIndex = 9;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // OuputBuffer
            // 
            this.OuputBuffer.AcceptsTab = true;
            this.OuputBuffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.OuputBuffer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OuputBuffer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.OuputBuffer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OuputBuffer.Location = new System.Drawing.Point(106, -1);
            this.OuputBuffer.Multiline = true;
            this.OuputBuffer.Name = "OuputBuffer";
            this.OuputBuffer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OuputBuffer.Size = new System.Drawing.Size(629, 517);
            this.OuputBuffer.TabIndex = 10;
            // 
            // FileUpload
            // 
            this.FileUpload.AutoSize = true;
            this.FileUpload.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.FileUpload.Location = new System.Drawing.Point(743, 395);
            this.FileUpload.Name = "FileUpload";
            this.FileUpload.Size = new System.Drawing.Size(71, 34);
            this.FileUpload.TabIndex = 11;
            this.FileUpload.Text = "Upload";
            this.FileUpload.Click += new System.EventHandler(this.FileUpload_Click);
            // 
            // Url
            // 
            this.Url.AutoSize = true;
            this.Url.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Url.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Url.Location = new System.Drawing.Point(743, 440);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(91, 34);
            this.Url.TabIndex = 12;
            this.Url.Text = "FolderUrl";
            this.Url.Click += new System.EventHandler(this.Url_Click);
            // 
            // URLLINK
            // 
            this.URLLINK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.URLLINK.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLLINK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.URLLINK.Location = new System.Drawing.Point(741, 476);
            this.URLLINK.Name = "URLLINK";
            this.URLLINK.Size = new System.Drawing.Size(100, 32);
            this.URLLINK.TabIndex = 13;
            this.URLLINK.Text = "null";
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(846, 508);
            this.Controls.Add(this.URLLINK);
            this.Controls.Add(this.Url);
            this.Controls.Add(this.FileUpload);
            this.Controls.Add(this.OuputBuffer);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Home);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(862, 547);
            this.MinimumSize = new System.Drawing.Size(862, 547);
            this.Name = "Upload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CloudUpload | Upload";
            this.Load += new System.EventHandler(this.Upload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label Settings;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.TextBox OuputBuffer;
        private System.Windows.Forms.Label FileUpload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label Url;
        private System.Windows.Forms.TextBox URLLINK;
    }
}