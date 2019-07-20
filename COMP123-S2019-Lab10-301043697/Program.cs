using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301043697
{
    static class Program
    {
        public static StartForm startform;
        public static MainForm mainform;
        public static EndForm endform;

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startform = new StartForm();
            mainform = new MainForm();
            endform = new EndForm();

            Application.Run(new StartForm());

        }
    }
}
