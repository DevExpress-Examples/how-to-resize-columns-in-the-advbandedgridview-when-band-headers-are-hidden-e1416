using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Q203466 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dxt2.Form1());
        }
    }
}