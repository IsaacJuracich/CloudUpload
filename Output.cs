using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudUpload {
    public partial class Output : Form {
        public Cloud_Upload_Settings.Settings settings = new Cloud_Upload_Settings.Settings("settings.ini");
        public Output() {
            InitializeComponent();
        }
        private void Output_Load(object sender, EventArgs e) {
            if (settings.Read("ouputFile", "CloudUpload.Logs") == null || settings.Read("ouputFile", "CloudUpload.Logs") == "") {
                OuputBuffer.Text = Cloud_Upload_Errors.Errors.OuputFileNull.ToString();
                System.IO.File.WriteAllText("defaultbuffer.txt", Cloud_Upload_Errors.Errors.OuputFileNull.ToString());
            }
            else updateOutputBuffer();
        }
        private void OuputBuffer_TextChanged(object sender, EventArgs e) {

        }
        private void Home_Click(object sender, EventArgs e) {
            this.Hide();
            Form main = new Main();
            main.Closed += (s, args) => this.Close();
            main.Location = this.Location;
            main.StartPosition = FormStartPosition.Manual;
            main.Show();
        }
        private void Upload_Click(object sender, EventArgs e) {
            this.Hide();
            Form upload = new Upload();
            upload.Closed += (s, args) => this.Close();
            upload.Location = this.Location;
            upload.Show();
        }
        private void Settings_Click(object sender, EventArgs e) {
            this.Hide();
            Form settings = new Settings();
            settings.Closed += (s, args) => this.Close();
            settings.Location = this.Location;
            settings.Show();
        }
        private async void updateOutputBuffer() {
            while (true) {
                if (settings.Read("ouputFile", "CloudUpload.Logs") == null || settings.Read("ouputFile", "CloudUpload.Logs") == "") {
                    OuputBuffer.Text = Cloud_Upload_Errors.Errors.OuputFileNull.ToString();
                    System.IO.File.WriteAllText("defaultbuffer.txt", Cloud_Upload_Errors.Errors.OuputFileNull.ToString());
                }
                else {
                    string tosend = null;
                    foreach (string str in System.IO.File.ReadAllText(settings.Read("ouputFile", "CloudUpload.Logs")).Split('\n'))
                        tosend = tosend + $"\r\n{str}\n";
                    OuputBuffer.Text = tosend;
                }
                await Task.Delay(2500);
            }
        }
        private void Reset_Click(object sender, EventArgs e) {
            System.IO.File.WriteAllText(settings.Read("ouputFile", "CloudUpload.Logs"), "");
        }
    }
}
