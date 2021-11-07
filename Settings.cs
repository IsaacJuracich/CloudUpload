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
    public partial class Settings : Form {
        public Settings() {
            InitializeComponent();
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
        private void Settings_Load(object sender, EventArgs e) {
            OuputBuffer.Text = System.IO.File.ReadAllText("settings.ini");
        }

        private void Upload_Click(object sender, EventArgs e) {
            this.Hide();
            Form upload = new Upload();
            upload.Closed += (s, args) => this.Close();
            upload.Location = this.Location;
            upload.Show();
        }
        private void Reset_Click(object sender, EventArgs e) {
            System.IO.File.WriteAllText("settings.ini", "");
            OuputBuffer.Text = "Settings File has been reset to default";
        }
        private async void Update_Click(object sender, EventArgs e) {
            System.IO.File.WriteAllText("settings.ini", OuputBuffer.Text);
            OuputBuffer.Text = "Settings File has been updated";
            await Task.Delay(3500);
            OuputBuffer.Text = System.IO.File.ReadAllText("settings.ini");
        }
    }
}
