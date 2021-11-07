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
        public Output() {
            InitializeComponent();
        }

        private void Output_Load(object sender, EventArgs e) {
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
    }
}
