using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CG.Web.MegaApiClient;

namespace CloudUpload {
    public partial class Upload : Form {
        public Upload() {
            InitializeComponent();
        }
        private void Upload_Load(object sender, EventArgs e) {

        }
        private void Home_Click(object sender, EventArgs e) {
            this.Hide();
            Form main = new Main();
            main.Closed += (s, args) => this.Close();
            main.Location = this.Location;
            main.StartPosition = FormStartPosition.Manual;
            main.Show();
        }
        private void Output_Click(object sender, EventArgs e) {
            this.Hide();
            Form output = new Output();
            output.Closed += (s, args) => this.Close();
            output.Location = this.Location;
            output.Show();
        }
        private void Settings_Click(object sender, EventArgs e) {
            this.Hide();
            Form settings = new Settings();
            settings.Closed += (s, args) => this.Close();
            settings.Location = this.Location;
            settings.Show();
        }
        private void Login_Click(object sender, EventArgs e) {
            Cloud_Upload_Settings.Settings settings = new Cloud_Upload_Settings.Settings("settings.ini");
            Program.client = new MegaApiClient();
            Program.client.Login(settings.Read("mega_email", "CloudUpload.Settings"), settings.Read("mega_password", "CloudUpload.Settings"));
            OuputBuffer.Text += $"\nMega Client Logged In";
            string toWrite = null;
            foreach (var i in Program.client.GetSessionsHistory())
                toWrite = toWrite + "\n" + $"IP: {i.IpAddress} | LoginTime: {i.LoginTime} | LastSeen: {i.LastSeenTime}";
            System.IO.File.WriteAllText("outputbuffer.txt", $"{System.IO.File.ReadAllText("outputbuffer.txt") + "\n" + toWrite}");
        }
        private void Logout_Click(object sender, EventArgs e) {
            if (Program.client == null) {
                OuputBuffer.Text += $"\nNo Current Mega Client Is Logged In";
                System.IO.File.WriteAllText("outputbuffer.txt", $"{System.IO.File.ReadAllText("outputbuffer.txt") + "\n" + $"{Cloud_Upload_Errors.Errors.NoClientError}"}");
            }
            else {
                Program.client.Logout();
                OuputBuffer.Text += $"\nMega Client Logged Out";
            }
        }
    }
}
