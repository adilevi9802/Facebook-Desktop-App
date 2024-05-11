using System;
using System.Windows.Forms;
using FacebookWrapper;

// $G$ THE-001 (-6) grade 94 on patterns selection / accuracy in implementation / description / document / diagrams (50%) (see comments in document)

namespace FacebookWinFormsApp
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
