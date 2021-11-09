using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudUpload {
    public partial class Main : Form {
        public bool breakTask = false;
        public Main() {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e) {
            breakTask = false;
            stats();
        }
        private void Output_Click(object sender, EventArgs e) {
            breakTask = true;
            this.Hide();
            Form output = new Output();
            output.Closed += (s, args) => this.Close();
            output.Location = this.Location;
            output.Show();
        }
        private void Upload_Click(object sender, EventArgs e) {
            breakTask = true;
            this.Hide();
            Form upload = new Upload();
            upload.Closed += (s, args) => this.Close();
            upload.Location = this.Location;
            upload.Show();
        }
        private void Settings_Click(object sender, EventArgs e) {
            breakTask = true;
            this.Hide();
            Form settings = new Settings();
            settings.Closed += (s, args) => this.Close();
            settings.Location = this.Location;
            settings.Show();
        }

        private void Home_Click(object sender, EventArgs e) {
            return;
        }
        private async void stats() {
            while (true) {
                if (breakTask) break;
                Program.getUsage();
                Cpu.Text = "CPU: " + Program.cpuV + "%";
                Ram.Text = "RAM: " + Program.ramV + "MB";
                await Task.Delay(500);
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
