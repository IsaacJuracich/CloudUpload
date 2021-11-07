using System;
using System.Windows.Forms;
using CG.Web.MegaApiClient;

namespace CloudUpload {
    static class Program {
        public static MegaApiClient client;
        [STAThread]
        static void Main()  {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
