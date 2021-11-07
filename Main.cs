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
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e) {
        }
        private void Output_Click(object sender, EventArgs e) {
            this.Hide();
            Form output = new Output();
            output.Closed += (s, args) => this.Close();
            output.Location = this.Location;
            output.Show();
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

        private void Home_Click(object sender, EventArgs e) {

        }
    }
}
